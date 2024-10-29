using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuke.Unreal.BoilerplateGenerators.XRepo;

public enum XRepoPlatform
{
    android,
    appletvos,
    applexros,
    bsd,
    cygwin,
    haiku,
    harmony,
    iphoneos,
    linux,
    macos,
    mingw,
    msys,
    wasm,
    watchos,
    windows,
    cross,
}

public enum XRepoArch
{
    arm,
    arm64,
    arm64__v8a,
    arm64ec,
    armeabi,
    armeabi__v7a,
    armv7,
    armv7k,
    armv7s,
    i386,
    loong64,
    mip64,
    mips,
    mips64,
    mips64el,
    mipsel,
    ppc,
    ppc64,
    riscv,
    riscv64,
    s390x,
    sh4,
    wasm32,
    wasm64,
    x64,
    x86,
    x86_64,
}

public record XRepoPlatformArch(XRepoPlatform Platform, XRepoArch Arch)
{
    public XRepoPlatformArch(string platform, string arch)
        : this(Enum.Parse<XRepoPlatform>(platform), XRepoUtils.GetArch(arch)) {}
}