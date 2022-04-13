using Nuke.Common;

namespace Nuke.Unreal
{
    public interface ISelf
    {
        T Self<T>() where T : INukeBuild => (T)(object)this;
    }
}