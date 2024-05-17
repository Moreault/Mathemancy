namespace ToolBX.Mathemancy.Interpolation;

public static class Interpolator
{
    /// <summary>
    /// Returns a value between <see cref="start"/> and <see cref="target"/> based on current <see cref="progress"/>.
    /// </summary>
    /// <param name="start"></param>
    /// <param name="target"></param>
    /// <param name="progress">Value between 0.0 and 1.0</param>
    public static T Calculate<T>(T start, T target, T progress) where T : IFloatingPoint<T> => start + (target - start) * T.Clamp(progress, T.Zero, T.One);
}