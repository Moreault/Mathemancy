namespace ToolBX.Mathemancy;

public static class NumberExtensions
{
    public static sbyte ToSByteOrClamp(this byte value) => value > sbyte.MaxValue ? sbyte.MaxValue : (sbyte)value;

    public static sbyte ToSByteOrClamp(this short value)
    {
        return value switch
        {
            < sbyte.MinValue => sbyte.MinValue,
            > sbyte.MaxValue => sbyte.MaxValue,
            _ => (sbyte)value
        };
    }

    public static sbyte ToSByteOrClamp(this ushort value) => value > sbyte.MaxValue ? sbyte.MaxValue : (sbyte)value;

    public static sbyte ToSByteOrClamp(this int value)
    {
        return value switch
        {
            < sbyte.MinValue => sbyte.MinValue,
            > sbyte.MaxValue => sbyte.MaxValue,
            _ => (sbyte)value
        };
    }

    public static sbyte ToSByteOrClamp(this uint value) => value > sbyte.MaxValue ? sbyte.MaxValue : (sbyte)value;

    public static sbyte ToSByteOrClamp(this long value)
    {
        return value switch
        {
            < sbyte.MinValue => sbyte.MinValue,
            > sbyte.MaxValue => sbyte.MaxValue,
            _ => (sbyte)value
        };
    }

    public static sbyte ToSByteOrClamp(this ulong value) => value > (ulong)sbyte.MaxValue ? sbyte.MaxValue : (sbyte)value;

    public static sbyte ToSByteOrClamp(this float value)
    {
        return value switch
        {
            < sbyte.MinValue => sbyte.MinValue,
            > sbyte.MaxValue => sbyte.MaxValue,
            _ => (sbyte)value
        };
    }

    public static sbyte ToSByteOrClamp(this double value)
    {
        return value switch
        {
            < sbyte.MinValue => sbyte.MinValue,
            > sbyte.MaxValue => sbyte.MaxValue,
            _ => (sbyte)value
        };
    }

    public static sbyte ToSByteOrClamp(this decimal value)
    {
        return value switch
        {
            < sbyte.MinValue => sbyte.MinValue,
            > sbyte.MaxValue => sbyte.MaxValue,
            _ => (sbyte)value
        };
    }

    public static byte ToByteOrClamp(this sbyte value) => value < byte.MinValue ? byte.MinValue : (byte)value;

    public static byte ToByteOrClamp(this short value)
    {
        return value switch
        {
            < byte.MinValue => byte.MinValue,
            > byte.MaxValue => byte.MaxValue,
            _ => (byte)value
        };
    }

    public static byte ToByteOrClamp(this ushort value) => value > byte.MaxValue ? byte.MaxValue : (byte)value;

    public static byte ToByteOrClamp(this int value)
    {
        return value switch
        {
            < byte.MinValue => byte.MinValue,
            > byte.MaxValue => byte.MaxValue,
            _ => (byte)value
        };
    }

    public static byte ToByteOrClamp(this uint value) => value > byte.MaxValue ? byte.MaxValue : (byte)value;

    public static byte ToByteOrClamp(this long value)
    {
        return value switch
        {
            < byte.MinValue => byte.MinValue,
            > byte.MaxValue => byte.MaxValue,
            _ => (byte)value
        };
    }

    public static byte ToByteOrClamp(this ulong value) => value > byte.MaxValue ? byte.MaxValue : (byte)value;

    public static byte ToByteOrClamp(this float value)
    {
        return value switch
        {
            < byte.MinValue => byte.MinValue,
            > byte.MaxValue => byte.MaxValue,
            _ => (byte)value
        };
    }

    public static byte ToByteOrClamp(this double value)
    {
        return value switch
        {
            < byte.MinValue => byte.MinValue,
            > byte.MaxValue => byte.MaxValue,
            _ => (byte)value
        };
    }

    public static byte ToByteOrClamp(this decimal value)
    {
        return value switch
        {
            < byte.MinValue => byte.MinValue,
            > byte.MaxValue => byte.MaxValue,
            _ => (byte)value
        };
    }

    public static short ToShortOrClamp(this ushort value)
    {
        if (value > short.MaxValue) return short.MaxValue;
        return (short)value;
    }

