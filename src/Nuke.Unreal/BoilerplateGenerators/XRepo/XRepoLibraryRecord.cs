using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuke.Unreal.BoilerplateGenerators.XRepo;

public record XRepoLibraryRecord(
    LibrarySpec Spec,
    string Options,
    string OptionsHelp,
    string? Description,
    IEnumerable<string> IncludePaths,
    IEnumerable<string> SysIncludePaths,
    IEnumerable<string> LibFiles,
    IEnumerable<string> SysLinks,
    IEnumerable<string> Defines
);