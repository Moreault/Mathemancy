namespace ToolBX.Mathemancy;

public static class Vector2Extensions
{
    public static Vector2<sbyte> ToSByte(this Vector2<byte> value) => new((sbyte)value.X, (sbyte)value.Y);
    public static Vector2<sbyte> ToSByte(this Vector2<short> value) => new((sbyte)value.X, (sbyte)value.Y);
    public static Vector2<sbyte> ToSByte(this Vector2<ushort> value) => new((sbyte)value.X, (sbyte)value.Y);
    public static Vector2<sbyte> ToSByte(this Vector2<int> value) => new((sbyte)value.X, (sbyte)value.Y);
    public static Vector2<sbyte> ToSByte(this Vector2<uint> value) => new((sbyte)value.X, (sbyte)value.Y);
    public static Vector2<sbyte> ToSByte(this Vector2<long> value) => new((sbyte)value.X, (sbyte)value.Y);
    public static Vector2<sbyte> ToSByte(this Vector2<ulong> value) => new((sbyte)value.X, (sbyte)value.Y);
    public static Vector2<sbyte> ToSByte(this Vector2<float> value) => new((sbyte)value.X, (sbyte)value.Y);
    public static Vector2<sbyte> ToSByte(this Vector2<double> value) => new((sbyte)value.X, (sbyte)value.Y);
    public static Vector2<sbyte> ToSByte(this Vector2<decimal> value) => new((sbyte)value.X, (sbyte)value.Y);

    public static Vector2<sbyte> ToSByteOrClamp(this Vector2<byte> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp());
    public static Vector2<sbyte> ToSByteOrClamp(this Vector2<short> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp());
    public static Vector2<sbyte> ToSByteOrClamp(this Vector2<ushort> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp());
    public static Vector2<sbyte> ToSByteOrClamp(this Vector2<int> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp());
    public static Vector2<sbyte> ToSByteOrClamp(this Vector2<uint> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp());
    public static Vector2<sbyte> ToSByteOrClamp(this Vector2<long> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp());
    public static Vector2<sbyte> ToSByteOrClamp(this Vector2<ulong> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp());
    public static Vector2<sbyte> ToSByteOrClamp(this Vector2<float> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp());
    public static Vector2<sbyte> ToSByteOrClamp(this Vector2<double> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp());
    public static Vector2<sbyte> ToSByteOrClamp(this Vector2<decimal> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp());

