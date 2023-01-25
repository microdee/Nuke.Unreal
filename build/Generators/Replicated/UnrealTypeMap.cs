using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;

namespace build.Generators.Replicated;

public class UnrealTypeMap<T>
{
    public string Namespace { init; get; }
    public Assembly UeAssembly { init; get; }

    public string TypeName => $"${Namespace}.${typeof(T).Name}";

    private Type _ueType;
    public Type UeType => _ueType ??= UeAssembly.GetType(TypeName);

    private IMapper _mapper;
    public IMapper Map => _mapper ??= new Mapper(new MapperConfiguration(c =>
    {
        c.CreateMap(UeType, typeof(T));
        c.CreateMap(typeof(T), UeType);
    }));

    public T FromUnreal(object input) => Map.Map<T>(input);

    public object ToUnreal(T input) => Map.Map(input, typeof(T), UeType);
}