    public static short ToShortOrClamp(this int value)
    {
        return value switch
        {
            < short.MinValue => short.MinValue,
            > short.MaxValue => short.MaxValue,
            _ => (short)value
        };
    }

    public static short ToShortOrClamp(this uint value) => value > short.MaxValue ? short.MaxValue : (short)value;

    public static short ToShortOrClamp(this long value)
    {
        return value switch
        {
            < short.MinValue => short.MinValue,
            > short.MaxValue => short.MaxValue,
            _ => (short)value
        };
    }

    public static short ToShortOrClamp(this ulong value) => value > (ulong)short.MaxValue ? short.MaxValue : (short)value;

    public static short ToShortOrClamp(this float value)
    {
        return value switch
        {
            < short.MinValue => short.MinValue,
            > short.MaxValue => short.MaxValue,
            _ => (short)value
        };
    }

    public static short ToShortOrClamp(this double value)
    {
        return value switch
        {
            < short.MinValue => short.MinValue,
            > short.MaxValue => short.MaxValue,
            _ => (short)value
        };
    }

    public static short ToShortOrClamp(this decimal value)
    {
        return value switch
        {
            < short.MinValue => short.MinValue,
            > short.MaxValue => short.MaxValue,
            _ => (short)value
        };
    }

    public static ushort ToUShortOrClamp(this sbyte value) => value < ushort.MinValue ? ushort.MinValue : (ushort)value;
    public static ushort ToUShortOrClamp(this short value) => value < ushort.MinValue ? ushort.MinValue : (ushort)value;
    public static ushort ToUShortOrClamp(this int value)
    {
        return value switch
        {
            < ushort.MinValue => ushort.MinValue,
            > ushort.MaxValue => ushort.MaxValue,
            _ => (ushort)value
        };
    }

    public static ushort ToUShortOrClamp(this uint value) => value > ushort.MaxValue ? ushort.MaxValue : (ushort)value;

    public static ushort ToUShortOrClamp(this long value)
    {
        return value switch
        {
            < ushort.MinValue => ushort.MinValue,
            > ushort.MaxValue => ushort.MaxValue,
            _ => (ushort)value
        };
    }

    public static ushort ToUShortOrClamp(this ulong value) => value > ushort.MaxValue ? ushort.MaxValue : (ushort)value;

    public static ushort ToUShortOrClamp(this float value)
    {
        return value switch
        {
            < ushort.MinValue => ushort.MinValue,
            > ushort.MaxValue => ushort.MaxValue,
            _ => (ushort)value
        };
    }

    public static ushort ToUShortOrClamp(this double value) => value > ushort.MaxValue ? ushort.MaxValue : (ushort)value;

    public static ushort ToUShortOrClamp(this decimal value)
    {
        return value switch
        {
            < ushort.MinValue => ushort.MinValue,
            > ushort.MaxValue => ushort.MaxValue,
            _ => (ushort)value
        };
    }

    public static int ToIntOrClamp(this uint value) => value > int.MaxValue ? int.MaxValue : (int)value;

    public static int ToIntOrClamp(this long value)
    {
        return value switch
        {
            < int.MinValue => int.MinValue,
            > int.MaxValue => int.MaxValue,
            _ => (int)value
        };
    }

    public static int ToIntOrClamp(this ulong value) => value > int.MaxValue ? int.MaxValue : (int)value;

    public static int ToIntOrClamp(this float value)
    {
        return value switch
        {
            < int.MinValue => int.MinValue,
            > int.MaxValue => int.MaxValue,
            _ => (int)value
        };
    }

    public static int ToIntOrClamp(this double value)
    {
        return value switch
        {
            < int.MinValue => int.MinValue,
            > int.MaxValue => int.MaxValue,
            _ => (int)value
        };
    }

    public static int ToIntOrClamp(this decimal value)
    {
        return value switch
        {
            < int.MinValue => int.MinValue,
            > int.MaxValue => int.MaxValue,
            _ => (int)value
        };
    }

