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
}