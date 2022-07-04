namespace ToolBX.Mathemancy;

public static class Distance
{
    public static float Calculate(Vector2<float> a, Vector2<float> b)
    {
        var num1 = a.X - b.X;
        var num2 = a.Y - b.Y;
        return (float)Math.Sqrt(num1 * num1 + num2 * num2);
    }
}