    public static uint ToUIntOrClamp(this sbyte value) => value < uint.MinValue ? uint.MinValue : (uint)value;
    public static uint ToUIntOrClamp(this short value) => value < uint.MinValue ? uint.MinValue : (uint)value;
    public static uint ToUIntOrClamp(this int value) => value < uint.MinValue ? uint.MinValue : (uint)value;
    public static uint ToUIntOrClamp(this long value) => value < uint.MinValue ? uint.MinValue : (uint)value;
    public static uint ToUIntOrClamp(this ulong value) => value > uint.MaxValue ? uint.MaxValue : (uint)value;
    public static uint ToUIntOrClamp(this float value) => value > uint.MaxValue ? uint.MaxValue : (uint)value;
    public static uint ToUIntOrClamp(this double value) => value > uint.MaxValue ? uint.MaxValue : (uint)value;
    public static uint ToUIntOrClamp(this decimal value) => value > uint.MaxValue ? uint.MaxValue : (uint)value;
    public static long ToLongOrClamp(this ulong value) => value > long.MaxValue ? long.MaxValue : (long)value;

    public static long ToLongOrClamp(this float value)
    {
        return value switch
        {
            < long.MinValue => long.MinValue,
            > long.MaxValue => long.MaxValue,
            _ => (long)value
        };
    }

    public static long ToLongOrClamp(this double value)
    {
        return value switch
        {
            < long.MinValue => long.MinValue,
            > long.MaxValue => long.MaxValue,
            _ => (long)value
        };
    }

    public static long ToLongOrClamp(this decimal value)
    {
        return value switch
        {
            < long.MinValue => long.MinValue,
            > long.MaxValue => long.MaxValue,
            _ => (long)value
        };
    }

    public static ulong ToULongOrClamp(this sbyte value) => value < (sbyte)ulong.MinValue ? ulong.MinValue : (ulong)value;
    public static ulong ToULongOrClamp(this short value) => value < (short)ulong.MinValue ? ulong.MinValue : (ulong)value;
    public static ulong ToULongOrClamp(this int value) => value < (int)ulong.MinValue ? ulong.MinValue : (ulong)value;
    public static ulong ToULongOrClamp(this long value) => value < (long)ulong.MinValue ? ulong.MinValue : (ulong)value;

    public static ulong ToULongOrClamp(this float value)
    {
        return value switch
        {
            < ulong.MinValue => ulong.MinValue,
            > ulong.MaxValue => ulong.MaxValue,
            _ => (ulong)value
        };
    }

    public static ulong ToULongOrClamp(this double value)
    {
        return value switch
        {
            < ulong.MinValue => ulong.MinValue,
            > ulong.MaxValue => ulong.MaxValue,
            _ => (ulong)value
        };
    }

    public static ulong ToULongOrClamp(this decimal value)
    {
        return value switch
        {
            < ulong.MinValue => ulong.MinValue,
            > ulong.MaxValue => ulong.MaxValue,
            _ => (ulong)value
        };
    }

    public static float ToFloatOrClamp(this double value)
    {
        return value switch
        {
            < float.MinValue => float.MinValue,
            > float.MaxValue => float.MaxValue,
            _ => (float)value
        };
    }

    public static float ToFloatOrClamp(this decimal value)
    {
        if (value < Convert.ToDecimal(float.MinValue)) return float.MinValue;
        if (value > Convert.ToDecimal(float.MaxValue)) return float.MaxValue;
        return (float)value;
    }

    public static double ToDoubleOrClamp(this decimal value)
    {
        if (value < Convert.ToDecimal(double.MinValue)) return double.MinValue;
        if (value > Convert.ToDecimal(double.MaxValue)) return double.MaxValue;
        return (double)value;
    }

    public static sbyte ToSByteOrDefault(this byte value, sbyte defaultValue = default) => value > sbyte.MaxValue ? defaultValue : (sbyte)value;

    public static sbyte ToSByteOrDefault(this short value, sbyte defaultValue = default)
    {
        return value switch
        {
            < sbyte.MinValue => defaultValue,
            > sbyte.MaxValue => defaultValue,
            _ => (sbyte)value
        };
    }

    public static sbyte ToSByteOrDefault(this ushort value, sbyte defaultValue = default) => value > sbyte.MaxValue ? defaultValue : (sbyte)value;

    public static sbyte ToSByteOrDefault(this int value, sbyte defaultValue = default)
    {
        return value switch
        {
            < sbyte.MinValue => defaultValue,
            > sbyte.MaxValue => defaultValue,
            _ => (sbyte)value
        };
    }

