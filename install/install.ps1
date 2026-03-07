
$progressPreference = 'silentlyContinue';
if (-not (Test-Path .\.nuke\temp)) {
    mkdir .\.nuke\temp
}

"Fetching Nuke.Unreal boilerplate for this project"
Invoke-WebRequest -Uri https://github.com/microdee/Nuke.Unreal/releases/download/Fresh/Fresh.zip -OutFile .\.nuke\temp\Fresh.zip
Expand-Archive -Path .\.nuke\temp\Fresh.zip -DestinationPath .

"Installing Nuke global tool"
dotnet tool install Nuke.GlobalTool --version 9.0.4 --global

"Updating Nuke.Unreal"
nuke :add-package md.Nuke.Unreal