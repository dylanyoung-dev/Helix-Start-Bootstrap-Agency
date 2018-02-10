Param(
    [string]$BuildConfiguration
)

Import-Module "C:\TFS\GLHomes\Main\source\GulpTasks\..\scripts\Invoke-MsBuild.psm1" -Verbose

Invoke-MsBuild -Path "C:\Development\Helix-Start-Bootstrap\Helix.sln" -MsBuildParameters "/p:DeployOnBuild=true /p:PublishProfile=$($BuildConfiguration)" -ShowBuildOutputInNewWindow -LogVerbosityLevel minimal