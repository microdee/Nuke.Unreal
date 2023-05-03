// Copyright Epic Games, Inc. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace build.Generators.Replicated.Tools.DotNETCommon;

/// <summary>
/// Attribute to indicate the name of a command line argument
/// </summary>
[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class CommandLineAttribute : Attribute
{
    public static UnrealTypeMap<CommandLineAttribute> Mapping(UnrealDotnetAssemblies assemblies) => new()
    {
        Namespace = "Tools.DotNETCommon",
        UeAssembly = assemblies.DotNETUtilities
    };
    
    /// <summary>
    /// Prefix for the option, with a leading '-' and trailing '=' character if a value is expected.
    /// </summary>
    public string Prefix;

    /// <summary>
    /// Specifies a fixed value for this argument. Specifying an alternate value is not permitted.
    /// </summary>
    public string Value = null;

    /// <summary>
    /// Description of the operation.
    /// </summary>
    public string Description;

    /// <summary>
    /// Whether this argument is required
    /// </summary>
    public bool Required;

    /// <summary>
    /// For collection types, specifies the separator character between multiple arguments
    /// </summary>
    public char ListSeparator = '\0';
}
