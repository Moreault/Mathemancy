namespace ToolBX.Mathemancy.Json;

public sealed class RectangleJsonConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(Rectangle<>);

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var elementType = typeToConvert.GetGenericArguments()[0];
        var converterType = typeof(RectangleJsonConverter<>).MakeGenericType(elementType);
        return (JsonConverter?)Activator.CreateInstance(converterType);
    }
}

public sealed class RectangleJsonConverter<TNumber> : JsonConverter<Rectangle<TNumber>> where TNumber : struct, INumber<TNumber>
{
    public override Rectangle<TNumber> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var value = reader.GetString();
            if (value is null) throw new ArgumentNullException(nameof(value));
            return Rectangle<TNumber>.FromString(value);
        }

        if (reader.TokenType == JsonTokenType.StartObject)
        {
            var jsonObject = JsonDocument.ParseValue(ref reader).RootElement;

            var position = JsonSerializer.Deserialize<Vector2<TNumber>>(jsonObject.GetProperty(nameof(Rectangle<TNumber>.Position)).GetRawText(), options);
            var size = JsonSerializer.Deserialize<Size<TNumber>>(jsonObject.GetProperty(nameof(Rectangle<TNumber>.Size)).GetRawText(), options);
            return new Rectangle<TNumber>(position, size);
        }

        throw new JsonException($"Unexpected token type: {reader.TokenType}");
    }

    public override void Write(Utf8JsonWriter writer, Rectangle<TNumber> value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}