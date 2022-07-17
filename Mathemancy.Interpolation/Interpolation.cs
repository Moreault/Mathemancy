namespace Mathemancy.Interpolation;

public static class Interpolation
{
    /// <summary>
    /// Returns a value between <see cref="start"/> and <see cref="target"/> based on current <see cref="progress"/>.
    /// </summary>
    /// <param name="start"></param>
    /// <param name="target"></param>
    /// <param name="progress">Value between 0.0 and 1.0</param>
    public static float Calculate(float start, float target, float progress) => start + (target - start) * Math.Clamp(progress, 0, 1);

    /// <summary>
    /// Returns a value between <see cref="start"/> and <see cref="target"/> based on current <see cref="progress"/>.
    /// </summary>
    /// <param name="start"></param>
    /// <param name="target"></param>
    /// <param name="progress">Value between 0.0 and 1.0</param>
    public static double Calculate(double start, double target, double progress) => start + (target - start) * Math.Clamp(progress, 0, 1);

    /// <summary>
    /// Returns a value between <see cref="start"/> and <see cref="target"/> based on current <see cref="progress"/>.
    /// </summary>
    /// <param name="start"></param>
    /// <param name="target"></param>
    /// <param name="progress">Value between 0.0 and 1.0</param>
    public static decimal Calculate(decimal start, decimal target, decimal progress) => start + (target - start) * Math.Clamp(progress, 0, 1);
}