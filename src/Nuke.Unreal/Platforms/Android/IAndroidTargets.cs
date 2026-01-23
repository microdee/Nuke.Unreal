using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Nuke.Cola;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using Nuke.Unreal.Ini;
using Serilog;

namespace Nuke.Unreal.Platforms.Android;

public interface IAndroidTargets
    : IAndroidBuildTargets
    , IAndroidDeployTargets
;