    public static sbyte ToSByteOrDefault(this uint value, sbyte defaultValue = default) => value > sbyte.MaxValue ? defaultValue : (sbyte)value;

    public static sbyte ToSByteOrDefault(this long value, sbyte defaultValue = default)
    {
        return value switch
        {
            < sbyte.MinValue => defaultValue,
            > sbyte.MaxValue => defaultValue,
            _ => (sbyte)value
        };
    }

    public static sbyte ToSByteOrDefault(this ulong value, sbyte defaultValue = default) => value > (ulong)sbyte.MaxValue ? defaultValue : (sbyte)value;

    public static sbyte ToSByteOrDefault(this float value, sbyte defaultValue = default)
    {
        return value switch
        {
            < sbyte.MinValue => defaultValue,
            > sbyte.MaxValue => defaultValue,
            _ => (sbyte)value
        };
    }

    public static sbyte ToSByteOrDefault(this double value, sbyte defaultValue = default)
    {
        return value switch
        {
            < sbyte.MinValue => defaultValue,
            > sbyte.MaxValue => defaultValue,
            _ => (sbyte)value
        };
    }

    public static sbyte ToSByteOrDefault(this decimal value, sbyte defaultValue = default)
    {
        return value switch
        {
            < sbyte.MinValue => defaultValue,
            > sbyte.MaxValue => defaultValue,
            _ => (sbyte)value
        };
    }

    public static byte ToByteOrDefault(this sbyte value, byte defaultValue = default) => value < byte.MinValue ? defaultValue : (byte)value;

    public static byte ToByteOrDefault(this short value, byte defaultValue = default)
    {
        return value switch
        {
            < byte.MinValue => defaultValue,
            > byte.MaxValue => defaultValue,
            _ => (byte)value
        };
    }

    public static byte ToByteOrDefault(this ushort value, byte defaultValue = default) => value > byte.MaxValue ? defaultValue : (byte)value;

    public static byte ToByteOrDefault(this int value, byte defaultValue = default)
    {
        return value switch
        {
            < byte.MinValue => defaultValue,
            > byte.MaxValue => defaultValue,
            _ => (byte)value
        };
    }

    public static byte ToByteOrDefault(this uint value, byte defaultValue = default) => value > byte.MaxValue ? byte.MaxValue : (byte)value;

    public static byte ToByteOrDefault(this long value, byte defaultValue = default)
    {
        return value switch
        {
            < byte.MinValue => defaultValue,
            > byte.MaxValue => defaultValue,
            _ => (byte)value
        };
    }

    public static byte ToByteOrDefault(this ulong value, byte defaultValue = default) => value > byte.MaxValue ? defaultValue : (byte)value;

    public static byte ToByteOrDefault(this float value, byte defaultValue = default)
    {
        return value switch
        {
            < byte.MinValue => defaultValue,
            > byte.MaxValue => defaultValue,
            _ => (byte)value
        };
    }

    public static byte ToByteOrDefault(this double value, byte defaultValue = default)
    {
        return value switch
        {
            < byte.MinValue => defaultValue,
            > byte.MaxValue => defaultValue,
            _ => (byte)value
        };
    }

    public static byte ToByteOrDefault(this decimal value, byte defaultValue = default)
    {
        return value switch
        {
            < byte.MinValue => defaultValue,
            > byte.MaxValue => defaultValue,
            _ => (byte)value
        };
    }

    public static short ToShortOrDefault(this ushort value, short defaultValue = default) => value > short.MaxValue ? defaultValue : (short)value;

    public static short ToShortOrDefault(this int value, short defaultValue = default)
    {
        return value switch
        {
            < short.MinValue => defaultValue,
            > short.MaxValue => defaultValue,
            _ => (short)value
        };
    }

    public static short ToShortOrDefault(this uint value, short defaultValue = default) => value > short.MaxValue ? short.MaxValue : (short)value;

    public static short ToShortOrDefault(this long value, short defaultValue = default)
    {
        return value switch
        {
            < short.MinValue => defaultValue,
            > short.MaxValue => defaultValue,
            _ => (short)value
        };
    }

