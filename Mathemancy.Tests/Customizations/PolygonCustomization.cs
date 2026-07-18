namespace Mathemancy.Tests.Customizations;

[AutoCustomization]
public sealed class PolygonCustomization : OpenGenericCustomizationBase
{
    protected override IEnumerable<Type> Types { get; } = [typeof(Polygon<>)];

    protected override object FromFactory<T>(IDummy dummy)
    {
        var vectorType = typeof(Vector2<>).MakeGenericType(typeof(T));
        var listType = typeof(List<>).MakeGenericType(vectorType);
        var list = (IList)Activator.CreateInstance(listType)!;
        foreach (var item in dummy.CreateMany(vectorType))
        {
            list.Add(item);
        }

        return Activator.CreateInstance(typeof(Polygon<>).MakeGenericType(typeof(T)), list)!;
    }
}