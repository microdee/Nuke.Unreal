# Getting started {#GettingStarted}

> [!WARNING]
> `dotnet` is required to be installed first.

## Install via remote script

Navigate to your project with powershell and execute this:

```powershell
Set-ExecutionPolicy Unrestricted -Scope Process -Force; iex (iwr 'https://raw.githubusercontent.com/microdee/Nuke.Unreal/refs/heads/main/install/install.ps1').ToString()
```

> [!WARNING]
> Very important that the directory this is executed in is your Unreal project root. Otherwise you will install Nuke.Unreal to some random place and it may not find your project.

## Install manually

Nuke.Unreal is available as a Nuget package and you can just add it to your build project as usual (package ID is `md.Nuke.Unreal`)

1. <details><summary>Install Nuke for an Unreal project</summary>  
   
   ```
   > dotnet tool install Nuke.GlobalTool --global
   
   > nuke :setup
     select None for solution
     build project inside Nuke.Targets folder
   
   > nuke :add-package md.Nuke.Unreal
   ```
   
   </details>
2. Inherit your Build class from `UnrealBuild` instead of `NukeBuild` and make it `public`
3. Use `Main () => Plugins.Execute<Build>(Execute);` instead of `Main () => Execute();`
4. No further boilerplate required, run `nuke --plan` to test Nuke.Unreal
5. ***(optional)*** Inherit `IPackageTargets` interface if you want to package the associated Unreal project

Your bare-bones minimal Build.cs which will provide the default features of Nuke.Unreal should look like this:

```CSharp
// Build.cs
using Nuke.Common;
using Nuke.Unreal;
using Nuke.Cola.BuildPlugins;

public class Build : UnrealBuild
{
    public static int Main () => Plugins.Execute<Build>(Execute);
}
```

It is also recommended to set up auto-completion for your shell

<div class="tabbed">

<ul>

<li>

<b class="tab-title">Powershell:</b>

```powershell
# $PROFILE
Register-ArgumentCompleter -Native -CommandName nuke -ScriptBlock {
    param($commandName, $wordToComplete, $cursorPosition)
    nuke :complete "$wordToComplete" | ForEach-Object {
        [System.Management.Automation.CompletionResult]::new($_, $_, 'ParameterValue', $_)
    }
}
```

</li>

<li>

<b class="tab-title">Bash:</b>

```bash
# .bashrc
_nuke_bash_complete()
{
    local word=${COMP_WORDS[COMP_CWORD]}
    local completions="$(nuke :complete "${COMP_LINE}")"
    COMPREPLY=( $(compgen -W "$completions" -- "$word") )
}
complete -f -F _nuke_bash_complete nuke
```

</li>

</ul>

</div>