namespace ToolBX.Mathemancy.Collisions;

public record BoxCollider : ICollider
{
    public Vector3<int> Offset { get; init; }

    public Size<int> Size { get; init; }

    public BoxCollider(Size<int> size, Vector3<int> offset)
    {
        Offset = offset; Size = size;
        Offset = offset;
    }

    public BoxCollider(Size<int> size) : this(size, new Vector3<int>())
    {

    }

    public BoxCollider(int width, int height) : this(new Size<int>(width, height), new Vector3<int>())
    {

    }

    public BoxCollider(int width, int height, Vector3<int> offset) : this(new Size<int>(width, height), offset)
    {

    }

    public BoxCollider(int width, int height, int offsetX, int offsetY) : this(new Size<int>(width, height), new Vector3<int>(offsetX, offsetY))
    {

    }

    public override string ToString() => $"{nameof(BoxCollider)} Size {Size} Offset {Offset}";
}