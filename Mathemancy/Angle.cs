namespace ToolBX.Mathemancy;

public static class Angle
{
    public static float Calculate(Vector2<float> a, Vector2<float> b) => (float)Math.Atan2(b.Y - a.Y, b.X - a.X);

    public static Vector2<float> ToVector(float angle) => new((float)Math.Sin(angle), -(float)Math.Cos(angle));

    public static Vector2<double> ToVector(double angle) => new(Math.Sin(angle), -Math.Cos(angle));

    public static float FromVector(Vector2<float> value) => (float)Math.Atan2(value.X, -value.Y);

    public static double FromVector(Vector2<double> value) => Math.Atan2(value.X, -value.Y);
}