    public static short ToShortOrDefault(this ulong value, short defaultValue = default) => value > (ulong)short.MaxValue ? defaultValue : (short)value;

    public static short ToShortOrDefault(this float value, short defaultValue = default)
    {
        return value switch
        {
            < short.MinValue => defaultValue,
            > short.MaxValue => defaultValue,
            _ => (short)value
        };
    }

    public static short ToShortOrDefault(this double value, short defaultValue = default)
    {
        return value switch
        {
            < short.MinValue => defaultValue,
            > short.MaxValue => defaultValue,
            _ => (short)value
        };
    }

    public static short ToShortOrDefault(this decimal value, short defaultValue = default)
    {
        return value switch
        {
            < short.MinValue => defaultValue,
            > short.MaxValue => defaultValue,
            _ => (short)value
        };
    }

    public static ushort ToUShortOrDefault(this sbyte value, ushort defaultValue = default) => value < ushort.MinValue ? defaultValue : (ushort)value;
    public static ushort ToUShortOrDefault(this short value, ushort defaultValue = default) => value < ushort.MinValue ? defaultValue : (ushort)value;

    public static ushort ToUShortOrDefault(this int value, ushort defaultValue = default)
    {
        return value switch
        {
            < ushort.MinValue => defaultValue,
            > ushort.MaxValue => defaultValue,
            _ => (ushort)value
        };
    }

    public static ushort ToUShortOrDefault(this uint value, ushort defaultValue = default) => value > ushort.MaxValue ? defaultValue : (ushort)value;

    public static ushort ToUShortOrDefault(this long value, ushort defaultValue = default)
    {
        return value switch
        {
            < ushort.MinValue => defaultValue,
            > ushort.MaxValue => defaultValue,
            _ => (ushort)value
        };
    }

    public static ushort ToUShortOrDefault(this ulong value, ushort defaultValue = default) => value > ushort.MaxValue ? defaultValue : (ushort)value;

    public static ushort ToUShortOrDefault(this float value, ushort defaultValue = default)
    {
        return value switch
        {
            < ushort.MinValue => defaultValue,
            > ushort.MaxValue => defaultValue,
            _ => (ushort)value
        };
    }

    public static ushort ToUShortOrDefault(this double value, ushort defaultValue = default) => value > ushort.MaxValue ? defaultValue : (ushort)value;

    public static ushort ToUShortOrDefault(this decimal value, ushort defaultValue = default)
    {
        return value switch
        {
            < ushort.MinValue => defaultValue,
            > ushort.MaxValue => defaultValue,
            _ => (ushort)value
        };
    }

    public static int ToIntOrDefault(this uint value, int defaultValue = default) => value > int.MaxValue ? defaultValue : (int)value;

    public static int ToIntOrDefault(this long value, int defaultValue = default)
    {
        return value switch
        {
            < int.MinValue => defaultValue,
            > int.MaxValue => defaultValue,
            _ => (int)value
        };
    }

    public static int ToIntOrDefault(this ulong value, int defaultValue = default) => value > int.MaxValue ? defaultValue : (int)value;

    public static int ToIntOrDefault(this float value, int defaultValue = default)
    {
        return value switch
        {
            < int.MinValue => defaultValue,
            > int.MaxValue => defaultValue,
            _ => (int)value
        };
    }

    public static int ToIntOrDefault(this double value, int defaultValue = default)
    {
        return value switch
        {
            < int.MinValue => defaultValue,
            > int.MaxValue => defaultValue,
            _ => (int)value
        };
    }

    public static int ToIntOrDefault(this decimal value, int defaultValue = default)
    {
        return value switch
        {
            < int.MinValue => defaultValue,
            > int.MaxValue => defaultValue,
            _ => (int)value
        };
    }

