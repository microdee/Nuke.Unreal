namespace build.Generators;
public interface IGatheringContext { }

public interface IHaveSubTools
{
    ToolModel[] SubTools { get; }
}

public interface IHaveTargetClass
{
    GatheredClass TargetClass { get; }
}

public interface IHaveLogDisplayInfo
{
    int Indentation { get; }
}