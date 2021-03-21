This utility is built with UE4 source code. It's distributed here as an executable so this repo doesn't rely on said engine source code. A pull request has been made https://github.com/EpicGames/UnrealEngine/pull/7849 to include this functionality inside official builds, and hopefully the launcher one day.

## Usage

Returns the path to newest installed engine version:
```
UnrealLocator
```

Returns the path to a specified installed engine version:
```
UnrealLocator 4.25
```

Returns the path to the installed engine version associated with the provided project:
```
UnrealLocator /path/to/MyGame.uproject
```