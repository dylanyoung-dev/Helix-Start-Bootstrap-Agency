Param(
    [string]$BuildConfiguration
)

Import-Module ".\Invoke-MsBuild.psm1" -Verbose

Invoke-MsBuild -Path "..\Helix.sln" -MsBuildParameters "/p:DeployOnBuild=true /p:PublishProfile=$($BuildConfiguration)" -ShowBuildOutputInNewWindow -LogVerbosityLevel minimal