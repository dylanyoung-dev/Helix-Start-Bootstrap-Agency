module.exports = function () {
    var sitecoreRoot = "C:\\Sitecore\\example-agency";
    var config = {
        websiteRoot: sitecoreRoot + "\\Website",
        sitecoreLibraries: sitecoreRoot + "\\Website\\bin",
        solutionName: "Helix",
        licensePath: sitecoreRoot + "\\Data\\license.xml",
        runCleanBuilds: false
    };
    return config;
};