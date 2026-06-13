using System.Runtime.InteropServices;

namespace ToolBX.Mathemancy.Json;

public sealed class PolygonJsonConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(Polygon<>);

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options) =>
        NumberTypeDispatcher.Invoke(typeToConvert.GetGenericArguments()[0], new ConverterVisitor());

    private sealed class ConverterVisitor : INumberTypeVisitor<JsonConverter>
    {
        public JsonConverter Visit<TNumber>() where TNumber : struct, INumber<TNumber> => new PolygonJsonConverter<TNumber>();
    }
}

public class PolygonJsonConverter<T> : JsonConverter<Polygon<T>> where T : struct, INumber<T>
{
    public override Polygon<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var vertices = (List<Vector2<T>>?)JsonSerializer.Deserialize(ref reader, options.GetTypeInfo(typeof(List<Vector2<T>>)));
        if (vertices == null || vertices.Count < 3)
            throw new JsonException(Exceptions.PolygonRequiresThreeVertices);

        return new Polygon<T>(CollectionsMarshal.AsSpan(vertices));
    }

    public override void Write(Utf8JsonWriter writer, Polygon<T> value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.ToList(), options.GetTypeInfo(typeof(List<Vector2<T>>)));
    }
}