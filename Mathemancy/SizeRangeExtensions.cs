namespace ToolBX.Mathemancy;

public static class SizeRangeExtensions
{
    public static bool IsNegative(this SizeRange<sbyte> range) => range.Minimum.IsNegative() || range.Maximum.IsNegative();
    public static bool IsNegative(this SizeRange<short> range) => range.Minimum.IsNegative() || range.Maximum.IsNegative();
    public static bool IsNegative(this SizeRange<int> range) => range.Minimum.IsNegative() || range.Maximum.IsNegative();
    public static bool IsNegative(this SizeRange<long> range) => range.Minimum.IsNegative() || range.Maximum.IsNegative();
    public static bool IsNegative(this SizeRange<float> range) => range.Minimum.IsNegative() || range.Maximum.IsNegative();
    public static bool IsNegative(this SizeRange<double> range) => range.Minimum.IsNegative() || range.Maximum.IsNegative();
    public static bool IsNegative(this SizeRange<decimal> range) => range.Minimum.IsNegative() || range.Maximum.IsNegative();
}