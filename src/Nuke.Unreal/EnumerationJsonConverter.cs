using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Tooling;

namespace Nuke.Unreal;

public class EnumerationJsonConverter<T> : JsonConverter where T : Enumeration
{
    public override bool CanConvert(Type objectType)
    {
        return objectType.IsClass && objectType.IsAssignableTo(typeof(Enumeration));
    }

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        if (reader.Value is string value)
        {
            try
            {
                var result = TypeDescriptor.GetConverter(typeof(T)).ConvertFrom(value!);
                Assert.NotNull(result, $"'{value}' is not a valid {typeof(T).Name}");
                return result;
            }
            catch (Exception e)
            {
                throw new AggregateException($"'{value}' is not a valid {typeof(T).Name}", e);
            }
        }
        Assert.True(reader.TokenType == JsonToken.None
            || reader.TokenType == JsonToken.Null
            || reader.TokenType == JsonToken.Undefined,
            $"JSON value was neither a string, nor one of the 'not-existing' types. Token type: {reader.TokenType}; Object type: {objectType.Name};"
        );
        return null;
    }

    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        writer.WriteValue(value?.ToString());
    }
}