using System.Runtime.InteropServices;

namespace ToolBX.Mathemancy.Json;

public sealed class RectangleJsonConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(Rectangle<>);

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options) =>
        NumberTypeDispatcher.Invoke(typeToConvert.GetGenericArguments()[0], new ConverterVisitor());

    private sealed class ConverterVisitor : INumberTypeVisitor<JsonConverter>
    {
        public JsonConverter Visit<TNumber>() where TNumber : struct, INumber<TNumber> => new RectangleJsonConverter<TNumber>();
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

            // The element types are statically known here (Vector2<TNumber>, Size<TNumber>), so the
            // converters are used directly instead of reflection-based JsonSerializer.Deserialize,
            // keeping this trim- and native-AOT-safe.
            var position = ReadElement(new Vector2JsonConverter<TNumber>(), jsonObject.GetProperty(nameof(Rectangle<TNumber>.Position)), options);
            var size = ReadElement(new SizeJsonConverter<TNumber>(), jsonObject.GetProperty(nameof(Rectangle<TNumber>.Size)), options);
            return new Rectangle<TNumber>(position, size);
        }

        throw new JsonException($"Unexpected token type: {reader.TokenType}");
    }

    public override void Write(Utf8JsonWriter writer, Rectangle<TNumber> value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }

    private static T ReadElement<T>(JsonConverter<T> converter, JsonElement element, JsonSerializerOptions options)
    {
        var reader = new Utf8JsonReader(System.Text.Encoding.UTF8.GetBytes(element.GetRawText()));
        reader.Read();
        return converter.Read(ref reader, typeof(T), options)!;
    }
}