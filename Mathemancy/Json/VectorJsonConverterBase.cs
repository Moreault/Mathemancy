namespace ToolBX.Mathemancy.Json;

public abstract class VectorJsonConverterBase<TVector, TNumber> : JsonConverter<TVector> where TNumber : struct, INumber<TNumber>
{
    public abstract TVector FromString(string value);

    public abstract TVector FromValues(TNumber x, TNumber y, TNumber z);

    public override TVector Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var value = reader.GetString();
            if (value is null) throw new ArgumentNullException(nameof(value));
            return FromString(value);
        }

        if (reader.TokenType == JsonTokenType.StartObject)
        {
            var jsonObject = JsonDocument.ParseValue(ref reader).RootElement;

            var x = jsonObject.GetProperty(nameof(Vector3<TNumber>.X)).GetRawText();
            var y = jsonObject.GetProperty(nameof(Vector3<TNumber>.Y)).GetRawText();
            var hasZ = jsonObject.TryGetProperty(nameof(Vector3<TNumber>.Z), out var z);

            return FromValues(TNumber.Parse(x, null), TNumber.Parse(y, null), hasZ ? TNumber.Parse(z.GetRawText(), null) : default);
        }

        throw new JsonException($"Unexpected token type: {reader.TokenType}");
    }

    public override void Write(Utf8JsonWriter writer, TVector value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }

}