    public static uint ToUIntOrDefault(this sbyte value, uint defaultValue = default) => value < uint.MinValue ? defaultValue : (uint)value;
    public static uint ToUIntOrDefault(this short value, uint defaultValue = default) => value < uint.MinValue ? defaultValue : (uint)value;
    public static uint ToUIntOrDefault(this int value, uint defaultValue = default) => value < uint.MinValue ? defaultValue : (uint)value;
    public static uint ToUIntOrDefault(this long value, uint defaultValue = default) => value < uint.MinValue ? defaultValue : (uint)value;
    public static uint ToUIntOrDefault(this ulong value, uint defaultValue = default) => value > uint.MaxValue ? defaultValue : (uint)value;
    public static uint ToUIntOrDefault(this float value, uint defaultValue = default) => value > uint.MaxValue ? defaultValue : (uint)value;
    public static uint ToUIntOrDefault(this double value, uint defaultValue = default) => value > uint.MaxValue ? defaultValue : (uint)value;
    public static uint ToUIntOrDefault(this decimal value, uint defaultValue = default) => value > uint.MaxValue ? defaultValue : (uint)value;

    public static long ToLongOrDefault(this ulong value, long defaultValue = default) => value > long.MaxValue ? defaultValue : (long)value;
    public static long ToLongOrDefault(this float value, long defaultValue = default)
    {
        return value switch
        {
            < long.MinValue => defaultValue,
            > long.MaxValue => defaultValue,
            _ => (long)value
        };
    }

    public static long ToLongOrDefault(this double value, long defaultValue = default)
    {
        return value switch
        {
            < long.MinValue => defaultValue,
            > long.MaxValue => defaultValue,
            _ => (long)value
        };
    }

    public static long ToLongOrDefault(this decimal value, long defaultValue = default)
    {
        return value switch
        {
            < long.MinValue => defaultValue,
            > long.MaxValue => defaultValue,
            _ => (long)value
        };
    }

    public static ulong ToULongOrDefault(this sbyte value, ulong defaultValue = default) => value < (sbyte)ulong.MinValue ? defaultValue : (ulong)value;
    public static ulong ToULongOrDefault(this short value, ulong defaultValue = default) => value < (short)ulong.MinValue ? defaultValue : (ulong)value;
    public static ulong ToULongOrDefault(this int value, ulong defaultValue = default) => value < (int)ulong.MinValue ? defaultValue : (ulong)value;
    public static ulong ToULongOrDefault(this long value, ulong defaultValue = default) => value < (long)ulong.MinValue ? defaultValue : (ulong)value;
    public static ulong ToULongOrDefault(this float value, ulong defaultValue = default)
    {
        return value switch
        {
            < ulong.MinValue => defaultValue,
            > ulong.MaxValue => defaultValue,
            _ => (ulong)value
        };
    }

    public static ulong ToULongOrDefault(this double value, ulong defaultValue = default)
    {
        return value switch
        {
            < ulong.MinValue => defaultValue,
            > ulong.MaxValue => defaultValue,
            _ => (ulong)value
        };
    }

    public static ulong ToULongOrDefault(this decimal value, ulong defaultValue = default)
    {
        return value switch
        {
            < ulong.MinValue => defaultValue,
            > ulong.MaxValue => defaultValue,
            _ => (ulong)value
        };
    }

    public static float ToFloatOrDefault(this double value, float defaultValue = default)
    {
        return value switch
        {
            < float.MinValue => defaultValue,
            > float.MaxValue => defaultValue,
            _ => (float)value
        };
    }

    public static float ToFloatOrDefault(this decimal value, float defaultValue = default)
    {
        if (value < Convert.ToDecimal(float.MinValue)) return defaultValue;
        if (value > Convert.ToDecimal(float.MaxValue)) return defaultValue;
        return (float)value;
    }

    public static double ToDoubleOrDefault(this decimal value, double defaultValue = default)
    {
        if (value < Convert.ToDecimal(double.MinValue)) return defaultValue;
        if (value > Convert.ToDecimal(double.MaxValue)) return defaultValue;
        return (double)value;
    }

    public static decimal ToDecimal(this float value, decimal defaultValue = default) => Convert.ToDecimal(value);
    public static decimal ToDecimal(this double value, decimal defaultValue = default) => Convert.ToDecimal(value);

    public static T Clamp<T>(this T value, T min, T max) where T : INumber<T>
    {
        if (min > max) throw new ArgumentException(string.Format(Exceptions.MaximumValueMustBeGreaterThanMinimum, max, min));

        if (value < min)
            return min;

        if (value > max)
            return max;

        return value;
    }

    public static T? Clamp<T>(this T? value, T min, T max) where T : struct, INumber<T>
    {
        return value?.Clamp(min, max) ?? null;
    }
}