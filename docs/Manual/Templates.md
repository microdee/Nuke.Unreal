# Unreal boilerplate templates {#Templates}

Nuke.Unreal provides some targets which creates boilerplate code for common Unreal entities, such as

* Plugins
* Modules
* Unreal Object/Actor/Structs/Interfaces

without the need for opening the Unreal editor or extend heavy weight IDE's. These boilerplate targets work with Scriban templates. The path to these templates can be overridden in the actual Nuke build class in case a project requires further boilerplate. Example:

In any folder in your project do

```
> nuke new-actor --name MyPreciousActor
```

This will generate MyPreciousActor.h and ~.cpp at their respective places (taking public and private folders into account) and the minimal actor class boilerplate for unreal.

## Use your own templates

Optional **Custom templates** folders are required to contain generator specific subfolders. If a subfolder doesn't exist for a generator the default will be used. Example:

Given directory scaffolding:

```
<project root>
├── ...
├── MyTemplates
│   ├── Actor
│   └── Object
└── Nuke.Targets
        Build.cs
        ...
```

In `Nuke.Targets/Build.cs` override `TemplatesPath` property
```CSharp
public override AbsolutePath TemplatesPath { get; set; } = RootDirectory / "MyTemplates";
```

This way Actor and Object generators will have their project specific Scriban templates but the remaining generator types will use the default templates of Nuke.Unreal.