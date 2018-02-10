var gulp = require("gulp");
var msbuild = require("gulp-msbuild");
var debug = require("gulp-debug");
var path = require("path");
var nugetRestore = require("gulp-nuget-restore");
var fs = require("fs");
var util = require("gulp-util");

var merge = require("merge-stream");
var runSequence = require("run-sequence");

var config = require('./gulp-config.js')();

module.exports.config = config;

gulp.task('default', function (callback) {
    return runSequence(
        "Copy-Sitecore-Dlls",
        callback);
});

////////////////////////////
//    Move Sitecore Dlls
////////////////////////////
gulp.task('_Copy-Sitecore-Dlls', function () {

    fs.statSync(config.sitecoreLibraries);

    var files = config.sitecoreLibraries + "/**/*";

    var libs = gulp.src(files).pipe(gulp.dest("./Libraries"));

    return merge(libs);

});

////////////////////////////
//    Publish All Projects
////////////////////////////
gulp.task('task:Publish-All-Projects', function() {
    var publishScript = `${__dirname}\\..\\scripts\\Publish.ps1`;

    var process = exec("powershell.exe -executionpolicy unrestricted -File \"" + publishScript + "\" -BuildConfiguration \"" + env.buildConfiguration + "\"", function (err, stdout, stderr) {
        if (err !== null) throw err;
        console.log(stdout);
    });
});

////////////////////////////
//     Compile Assets
////////////////////////////
gulp.task('_Compile-Assets', function () {

});