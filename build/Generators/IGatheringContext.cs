namespace build.Generators;
public interface IGatheringContext { }

public interface IHaveSubTools
{
    ToolModel[] SubTools { get; }
}

public interface IHaveLogDisplayInfo
{
    int Indentation { get; }
}