namespace ToolBX.Mathemancy.Json;

public sealed class SizeJsonConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(Size<>);

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var elementType = typeToConvert.GetGenericArguments()[0];
        var converterType = typeof(SizeJsonConverter<>).MakeGenericType(elementType);
        return (JsonConverter?)Activator.CreateInstance(converterType);
    }
}

public sealed class SizeJsonConverter<TNumber> : JsonConverter<Size<TNumber>> where TNumber : struct, INumber<TNumber>
{
    public override Size<TNumber> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var value = reader.GetString();
            if (value is null) throw new ArgumentNullException(nameof(value));
            return Size<TNumber>.FromString(value);
        }

        if (reader.TokenType == JsonTokenType.StartObject)
        {
            var jsonObject = JsonDocument.ParseValue(ref reader).RootElement;

            var width = jsonObject.GetProperty(nameof(Size<TNumber>.Width)).GetRawText();
            var height = jsonObject.GetProperty(nameof(Size<TNumber>.Height)).GetRawText();
            return new Size<TNumber>(TNumber.Parse(width, null), TNumber.Parse(height, null));
        }

        throw new JsonException($"Unexpected token type: {reader.TokenType}");
    }

    public override void Write(Utf8JsonWriter writer, Size<TNumber> value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}