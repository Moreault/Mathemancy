namespace ToolBX.Mathemancy;

public enum Direction
{
    None,
    Up,
    Right,
    Down,
    Left,
    UpLeft,
    UpRight,
    DownLeft,
    DownRight,
    Forward,
    Backwards,
    Random,
    Horizontal,
    Vertical
}

public static class DirectionExtensions
{
    public static Direction GetOpposite(this Direction value)
    {
        return value switch
        {
            Direction.Up => Direction.Down,
            Direction.Down => Direction.Up,
            Direction.Left => Direction.Right,
            Direction.Right => Direction.Left,
            Direction.Backwards => Direction.Forward,
            Direction.Forward => Direction.Backwards,
            Direction.DownLeft => Direction.UpRight,
            Direction.UpRight => Direction.DownLeft,
            Direction.DownRight => Direction.UpLeft,
            Direction.UpLeft => Direction.DownRight,
            Direction.Horizontal => Direction.Vertical,
            Direction.Vertical => Direction.Horizontal,
            _ => throw new ArgumentOutOfRangeException(nameof(value))
        };
    }

    public static Vector2<float> ToVector2(this Direction value)
    {
        switch (value)
        {
            case Direction.Up:
                return new Vector2<float>(0, -1);
            case Direction.Right:
                return new Vector2<float>(1, 0);
            case Direction.Down:
                return new Vector2<float>(0, 1);
            case Direction.Left:
                return new Vector2<float>(-1, 0);
            case Direction.UpLeft:
                return new Vector2<float>(-1, -1);
            case Direction.UpRight:
                return new Vector2<float>(1, -1);
            case Direction.DownLeft:
                return new Vector2<float>(-1, 1);
            case Direction.DownRight:
                return new Vector2<float>(1, 1);
            default:
                throw new ArgumentOutOfRangeException(nameof(value), value, null);
        }
    }
}