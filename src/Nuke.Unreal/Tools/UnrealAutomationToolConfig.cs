using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuke.Unreal.Tools;

public class UnrealAutomationToolConfig : UnrealAutomationToolConfigGenerated
{
    public override string Gather() => string.Join(' ', Arguments);
}