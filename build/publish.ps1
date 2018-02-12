Param(
    [string]$BuildConfiguration
)

Import-Module "C:\Development\Helix-Start-Bootstrap\build\Invoke-MsBuild.psm1" -Verbose

Invoke-MsBuild -Path "C:\Development\Helix-Start-Bootstrap\Helix.sln" -MsBuildParameters "/p:DeployOnBuild=true /p:PublishProfile=$($BuildConfiguration)" -ShowBuildOutputInNewWindow -LogVerbosityLevel minimal -KeepBuildLogOnSuccessfulBuilds