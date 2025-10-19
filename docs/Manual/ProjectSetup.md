# Setting up for a project {#ProjectSetup}

Nuke.Unreal targets looks for the `*.uproject` file automatically and it will use the first one it finds. A `*.uproject` is required to be present even for plugin development (more on plugins below). Automatically found project files can be in the sub-folder tree of Nuke's root (which is the folder containing the `.nuke` temporary folder) or in parent folders of Nuke's root. If for any reason there are more than one or no `*.uproject` files in that area, the developer can specify an explicit location of the associated `*.uproject` file.

```CSharp
public override AbsolutePath ProjectPath => RootDirectory / ".." / "MyProject" / "MyProject.uproject";
```