    public static Vector2<sbyte> ToSByteOrDefault(this Vector2<byte> value, sbyte defaultValue = default) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue));
    public static Vector2<sbyte> ToSByteOrDefault(this Vector2<short> value, sbyte defaultValue = default) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue));
    public static Vector2<sbyte> ToSByteOrDefault(this Vector2<ushort> value, sbyte defaultValue = default) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue));
    public static Vector2<sbyte> ToSByteOrDefault(this Vector2<int> value, sbyte defaultValue = default) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue));
    public static Vector2<sbyte> ToSByteOrDefault(this Vector2<uint> value, sbyte defaultValue = default) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue));
    public static Vector2<sbyte> ToSByteOrDefault(this Vector2<long> value, sbyte defaultValue = default) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue));
    public static Vector2<sbyte> ToSByteOrDefault(this Vector2<ulong> value, sbyte defaultValue = default) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue));
    public static Vector2<sbyte> ToSByteOrDefault(this Vector2<float> value, sbyte defaultValue = default) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue));
    public static Vector2<sbyte> ToSByteOrDefault(this Vector2<double> value, sbyte defaultValue = default) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue));
    public static Vector2<sbyte> ToSByteOrDefault(this Vector2<decimal> value, sbyte defaultValue = default) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue));

    public static Vector2<byte> ToByte(this Vector2<sbyte> value) => new((byte)value.X, (byte)value.Y);
    public static Vector2<byte> ToByte(this Vector2<short> value) => new((byte)value.X, (byte)value.Y);
    public static Vector2<byte> ToByte(this Vector2<ushort> value) => new((byte)value.X, (byte)value.Y);
    public static Vector2<byte> ToByte(this Vector2<int> value) => new((byte)value.X, (byte)value.Y);
    public static Vector2<byte> ToByte(this Vector2<uint> value) => new((byte)value.X, (byte)value.Y);
    public static Vector2<byte> ToByte(this Vector2<long> value) => new((byte)value.X, (byte)value.Y);
    public static Vector2<byte> ToByte(this Vector2<ulong> value) => new((byte)value.X, (byte)value.Y);
    public static Vector2<byte> ToByte(this Vector2<float> value) => new((byte)value.X, (byte)value.Y);
    public static Vector2<byte> ToByte(this Vector2<double> value) => new((byte)value.X, (byte)value.Y);
    public static Vector2<byte> ToByte(this Vector2<decimal> value) => new((byte)value.X, (byte)value.Y);

    public static Vector2<byte> ToByteOrClamp(this Vector2<sbyte> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp());
    public static Vector2<byte> ToByteOrClamp(this Vector2<short> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp());
    public static Vector2<byte> ToByteOrClamp(this Vector2<ushort> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp());
    public static Vector2<byte> ToByteOrClamp(this Vector2<int> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp());
    public static Vector2<byte> ToByteOrClamp(this Vector2<uint> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp());
    public static Vector2<byte> ToByteOrClamp(this Vector2<long> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp());
    public static Vector2<byte> ToByteOrClamp(this Vector2<ulong> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp());
    public static Vector2<byte> ToByteOrClamp(this Vector2<float> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp());
    public static Vector2<byte> ToByteOrClamp(this Vector2<double> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp());
    public static Vector2<byte> ToByteOrClamp(this Vector2<decimal> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp());

    public static Vector2<byte> ToByteOrDefault(this Vector2<sbyte> value, byte defaultValue = default) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue));
    public static Vector2<byte> ToByteOrDefault(this Vector2<short> value, byte defaultValue = default) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue));
    public static Vector2<byte> ToByteOrDefault(this Vector2<ushort> value, byte defaultValue = default) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue));
    public static Vector2<byte> ToByteOrDefault(this Vector2<int> value, byte defaultValue = default) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue));
    public static Vector2<byte> ToByteOrDefault(this Vector2<uint> value, byte defaultValue = default) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue));
    public static Vector2<byte> ToByteOrDefault(this Vector2<long> value, byte defaultValue = default) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue));
    public static Vector2<byte> ToByteOrDefault(this Vector2<ulong> value, byte defaultValue = default) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue));
    public static Vector2<byte> ToByteOrDefault(this Vector2<float> value, byte defaultValue = default) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue));
    public static Vector2<byte> ToByteOrDefault(this Vector2<double> value, byte defaultValue = default) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue));
    public static Vector2<byte> ToByteOrDefault(this Vector2<decimal> value, byte defaultValue = default) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue));

    public static Vector2<short> ToShort(this Vector2<sbyte> value) => new(value.X, value.Y);
    public static Vector2<short> ToShort(this Vector2<byte> value) => new(value.X, value.Y);
    public static Vector2<short> ToShort(this Vector2<ushort> value) => new((short)value.X, (short)value.Y);
    public static Vector2<short> ToShort(this Vector2<int> value) => new((short)value.X, (short)value.Y);
    public static Vector2<short> ToShort(this Vector2<uint> value) => new((short)value.X, (short)value.Y);
    public static Vector2<short> ToShort(this Vector2<long> value) => new((short)value.X, (short)value.Y);
    public static Vector2<short> ToShort(this Vector2<ulong> value) => new((short)value.X, (short)value.Y);
    public static Vector2<short> ToShort(this Vector2<float> value) => new((short)value.X, (short)value.Y);
    public static Vector2<short> ToShort(this Vector2<double> value) => new((short)value.X, (short)value.Y);
    public static Vector2<short> ToShort(this Vector2<decimal> value) => new((short)value.X, (short)value.Y);

    public static Vector2<short> ToShortOrClamp(this Vector2<ushort> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp());
    public static Vector2<short> ToShortOrClamp(this Vector2<int> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp());
    public static Vector2<short> ToShortOrClamp(this Vector2<uint> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp());
    public static Vector2<short> ToShortOrClamp(this Vector2<long> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp());
    public static Vector2<short> ToShortOrClamp(this Vector2<ulong> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp());
    public static Vector2<short> ToShortOrClamp(this Vector2<float> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp());
    public static Vector2<short> ToShortOrClamp(this Vector2<double> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp());
    public static Vector2<short> ToShortOrClamp(this Vector2<decimal> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp());

    public static Vector2<short> ToShortOrDefault(this Vector2<ushort> value, short defaultValue = default) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue));
    public static Vector2<short> ToShortOrDefault(this Vector2<int> value, short defaultValue = default) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue));
    public static Vector2<short> ToShortOrDefault(this Vector2<uint> value, short defaultValue = default) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue));
    public static Vector2<short> ToShortOrDefault(this Vector2<long> value, short defaultValue = default) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue));
    public static Vector2<short> ToShortOrDefault(this Vector2<ulong> value, short defaultValue = default) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue));
    public static Vector2<short> ToShortOrDefault(this Vector2<float> value, short defaultValue = default) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue));
    public static Vector2<short> ToShortOrDefault(this Vector2<double> value, short defaultValue = default) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue));
    public static Vector2<short> ToShortOrDefault(this Vector2<decimal> value, short defaultValue = default) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue));

    public static Vector2<ushort> ToUShort(this Vector2<sbyte> value) => new((ushort)value.X, (ushort)value.Y);
    public static Vector2<ushort> ToUShort(this Vector2<byte> value) => new(value.X, value.Y);
    public static Vector2<ushort> ToUShort(this Vector2<short> value) => new((ushort)value.X, (ushort)value.Y);
    public static Vector2<ushort> ToUShort(this Vector2<int> value) => new((ushort)value.X, (ushort)value.Y);
    public static Vector2<ushort> ToUShort(this Vector2<uint> value) => new((ushort)value.X, (ushort)value.Y);
    public static Vector2<ushort> ToUShort(this Vector2<long> value) => new((ushort)value.X, (ushort)value.Y);
    public static Vector2<ushort> ToUShort(this Vector2<ulong> value) => new((ushort)value.X, (ushort)value.Y);
    public static Vector2<ushort> ToUShort(this Vector2<float> value) => new((ushort)value.X, (ushort)value.Y);
    public static Vector2<ushort> ToUShort(this Vector2<double> value) => new((ushort)value.X, (ushort)value.Y);
    public static Vector2<ushort> ToUShort(this Vector2<decimal> value) => new((ushort)value.X, (ushort)value.Y);

    public static Vector2<ushort> ToUShortOrClamp(this Vector2<sbyte> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp());
    public static Vector2<ushort> ToUShortOrClamp(this Vector2<short> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp());
    public static Vector2<ushort> ToUShortOrClamp(this Vector2<int> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp());
    public static Vector2<ushort> ToUShortOrClamp(this Vector2<uint> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp());
    public static Vector2<ushort> ToUShortOrClamp(this Vector2<long> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp());
    public static Vector2<ushort> ToUShortOrClamp(this Vector2<ulong> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp());
    public static Vector2<ushort> ToUShortOrClamp(this Vector2<float> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp());
    public static Vector2<ushort> ToUShortOrClamp(this Vector2<double> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp());
    public static Vector2<ushort> ToUShortOrClamp(this Vector2<decimal> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp());

    public static Vector2<ushort> ToUShortOrDefault(this Vector2<sbyte> value, ushort defaultValue = default) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue));
    public static Vector2<ushort> ToUShortOrDefault(this Vector2<short> value, ushort defaultValue = default) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue));
    public static Vector2<ushort> ToUShortOrDefault(this Vector2<int> value, ushort defaultValue = default) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue));
    public static Vector2<ushort> ToUShortOrDefault(this Vector2<uint> value, ushort defaultValue = default) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue));
    public static Vector2<ushort> ToUShortOrDefault(this Vector2<long> value, ushort defaultValue = default) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue));
    public static Vector2<ushort> ToUShortOrDefault(this Vector2<ulong> value, ushort defaultValue = default) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue));
    public static Vector2<ushort> ToUShortOrDefault(this Vector2<float> value, ushort defaultValue = default) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue));
    public static Vector2<ushort> ToUShortOrDefault(this Vector2<double> value, ushort defaultValue = default) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue));
    public static Vector2<ushort> ToUShortOrDefault(this Vector2<decimal> value, ushort defaultValue = default) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue));

    public static Vector2<int> ToInt(this Vector2<sbyte> value) => new(value.X, value.Y);
    public static Vector2<int> ToInt(this Vector2<byte> value) => new(value.X, value.Y);
    public static Vector2<int> ToInt(this Vector2<short> value) => new(value.X, value.Y);
    public static Vector2<int> ToInt(this Vector2<ushort> value) => new(value.X, value.Y);
    public static Vector2<int> ToInt(this Vector2<uint> value) => new((int)value.X, (int)value.Y);
    public static Vector2<int> ToInt(this Vector2<long> value) => new((int)value.X, (int)value.Y);
    public static Vector2<int> ToInt(this Vector2<ulong> value) => new((int)value.X, (int)value.Y);
    public static Vector2<int> ToInt(this Vector2<float> value) => new((int)value.X, (int)value.Y);
    public static Vector2<int> ToInt(this Vector2<double> value) => new((int)value.X, (int)value.Y);
    public static Vector2<int> ToInt(this Vector2<decimal> value) => new((int)value.X, (int)value.Y);

    public static Vector2<int> ToIntOrClamp(this Vector2<uint> value) => new(value.X.ToIntOrClamp(), value.Y.ToIntOrClamp());
    public static Vector2<int> ToIntOrClamp(this Vector2<long> value) => new(value.X.ToIntOrClamp(), value.Y.ToIntOrClamp());
    public static Vector2<int> ToIntOrClamp(this Vector2<ulong> value) => new(value.X.ToIntOrClamp(), value.Y.ToIntOrClamp());
    public static Vector2<int> ToIntOrClamp(this Vector2<float> value) => new(value.X.ToIntOrClamp(), value.Y.ToIntOrClamp());
    public static Vector2<int> ToIntOrClamp(this Vector2<double> value) => new(value.X.ToIntOrClamp(), value.Y.ToIntOrClamp());
    public static Vector2<int> ToIntOrClamp(this Vector2<decimal> value) => new(value.X.ToIntOrClamp(), value.Y.ToIntOrClamp());

    public static Vector2<int> ToIntOrDefault(this Vector2<uint> value, int defaultValue = default) => new(value.X.ToIntOrDefault(defaultValue), value.Y.ToIntOrDefault(defaultValue));
    public static Vector2<int> ToIntOrDefault(this Vector2<long> value, int defaultValue = default) => new(value.X.ToIntOrDefault(defaultValue), value.Y.ToIntOrDefault(defaultValue));
    public static Vector2<int> ToIntOrDefault(this Vector2<ulong> value, int defaultValue = default) => new(value.X.ToIntOrDefault(defaultValue), value.Y.ToIntOrDefault(defaultValue));
    public static Vector2<int> ToIntOrDefault(this Vector2<float> value, int defaultValue = default) => new(value.X.ToIntOrDefault(defaultValue), value.Y.ToIntOrDefault(defaultValue));
    public static Vector2<int> ToIntOrDefault(this Vector2<double> value, int defaultValue = default) => new(value.X.ToIntOrDefault(defaultValue), value.Y.ToIntOrDefault(defaultValue));
    public static Vector2<int> ToIntOrDefault(this Vector2<decimal> value, int defaultValue = default) => new(value.X.ToIntOrDefault(defaultValue), value.Y.ToIntOrDefault(defaultValue));

    public static Vector2<uint> ToUInt(this Vector2<sbyte> value) => new((uint)value.X, (uint)value.Y);
    public static Vector2<uint> ToUInt(this Vector2<byte> value) => new(value.X, value.Y);
    public static Vector2<uint> ToUInt(this Vector2<short> value) => new((uint)value.X, (uint)value.Y);
    public static Vector2<uint> ToUInt(this Vector2<ushort> value) => new(value.X, value.Y);
    public static Vector2<uint> ToUInt(this Vector2<int> value) => new((uint)value.X, (uint)value.Y);
    public static Vector2<uint> ToUInt(this Vector2<long> value) => new((uint)value.X, (uint)value.Y);
    public static Vector2<uint> ToUInt(this Vector2<ulong> value) => new((uint)value.X, (uint)value.Y);
    public static Vector2<uint> ToUInt(this Vector2<float> value) => new((uint)value.X, (uint)value.Y);
    public static Vector2<uint> ToUInt(this Vector2<double> value) => new((uint)value.X, (uint)value.Y);
    public static Vector2<uint> ToUInt(this Vector2<decimal> value) => new((uint)value.X, (uint)value.Y);

    public static Vector2<uint> ToUIntOrClamp(this Vector2<sbyte> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp());
    public static Vector2<uint> ToUIntOrClamp(this Vector2<short> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp());
    public static Vector2<uint> ToUIntOrClamp(this Vector2<int> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp());
    public static Vector2<uint> ToUIntOrClamp(this Vector2<long> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp());
    public static Vector2<uint> ToUIntOrClamp(this Vector2<ulong> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp());
    public static Vector2<uint> ToUIntOrClamp(this Vector2<float> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp());
    public static Vector2<uint> ToUIntOrClamp(this Vector2<double> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp());
    public static Vector2<uint> ToUIntOrClamp(this Vector2<decimal> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp());

    public static Vector2<uint> ToUIntOrDefault(this Vector2<sbyte> value, uint defaultValue = default) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue));
    public static Vector2<uint> ToUIntOrDefault(this Vector2<short> value, uint defaultValue = default) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue));
    public static Vector2<uint> ToUIntOrDefault(this Vector2<int> value, uint defaultValue = default) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue));
    public static Vector2<uint> ToUIntOrDefault(this Vector2<long> value, uint defaultValue = default) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue));
    public static Vector2<uint> ToUIntOrDefault(this Vector2<ulong> value, uint defaultValue = default) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue));
    public static Vector2<uint> ToUIntOrDefault(this Vector2<float> value, uint defaultValue = default) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue));
    public static Vector2<uint> ToUIntOrDefault(this Vector2<double> value, uint defaultValue = default) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue));
    public static Vector2<uint> ToUIntOrDefault(this Vector2<decimal> value, uint defaultValue = default) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue));

    public static Vector2<long> ToLong(this Vector2<sbyte> value) => new(value.X, value.Y);
    public static Vector2<long> ToLong(this Vector2<byte> value) => new(value.X, value.Y);
    public static Vector2<long> ToLong(this Vector2<short> value) => new(value.X, value.Y);
    public static Vector2<long> ToLong(this Vector2<ushort> value) => new(value.X, value.Y);
    public static Vector2<long> ToLong(this Vector2<int> value) => new(value.X, value.Y);
    public static Vector2<long> ToLong(this Vector2<uint> value) => new(value.X, value.Y);
    public static Vector2<long> ToLong(this Vector2<ulong> value) => new((long)value.X, (long)value.Y);
    public static Vector2<long> ToLong(this Vector2<float> value) => new((long)value.X, (long)value.Y);
    public static Vector2<long> ToLong(this Vector2<double> value) => new((long)value.X, (long)value.Y);
    public static Vector2<long> ToLong(this Vector2<decimal> value) => new((long)value.X, (long)value.Y);

    public static Vector2<long> ToLongOrClamp(this Vector2<ulong> value) => new(value.X.ToLongOrClamp(), value.Y.ToLongOrClamp());
    public static Vector2<long> ToLongOrClamp(this Vector2<float> value) => new(value.X.ToLongOrClamp(), value.Y.ToLongOrClamp());
    public static Vector2<long> ToLongOrClamp(this Vector2<double> value) => new(value.X.ToLongOrClamp(), value.Y.ToLongOrClamp());
    public static Vector2<long> ToLongOrClamp(this Vector2<decimal> value) => new(value.X.ToLongOrClamp(), value.Y.ToLongOrClamp());

    public static Vector2<long> ToLongOrDefault(this Vector2<ulong> value, long defaultValue = default) => new(value.X.ToLongOrDefault(defaultValue), value.Y.ToLongOrDefault(defaultValue));
    public static Vector2<long> ToLongOrDefault(this Vector2<float> value, long defaultValue = default) => new(value.X.ToLongOrDefault(defaultValue), value.Y.ToLongOrDefault(defaultValue));
    public static Vector2<long> ToLongOrDefault(this Vector2<double> value, long defaultValue = default) => new(value.X.ToLongOrDefault(defaultValue), value.Y.ToLongOrDefault(defaultValue));
    public static Vector2<long> ToLongOrDefault(this Vector2<decimal> value, long defaultValue = default) => new(value.X.ToLongOrDefault(defaultValue), value.Y.ToLongOrDefault(defaultValue));

    public static Vector2<ulong> ToULong(this Vector2<sbyte> value) => new((ulong)value.X, (ulong)value.Y);
    public static Vector2<ulong> ToULong(this Vector2<byte> value) => new(value.X, value.Y);
    public static Vector2<ulong> ToULong(this Vector2<short> value) => new((ulong)value.X, (ulong)value.Y);
    public static Vector2<ulong> ToULong(this Vector2<ushort> value) => new(value.X, value.Y);
    public static Vector2<ulong> ToULong(this Vector2<int> value) => new((ulong)value.X, (ulong)value.Y);
    public static Vector2<ulong> ToULong(this Vector2<uint> value) => new(value.X, value.Y);
    public static Vector2<ulong> ToULong(this Vector2<long> value) => new((ulong)value.X, (ulong)value.Y);
    public static Vector2<ulong> ToULong(this Vector2<float> value) => new((ulong)value.X, (ulong)value.Y);
    public static Vector2<ulong> ToULong(this Vector2<double> value) => new((ulong)value.X, (ulong)value.Y);
    public static Vector2<ulong> ToULong(this Vector2<decimal> value) => new((ulong)value.X, (ulong)value.Y);

    public static Vector2<ulong> ToULongOrClamp(this Vector2<sbyte> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp());
    public static Vector2<ulong> ToULongOrClamp(this Vector2<short> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp());
    public static Vector2<ulong> ToULongOrClamp(this Vector2<int> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp());
    public static Vector2<ulong> ToULongOrClamp(this Vector2<long> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp());
    public static Vector2<ulong> ToULongOrClamp(this Vector2<float> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp());
    public static Vector2<ulong> ToULongOrClamp(this Vector2<double> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp());
    public static Vector2<ulong> ToULongOrClamp(this Vector2<decimal> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp());

    public static Vector2<ulong> ToULongOrDefault(this Vector2<sbyte> value, ulong defaultValue = default) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue));
    public static Vector2<ulong> ToULongOrDefault(this Vector2<short> value, ulong defaultValue = default) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue));
    public static Vector2<ulong> ToULongOrDefault(this Vector2<int> value, ulong defaultValue = default) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue));
    public static Vector2<ulong> ToULongOrDefault(this Vector2<long> value, ulong defaultValue = default) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue));
    public static Vector2<ulong> ToULongOrDefault(this Vector2<float> value, ulong defaultValue = default) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue));
    public static Vector2<ulong> ToULongOrDefault(this Vector2<double> value, ulong defaultValue = default) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue));
    public static Vector2<ulong> ToULongOrDefault(this Vector2<decimal> value, ulong defaultValue = default) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue));

    public static Vector2<float> ToFloat(this Vector2<sbyte> value) => new(value.X, value.Y);
    public static Vector2<float> ToFloat(this Vector2<byte> value) => new(value.X, value.Y);
    public static Vector2<float> ToFloat(this Vector2<short> value) => new(value.X, value.Y);
    public static Vector2<float> ToFloat(this Vector2<ushort> value) => new(value.X, value.Y);
    public static Vector2<float> ToFloat(this Vector2<int> value) => new(value.X, value.Y);
    public static Vector2<float> ToFloat(this Vector2<uint> value) => new(value.X, value.Y);
    public static Vector2<float> ToFloat(this Vector2<long> value) => new(value.X, value.Y);
    public static Vector2<float> ToFloat(this Vector2<ulong> value) => new(value.X, value.Y);
    public static Vector2<float> ToFloat(this Vector2<double> value) => new((float)value.X, (float)value.Y);
    public static Vector2<float> ToFloat(this Vector2<decimal> value) => new((float)value.X, (float)value.Y);

    public static Vector2<float> ToFloatOrClamp(this Vector2<double> value) => new(value.X.ToFloatOrClamp(), value.Y.ToFloatOrClamp());
    public static Vector2<float> ToFloatOrClamp(this Vector2<decimal> value) => new(value.X.ToFloatOrClamp(), value.Y.ToFloatOrClamp());

    public static Vector2<float> ToFloatOrDefault(this Vector2<double> value, float defaultValue = default) => new(value.X.ToFloatOrDefault(defaultValue), value.Y.ToFloatOrDefault(defaultValue));
    public static Vector2<float> ToFloatOrDefault(this Vector2<decimal> value, float defaultValue = default) => new(value.X.ToFloatOrDefault(defaultValue), value.Y.ToFloatOrDefault(defaultValue));

    public static Vector2<double> ToDouble(this Vector2<sbyte> value) => new(value.X, value.Y);
    public static Vector2<double> ToDouble(this Vector2<byte> value) => new(value.X, value.Y);
    public static Vector2<double> ToDouble(this Vector2<short> value) => new(value.X, value.Y);
    public static Vector2<double> ToDouble(this Vector2<ushort> value) => new(value.X, value.Y);
    public static Vector2<double> ToDouble(this Vector2<int> value) => new(value.X, value.Y);
    public static Vector2<double> ToDouble(this Vector2<uint> value) => new(value.X, value.Y);
    public static Vector2<double> ToDouble(this Vector2<long> value) => new(value.X, value.Y);
    public static Vector2<double> ToDouble(this Vector2<ulong> value) => new(value.X, value.Y);
    public static Vector2<double> ToDouble(this Vector2<float> value) => new(value.X, value.Y);
    public static Vector2<double> ToDouble(this Vector2<decimal> value) => new((double)value.X, (double)value.Y);

    public static Vector2<double> ToDoubleOrClamp(this Vector2<decimal> value) => new(value.X.ToDoubleOrClamp(), value.Y.ToDoubleOrClamp());

    public static Vector2<double> ToDoubleOrDefault(this Vector2<decimal> value, double defaultValue = default) => new(value.X.ToDoubleOrDefault(defaultValue), value.Y.ToDoubleOrDefault(defaultValue));

    public static Vector2<decimal> ToDecimal(this Vector2<sbyte> value) => new(value.X, value.Y);
    public static Vector2<decimal> ToDecimal(this Vector2<byte> value) => new(value.X, value.Y);
    public static Vector2<decimal> ToDecimal(this Vector2<short> value) => new(value.X, value.Y);
    public static Vector2<decimal> ToDecimal(this Vector2<ushort> value) => new(value.X, value.Y);
    public static Vector2<decimal> ToDecimal(this Vector2<int> value) => new(value.X, value.Y);
    public static Vector2<decimal> ToDecimal(this Vector2<uint> value) => new(value.X, value.Y);
    public static Vector2<decimal> ToDecimal(this Vector2<long> value) => new(value.X, value.Y);
    public static Vector2<decimal> ToDecimal(this Vector2<ulong> value) => new(value.X, value.Y);
    public static Vector2<decimal> ToDecimal(this Vector2<float> value) => new((decimal)value.X, (decimal)value.Y);
    public static Vector2<decimal> ToDecimal(this Vector2<double> value) => new((decimal)value.X, (decimal)value.Y);

    public static Vector2<float> Floor(this Vector2<float> value) => new(MathF.Floor(value.X), MathF.Floor(value.Y));
    public static Vector2<double> Floor(this Vector2<double> value) => new(Math.Floor(value.X), Math.Floor(value.Y));
    public static Vector2<decimal> Floor(this Vector2<decimal> value) => new(Math.Floor(value.X), Math.Floor(value.Y));

    public static Vector2<float> Ceiling(this Vector2<float> value) => new(MathF.Ceiling(value.X), MathF.Ceiling(value.Y));
    public static Vector2<double> Ceiling(this Vector2<double> value) => new(Math.Ceiling(value.X), Math.Floor(value.Y));
    public static Vector2<decimal> Ceiling(this Vector2<decimal> value) => new(Math.Ceiling(value.X), Math.Ceiling(value.Y));

    public static Vector2<float> Interpolate(this Vector2<float> start, Vector2<float> target, float progress)
    {
        return new Vector2<float>(Interpolation.Calculate(start.X, target.X, progress), Interpolation.Calculate(start.Y, target.Y, progress));
    }

    public static Vector2<double> Interpolate(this Vector2<double> start, Vector2<double> target, double progress)
    {
        return new Vector2<double>(Interpolation.Calculate(start.X, target.X, progress), Interpolation.Calculate(start.Y, target.Y, progress));
    }

    public static Vector2<decimal> Interpolate(this Vector2<decimal> start, Vector2<decimal> target, decimal progress)
    {
        return new Vector2<decimal>(Interpolation.Calculate(start.X, target.X, progress), Interpolation.Calculate(start.Y, target.Y, progress));
    }

    public static Vector2<float> GetDelta(this Vector2<float> startPosition, Vector2<float> targetPosition, float elapsedTime, float targetTime)
    {
        return startPosition.ToVector3().GetDelta(targetPosition.ToVector3(), elapsedTime, targetTime);
    }

    public static Vector2<double> GetDelta(this Vector2<double> startPosition, Vector2<double> targetPosition, double elapsedTime, double targetTime)
    {
        return startPosition.ToVector3().GetDelta(targetPosition.ToVector3(), elapsedTime, targetTime);
    }

    public static Vector2<decimal> GetDelta(this Vector2<decimal> startPosition, Vector2<decimal> targetPosition, decimal elapsedTime, decimal targetTime)
    {
        return startPosition.ToVector3().GetDelta(targetPosition.ToVector3(), elapsedTime, targetTime);
    }
}