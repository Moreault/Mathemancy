namespace ToolBX.Mathemancy;

public static class Mathematics
{
    /// <summary>
    /// Returns a value between <see cref="start"/> and <see cref="target"/> based on current <see cref="progress"/>.
    /// </summary>
    /// <param name="start"></param>
    /// <param name="target"></param>
    /// <param name="progress">Value between 0.0 and 1.0</param>
    public static float Interpolate(float start, float target, float progress) => start + (target - start) * Math.Clamp(progress, 0, 1);

    /// <summary>
    /// Returns a value between <see cref="start"/> and <see cref="target"/> based on current <see cref="progress"/>.
    /// </summary>
    /// <param name="start"></param>
    /// <param name="target"></param>
    /// <param name="progress">Value between 0.0 and 1.0</param>
    public static double Interpolate(double start, double target, double progress) => start + (target - start) * Math.Clamp(progress, 0, 1);

    /// <summary>
    /// Returns a value between <see cref="start"/> and <see cref="target"/> based on current <see cref="progress"/>.
    /// </summary>
    /// <param name="start"></param>
    /// <param name="target"></param>
    /// <param name="progress">Value between 0.0 and 1.0</param>
    public static decimal Interpolate(decimal start, decimal target, decimal progress) => start + (target - start) * Math.Clamp(progress, 0, 1);

    public static Vector2<float> Interpolate(Vector2<float> start, Vector2<float> target, float progress)
    {
        return new Vector2<float>(Interpolate(start.X, target.X, progress), Interpolate(start.Y, target.Y, progress));
    }

    public static Vector2<double> Interpolate(Vector2<double> start, Vector2<double> target, double progress)
    {
        return new Vector2<double>(Interpolate(start.X, target.X, progress), Interpolate(start.Y, target.Y, progress));
    }

    public static Vector2<decimal> Interpolate(Vector2<decimal> start, Vector2<decimal> target, decimal progress)
    {
        return new Vector2<decimal>(Interpolate(start.X, target.X, progress), Interpolate(start.Y, target.Y, progress));
    }

    //TODO Investigate whether or not this is actually needed anywhere
    public static Vector2<float> GetDelta(Vector2<float> startPosition, Vector2<float> targetPosition, float elapsedTime, float targetTime)
    {
        if (elapsedTime >= targetTime)
            return targetPosition;
        var progress = elapsedTime / targetTime;

        return Interpolate(startPosition, targetPosition, progress);
    }
}