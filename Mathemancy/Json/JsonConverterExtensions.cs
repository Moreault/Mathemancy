namespace ToolBX.Mathemancy.Json;

public static class JsonConverterExtensions
{
    private static readonly Lazy<IReadOnlyList<JsonConverter>> All = new(() => ImmutableList.Create<JsonConverter>(new Vector2JsonConverterFactory(), new Vector3JsonConverterFactory()));

    /// <summary>
    /// Returns a <see cref="JsonSerializerOptions"/> loaded with all <see cref="JsonConverter"/>s from Mathemancy.
    /// </summary>
    public static JsonSerializerOptions WithMathemancyConverters(this JsonSerializerOptions options)
    {
        foreach (var converter in All.Value)
            options.Converters.Add(converter);
        return options;
    }

    //TODO Move to anoahter libary
    public static JsonSerializerOptions Without(this JsonSerializerOptions options, JsonConverter converter)
    {
        var copy = JsonSerializer.Deserialize<JsonSerializerOptions>(JsonSerializer.Serialize(options))!;
        var index = -1;
        for (var i = 0; i < copy.Converters.Count; i++)
        {
            if (copy.Converters[i].GetType() != converter.GetType()) continue;
            index = i;
            break;
        }
        copy.Converters.RemoveAt(index);
        return copy;
    }
}