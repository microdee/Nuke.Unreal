# Nuke.Unreal {#mainpage}

<div align="center">

<img width="540px" src="nu.full.onLight.svg" alt="light-mode" />
<img width="540px" src="nu.full.onDark.svg" alt="dark-mode" />

![](https://badgen.net/nuget/v/md.Nuke.Unreal)

&nbsp;

**[Source code](https://github.com/microdee/Nuke.Unreal)**

</div>

Elegant workflow for automating Unreal Engine project tasks embracing [Nuke](https://nuke.build), providing a consistent way to use UE4/5 tools and reducing chores they come with.

## Features:

* All what the great [Nuke](https://nuke.build) can offer
* Common Unreal build tasks (generate project files, build editor, cook, package, etc)
  ```
  > nuke generate
  > nuke build-editor
  > nuke cook
  > nuke package
  > nuke build --config Shipping
  > nuke build --config DebugGame Development --target-type Game --platform Android
  ```
* Unreal engine location is automatically determined (on Windows at least)
* Execute Unreal tools without the need to navigate to their location
  ```
  > nuke run-uat --> <args...>
  > nuke run-ubt --> <args...>
  > nuke run-shell
  > nuke run --tool editor-cmd --> <args...>
  ```
* Install C++ libraries (using [xrepo](https://xrepo.xmake.io))
  ```
  > nuke use-xrepo --spec "imgui 1.91.1 freetype=true" "vcpkg::ryml[dbg]" "conan::zlib/1.2.11"
  > nuke generate
  ```
* Generate boilerplate code and scaffolding from [Scriban](https://github.com/scriban/scriban) templates so no editor needs to be opened
    ```
    > nuke new-actor --name MyActor
    > nuke new-plugin --name MyPlugin
    > nuke new-module --name MyModule
    > nuke use-cmake --spec MyLibrary
    etc...
    ```
* Auto-generated C# configurators for Unreal tools with documentation gathered from source code. (UBT and UAT)
* Pluggable way to define targets for reusable plugins and modules.
* Prepare complex Unreal Plugins for distribution with easy to use API.

Use the sidebar to read further details about them.

## Legal {#Legal}

**Nuke.Unreal** is distributed under MIT license:

Copyright (c) David Mórász

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

The following tools and .NET libraries are used:

* [NUKE](https://nuke.build)
* [Nuke.Cola](https://mcro.de/md.Nuke.Cola)
* [Scriban](https://github.com/scriban/scriban)
* [dotnet-script](https://github.com/dotnet-script/dotnet-script)
* [EverythingSearchClient](https://github.com/sgrottel/EverythingSearchClient)
* [xxHash](https://github.com/Cyan4973/xxHash)
* [Humanizer](https://github.com/Humanizr/Humanizer)
* [Konsole](https://github.com/goblinfactory/konsole/)
* [Doxygen](https://www.doxygen.nl/index.html)
* [Doxygen Awesome](https://jothepro.github.io/doxygen-awesome-css/)