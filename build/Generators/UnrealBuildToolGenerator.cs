using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using Serilog;
using Nuke.Common.Utilities;
using build.Generators.Replicated.Tools.DotNETCommon;
using build.Generators.Replicated.UnrealBuildTool;
using Nuke.Common.IO;
using Humanizer;

namespace build.Generators;

public partial class UnrealBuildToolGenerator : ToolGenerator
{
    public override string TemplateName => "UnrealBuildToolConfigGenerated";

    private record UbtModel(ToolModel UnrealBuildTool);

    [GeneratedRegex("[^a-zA-Z0-9_]")]
    private static partial Regex InvalidCharacters();

    private object _model = null;
    protected override object Model
    {
        get
        {
            if (_model != null) return _model;

            var ueAssemblies = Unreal.GetInstance(UnrealVersion).Assemblies;
            var cmdLineAttrMapping = CommandLineAttribute.Mapping(ueAssemblies);
            var toolModeMapping = ToolMode.Mapping(ueAssemblies);
            var toolModeAttributeMapping = ToolModeAttribute.Mapping(ueAssemblies);

            UbtModel model = new(
                new ToolModel {
                    ConfigName = "UnrealBuildTool",
                    CliName = "UnrealBuildTool",
                    ConfigType = new(TemplateName.Replace("Generated", ""), TemplateName),
                    ClassKeywords = "abstract",
                    Description = "Unreal Build Tool compiles the binaries of Unreal projects"
                }
            );

            var ubtTool = model.UnrealBuildTool;
            
            void ProcessNewTool(ToolModel tool)
            {
                // Add special cases here
            }

            ArgumentModel GetArgument(MemberInfo member, Type memberType, CommandLineAttribute cmdLine)
            {
                if (string.IsNullOrWhiteSpace(cmdLine.Prefix))
                {
                    cmdLine.Prefix = $"-{member.Name}";
                }
                var name = cmdLine.Prefix[1..].TrimEnd('=').TrimEnd(':');
                var csharpName = name[0] switch
                {
                    '_' => name,
                    >= 'a' and <= 'z' => name,
                    >= 'A' and <= 'Z' => name,
                    _ => "_" + name
                };
                csharpName = InvalidCharacters().Replace(csharpName, "_").Pascalize();

                bool IsScalarType(Type T)
                {
                    return new [] {
                        typeof(short),
                        typeof(int),
                        typeof(long),
                        typeof(ushort),
                        typeof(uint),
                        typeof(ulong),
                        typeof(float),
                        typeof(double),
                        typeof(decimal)
                    }.Any(t => t == T);
                }

                bool hasValue = string.IsNullOrWhiteSpace(cmdLine.Value);
                var type = ArgumentModelType.Switch;
                if (hasValue)
                {
                    type = ArgumentModelType.Text;
                    if (memberType == typeof(bool))
                        type = ArgumentModelType.Bool;
                    
                    else if (IsScalarType(memberType))
                        type = ArgumentModelType.Scalar;
                    
                    else if (memberType.IsArray && memberType.GetElementType() != null)
                    {
                        if (IsScalarType(memberType.GetElementType()))
                            type = ArgumentModelType.ScalarCollection;
                        else type = ArgumentModelType.TextCollection;
                    }
                }

                return new() {
                    ConfigName = csharpName,
                    CliName = "-" + name,
                    ArgumentType = type,
                    CollectionSeparator = cmdLine.ListSeparator.ToString(),
                    ValueSetter = "=:".Any(c => c == cmdLine.Prefix[^1])
                        ? cmdLine.Prefix[^1].ToString()
                        : "="
                    // TODO: description
                };
            }

            void ProcessMember(MemberInfo member, ToolModel tool)
            {
                Type memberType = member switch
                {
                    FieldInfo field => field.FieldType,
                    PropertyInfo prop => prop.PropertyType,
                    _ => null
                };
                if (memberType == null)
                {
                    Log.Error("    Ignoring {0} because it was neither a field, nor a property", member.Name);
                    return;
                }
                Log.Information("    {0} {1}", memberType.GetDisplayShortName(), member.Name);

                var cmdLineAttributes = member.GetCustomAttributes(cmdLineAttrMapping.UeType, false);
                foreach(var cmdLineUnreal in cmdLineAttributes)
                {
                    var cmdLine = cmdLineAttrMapping.FromUnreal(cmdLineUnreal);
                    var arg = GetArgument(member, memberType, cmdLine);
                    if (tool.AddArgument(arg, ubtTool))
                    {
                        Log.Information("        {0} {1} ({2})", arg.ArgumentType, arg.ConfigName, arg.CliName);
                    }
                }
            }

            foreach(var ubtType in ueAssemblies.UnrealBuildTool.GetTypes())
            {
                var members = ubtType.GetMembers()
                    .Where(m => m.GetCustomAttributes(cmdLineAttrMapping.UeType, false).Length > 0)
                    .ToArray();

                if (members.Length == 0) continue;
                Log.Information("Processing UBT type: {0}", ubtType.GetDisplayName());
                
                var toolModeAttrs = ubtType.GetCustomAttributes(toolModeAttributeMapping.UeType, false);
                var targetToolModel = ubtTool;
                bool contributeToGlobal = true;
                foreach(var toolModeAttr in toolModeAttrs)
                {
                    contributeToGlobal = false;
                    var localToolModeAttr = toolModeAttributeMapping.FromUnreal(toolModeAttr);
                    Log.Information("    Subtool: {0}", localToolModeAttr.Name);
                    var toolCandidate = ubtTool.Subtools.FirstOrDefault(t => t.ConfigName.EqualsOrdinalIgnoreCase(localToolModeAttr.Name));
                    if (toolCandidate == null)
                    {
                        toolCandidate = new()
                        {
                            ConfigName = localToolModeAttr.Name,
                            CliName = "-" + localToolModeAttr.Name,
                            ConfigType = new(localToolModeAttr.Name + "Config", localToolModeAttr.Name + "Config"),
                        };
                        ProcessNewTool(toolCandidate);
                        ubtTool.Subtools.Add(toolCandidate);
                    }
                }
                if (contributeToGlobal)
                {
                    Log.Information("    Contributes to global");
                }

                foreach(var member in members)
                {
                    ProcessMember(member, targetToolModel);
                }
            }
            _model = model;
            return _model;
        }
    }
}