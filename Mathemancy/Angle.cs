namespace ToolBX.Mathemancy;

public static class Angle
{
    public static float Calculate(Vector2<float> a, Vector2<float> b) => (float)Math.Atan2(b.Y - a.Y, b.X - a.X);
}