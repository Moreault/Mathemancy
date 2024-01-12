namespace ToolBX.Mathemancy.Json;

public sealed class Vector2JsonConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(Vector2<>);

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var elementType = typeToConvert.GetGenericArguments()[0];
        var converterType = typeof(Vector2JsonConverter<>).MakeGenericType(elementType);
        return (JsonConverter?)Activator.CreateInstance(converterType);
    }
}

public sealed class Vector2JsonConverter<T> : VectorJsonConverterBase<Vector2<T>, T> where T : struct, INumber<T>
{
    public override Vector2<T> FromString(string value) => Vector2<T>.FromString(value);

    public override Vector2<T> FromValues(T x, T y, T z) => new(x, y);
}