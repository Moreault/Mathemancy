namespace ToolBX.Mathemancy;

public static class Vector3Extensions
{
    public static Vector3<sbyte> ToSByte(this Vector3<byte> value) => new((sbyte)value.X, (sbyte)value.Y, (sbyte)value.Z);
    public static Vector3<sbyte> ToSByte(this Vector3<short> value) => new((sbyte)value.X, (sbyte)value.Y, (sbyte)value.Z);
    public static Vector3<sbyte> ToSByte(this Vector3<ushort> value) => new((sbyte)value.X, (sbyte)value.Y, (sbyte)value.Z);
    public static Vector3<sbyte> ToSByte(this Vector3<int> value) => new((sbyte)value.X, (sbyte)value.Y, (sbyte)value.Z);
    public static Vector3<sbyte> ToSByte(this Vector3<uint> value) => new((sbyte)value.X, (sbyte)value.Y, (sbyte)value.Z);
    public static Vector3<sbyte> ToSByte(this Vector3<long> value) => new((sbyte)value.X, (sbyte)value.Y, (sbyte)value.Z);
    public static Vector3<sbyte> ToSByte(this Vector3<ulong> value) => new((sbyte)value.X, (sbyte)value.Y, (sbyte)value.Z);
    public static Vector3<sbyte> ToSByte(this Vector3<float> value) => new((sbyte)value.X, (sbyte)value.Y, (sbyte)value.Z);
    public static Vector3<sbyte> ToSByte(this Vector3<double> value) => new((sbyte)value.X, (sbyte)value.Y, (sbyte)value.Z);
    public static Vector3<sbyte> ToSByte(this Vector3<decimal> value) => new((sbyte)value.X, (sbyte)value.Y, (sbyte)value.Z);

    public static Vector3<sbyte> ToSByteOrClamp(this Vector3<byte> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp(), value.Z.ToSByteOrClamp());
    public static Vector3<sbyte> ToSByteOrClamp(this Vector3<short> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp(), value.Z.ToSByteOrClamp());
    public static Vector3<sbyte> ToSByteOrClamp(this Vector3<ushort> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp(), value.Z.ToSByteOrClamp());
    public static Vector3<sbyte> ToSByteOrClamp(this Vector3<int> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp(), value.Z.ToSByteOrClamp());
    public static Vector3<sbyte> ToSByteOrClamp(this Vector3<uint> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp(), value.Z.ToSByteOrClamp());
    public static Vector3<sbyte> ToSByteOrClamp(this Vector3<long> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp(), value.Z.ToSByteOrClamp());
    public static Vector3<sbyte> ToSByteOrClamp(this Vector3<ulong> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp(), value.Z.ToSByteOrClamp());
    public static Vector3<sbyte> ToSByteOrClamp(this Vector3<float> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp(), value.Z.ToSByteOrClamp());
    public static Vector3<sbyte> ToSByteOrClamp(this Vector3<double> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp(), value.Z.ToSByteOrClamp());
    public static Vector3<sbyte> ToSByteOrClamp(this Vector3<decimal> value) => new(value.X.ToSByteOrClamp(), value.Y.ToSByteOrClamp(), value.Z.ToSByteOrClamp());

    public static Vector3<sbyte> ToSByteOrDefault(this Vector3<byte> value, sbyte defaultValue) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue), value.Z.ToSByteOrDefault(defaultValue));
    public static Vector3<sbyte> ToSByteOrDefault(this Vector3<short> value, sbyte defaultValue) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue), value.Z.ToSByteOrDefault(defaultValue));
    public static Vector3<sbyte> ToSByteOrDefault(this Vector3<ushort> value, sbyte defaultValue) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue), value.Z.ToSByteOrDefault(defaultValue));
    public static Vector3<sbyte> ToSByteOrDefault(this Vector3<int> value, sbyte defaultValue) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue), value.Z.ToSByteOrDefault(defaultValue));
    public static Vector3<sbyte> ToSByteOrDefault(this Vector3<uint> value, sbyte defaultValue) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue), value.Z.ToSByteOrDefault(defaultValue));
    public static Vector3<sbyte> ToSByteOrDefault(this Vector3<long> value, sbyte defaultValue) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue), value.Z.ToSByteOrDefault(defaultValue));
    public static Vector3<sbyte> ToSByteOrDefault(this Vector3<ulong> value, sbyte defaultValue) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue), value.Z.ToSByteOrDefault(defaultValue));
    public static Vector3<sbyte> ToSByteOrDefault(this Vector3<float> value, sbyte defaultValue) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue), value.Z.ToSByteOrDefault(defaultValue));
    public static Vector3<sbyte> ToSByteOrDefault(this Vector3<double> value, sbyte defaultValue) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue), value.Z.ToSByteOrDefault(defaultValue));
    public static Vector3<sbyte> ToSByteOrDefault(this Vector3<decimal> value, sbyte defaultValue) => new(value.X.ToSByteOrDefault(defaultValue), value.Y.ToSByteOrDefault(defaultValue), value.Z.ToSByteOrDefault(defaultValue));

    public static Vector3<byte> ToByte(this Vector3<sbyte> value) => new((byte)value.X, (byte)value.Y, (byte)value.Z);
    public static Vector3<byte> ToByte(this Vector3<short> value) => new((byte)value.X, (byte)value.Y, (byte)value.Z);
    public static Vector3<byte> ToByte(this Vector3<ushort> value) => new((byte)value.X, (byte)value.Y, (byte)value.Z);
    public static Vector3<byte> ToByte(this Vector3<int> value) => new((byte)value.X, (byte)value.Y, (byte)value.Z);
    public static Vector3<byte> ToByte(this Vector3<uint> value) => new((byte)value.X, (byte)value.Y, (byte)value.Z);
    public static Vector3<byte> ToByte(this Vector3<long> value) => new((byte)value.X, (byte)value.Y, (byte)value.Z);
    public static Vector3<byte> ToByte(this Vector3<ulong> value) => new((byte)value.X, (byte)value.Y, (byte)value.Z);
    public static Vector3<byte> ToByte(this Vector3<float> value) => new((byte)value.X, (byte)value.Y, (byte)value.Z);
    public static Vector3<byte> ToByte(this Vector3<double> value) => new((byte)value.X, (byte)value.Y, (byte)value.Z);
    public static Vector3<byte> ToByte(this Vector3<decimal> value) => new((byte)value.X, (byte)value.Y, (byte)value.Z);

    public static Vector3<byte> ToByteOrClamp(this Vector3<sbyte> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp(), value.Z.ToByteOrClamp());
    public static Vector3<byte> ToByteOrClamp(this Vector3<short> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp(), value.Z.ToByteOrClamp());
    public static Vector3<byte> ToByteOrClamp(this Vector3<ushort> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp(), value.Z.ToByteOrClamp());
    public static Vector3<byte> ToByteOrClamp(this Vector3<int> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp(), value.Z.ToByteOrClamp());
    public static Vector3<byte> ToByteOrClamp(this Vector3<uint> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp(), value.Z.ToByteOrClamp());
    public static Vector3<byte> ToByteOrClamp(this Vector3<long> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp(), value.Z.ToByteOrClamp());
    public static Vector3<byte> ToByteOrClamp(this Vector3<ulong> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp(), value.Z.ToByteOrClamp());
    public static Vector3<byte> ToByteOrClamp(this Vector3<float> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp(), value.Z.ToByteOrClamp());
    public static Vector3<byte> ToByteOrClamp(this Vector3<double> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp(), value.Z.ToByteOrClamp());
    public static Vector3<byte> ToByteOrClamp(this Vector3<decimal> value) => new(value.X.ToByteOrClamp(), value.Y.ToByteOrClamp(), value.Z.ToByteOrClamp());

    public static Vector3<byte> ToByteOrDefault(this Vector3<sbyte> value, byte defaultValue) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue), value.Z.ToByteOrDefault(defaultValue));
    public static Vector3<byte> ToByteOrDefault(this Vector3<short> value, byte defaultValue) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue), value.Z.ToByteOrDefault(defaultValue));
    public static Vector3<byte> ToByteOrDefault(this Vector3<ushort> value, byte defaultValue) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue), value.Z.ToByteOrDefault(defaultValue));
    public static Vector3<byte> ToByteOrDefault(this Vector3<int> value, byte defaultValue) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue), value.Z.ToByteOrDefault(defaultValue));
    public static Vector3<byte> ToByteOrDefault(this Vector3<uint> value, byte defaultValue) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue), value.Z.ToByteOrDefault(defaultValue));
    public static Vector3<byte> ToByteOrDefault(this Vector3<long> value, byte defaultValue) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue), value.Z.ToByteOrDefault(defaultValue));
    public static Vector3<byte> ToByteOrDefault(this Vector3<ulong> value, byte defaultValue) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue), value.Z.ToByteOrDefault(defaultValue));
    public static Vector3<byte> ToByteOrDefault(this Vector3<float> value, byte defaultValue) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue), value.Z.ToByteOrDefault(defaultValue));
    public static Vector3<byte> ToByteOrDefault(this Vector3<double> value, byte defaultValue) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue), value.Z.ToByteOrDefault(defaultValue));
    public static Vector3<byte> ToByteOrDefault(this Vector3<decimal> value, byte defaultValue) => new(value.X.ToByteOrDefault(defaultValue), value.Y.ToByteOrDefault(defaultValue), value.Z.ToByteOrDefault(defaultValue));

    public static Vector3<short> ToShort(this Vector3<sbyte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<short> ToShort(this Vector3<byte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<short> ToShort(this Vector3<ushort> value) => new((short)value.X, (short)value.Y, (short)value.Z);
    public static Vector3<short> ToShort(this Vector3<int> value) => new((short)value.X, (short)value.Y, (short)value.Z);
    public static Vector3<short> ToShort(this Vector3<uint> value) => new((short)value.X, (short)value.Y, (short)value.Z);
    public static Vector3<short> ToShort(this Vector3<long> value) => new((short)value.X, (short)value.Y, (short)value.Z);
    public static Vector3<short> ToShort(this Vector3<ulong> value) => new((short)value.X, (short)value.Y, (short)value.Z);
    public static Vector3<short> ToShort(this Vector3<float> value) => new((short)value.X, (short)value.Y, (short)value.Z);
    public static Vector3<short> ToShort(this Vector3<double> value) => new((short)value.X, (short)value.Y, (short)value.Z);
    public static Vector3<short> ToShort(this Vector3<decimal> value) => new((short)value.X, (short)value.Y, (short)value.Z);

    public static Vector3<short> ToShortOrClamp(this Vector3<ushort> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp(), value.Z.ToShortOrClamp());
    public static Vector3<short> ToShortOrClamp(this Vector3<int> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp(), value.Z.ToShortOrClamp());
    public static Vector3<short> ToShortOrClamp(this Vector3<uint> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp(), value.Z.ToShortOrClamp());
    public static Vector3<short> ToShortOrClamp(this Vector3<long> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp(), value.Z.ToShortOrClamp());
    public static Vector3<short> ToShortOrClamp(this Vector3<ulong> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp(), value.Z.ToShortOrClamp());
    public static Vector3<short> ToShortOrClamp(this Vector3<float> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp(), value.Z.ToShortOrClamp());
    public static Vector3<short> ToShortOrClamp(this Vector3<double> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp(), value.Z.ToShortOrClamp());
    public static Vector3<short> ToShortOrClamp(this Vector3<decimal> value) => new(value.X.ToShortOrClamp(), value.Y.ToShortOrClamp(), value.Z.ToShortOrClamp());

    public static Vector3<short> ToShortOrDefault(this Vector3<ushort> value, short defaultValue) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue), value.Z.ToShortOrDefault(defaultValue));
    public static Vector3<short> ToShortOrDefault(this Vector3<int> value, short defaultValue) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue), value.Z.ToShortOrDefault(defaultValue));
    public static Vector3<short> ToShortOrDefault(this Vector3<uint> value, short defaultValue) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue), value.Z.ToShortOrDefault(defaultValue));
    public static Vector3<short> ToShortOrDefault(this Vector3<long> value, short defaultValue) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue), value.Z.ToShortOrDefault(defaultValue));
    public static Vector3<short> ToShortOrDefault(this Vector3<ulong> value, short defaultValue) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue), value.Z.ToShortOrDefault(defaultValue));
    public static Vector3<short> ToShortOrDefault(this Vector3<float> value, short defaultValue) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue), value.Z.ToShortOrDefault(defaultValue));
    public static Vector3<short> ToShortOrDefault(this Vector3<double> value, short defaultValue) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue), value.Z.ToShortOrDefault(defaultValue));
    public static Vector3<short> ToShortOrDefault(this Vector3<decimal> value, short defaultValue) => new(value.X.ToShortOrDefault(defaultValue), value.Y.ToShortOrDefault(defaultValue), value.Z.ToShortOrDefault(defaultValue));

    public static Vector3<ushort> ToUShort(this Vector3<sbyte> value) => new((ushort)value.X, (ushort)value.Y, (ushort)value.Z);
    public static Vector3<ushort> ToUShort(this Vector3<byte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<ushort> ToUShort(this Vector3<short> value) => new((ushort)value.X, (ushort)value.Y, (ushort)value.Z);
    public static Vector3<ushort> ToUShort(this Vector3<int> value) => new((ushort)value.X, (ushort)value.Y, (ushort)value.Z);
    public static Vector3<ushort> ToUShort(this Vector3<uint> value) => new((ushort)value.X, (ushort)value.Y, (ushort)value.Z);
    public static Vector3<ushort> ToUShort(this Vector3<long> value) => new((ushort)value.X, (ushort)value.Y, (ushort)value.Z);
    public static Vector3<ushort> ToUShort(this Vector3<ulong> value) => new((ushort)value.X, (ushort)value.Y, (ushort)value.Z);
    public static Vector3<ushort> ToUShort(this Vector3<float> value) => new((ushort)value.X, (ushort)value.Y, (ushort)value.Z);
    public static Vector3<ushort> ToUShort(this Vector3<double> value) => new((ushort)value.X, (ushort)value.Y, (ushort)value.Z);
    public static Vector3<ushort> ToUShort(this Vector3<decimal> value) => new((ushort)value.X, (ushort)value.Y, (ushort)value.Z);

    public static Vector3<ushort> ToUShortOrClamp(this Vector3<sbyte> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp(), value.Z.ToUShortOrClamp());
    public static Vector3<ushort> ToUShortOrClamp(this Vector3<short> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp(), value.Z.ToUShortOrClamp());
    public static Vector3<ushort> ToUShortOrClamp(this Vector3<int> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp(), value.Z.ToUShortOrClamp());
    public static Vector3<ushort> ToUShortOrClamp(this Vector3<uint> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp(), value.Z.ToUShortOrClamp());
    public static Vector3<ushort> ToUShortOrClamp(this Vector3<long> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp(), value.Z.ToUShortOrClamp());
    public static Vector3<ushort> ToUShortOrClamp(this Vector3<ulong> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp(), value.Z.ToUShortOrClamp());
    public static Vector3<ushort> ToUShortOrClamp(this Vector3<float> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp(), value.Z.ToUShortOrClamp());
    public static Vector3<ushort> ToUShortOrClamp(this Vector3<double> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp(), value.Z.ToUShortOrClamp());
    public static Vector3<ushort> ToUShortOrClamp(this Vector3<decimal> value) => new(value.X.ToUShortOrClamp(), value.Y.ToUShortOrClamp(), value.Z.ToUShortOrClamp());

    public static Vector3<ushort> ToUShortOrDefault(this Vector3<sbyte> value, ushort defaultValue) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue), value.Z.ToUShortOrDefault(defaultValue));
    public static Vector3<ushort> ToUShortOrDefault(this Vector3<short> value, ushort defaultValue) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue), value.Z.ToUShortOrDefault(defaultValue));
    public static Vector3<ushort> ToUShortOrDefault(this Vector3<int> value, ushort defaultValue) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue), value.Z.ToUShortOrDefault(defaultValue));
    public static Vector3<ushort> ToUShortOrDefault(this Vector3<uint> value, ushort defaultValue) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue), value.Z.ToUShortOrDefault(defaultValue));
    public static Vector3<ushort> ToUShortOrDefault(this Vector3<long> value, ushort defaultValue) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue), value.Z.ToUShortOrDefault(defaultValue));
    public static Vector3<ushort> ToUShortOrDefault(this Vector3<ulong> value, ushort defaultValue) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue), value.Z.ToUShortOrDefault(defaultValue));
    public static Vector3<ushort> ToUShortOrDefault(this Vector3<float> value, ushort defaultValue) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue), value.Z.ToUShortOrDefault(defaultValue));
    public static Vector3<ushort> ToUShortOrDefault(this Vector3<double> value, ushort defaultValue) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue), value.Z.ToUShortOrDefault(defaultValue));
    public static Vector3<ushort> ToUShortOrDefault(this Vector3<decimal> value, ushort defaultValue) => new(value.X.ToUShortOrDefault(defaultValue), value.Y.ToUShortOrDefault(defaultValue), value.Z.ToUShortOrDefault(defaultValue));

    public static Vector3<int> ToInt(this Vector3<sbyte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<int> ToInt(this Vector3<byte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<int> ToInt(this Vector3<short> value) => new(value.X, value.Y, value.Z);
    public static Vector3<int> ToInt(this Vector3<ushort> value) => new(value.X, value.Y, value.Z);
    public static Vector3<int> ToInt(this Vector3<uint> value) => new((int)value.X, (int)value.Y, (int)value.Z);
    public static Vector3<int> ToInt(this Vector3<long> value) => new((int)value.X, (int)value.Y, (int)value.Z);
    public static Vector3<int> ToInt(this Vector3<ulong> value) => new((int)value.X, (int)value.Y, (int)value.Z);
    public static Vector3<int> ToInt(this Vector3<float> value) => new((int)value.X, (int)value.Y, (int)value.Z);
    public static Vector3<int> ToInt(this Vector3<double> value) => new((int)value.X, (int)value.Y, (int)value.Z);
    public static Vector3<int> ToInt(this Vector3<decimal> value) => new((int)value.X, (int)value.Y, (int)value.Z);

    public static Vector3<int> ToIntOrClamp(this Vector3<uint> value) => new(value.X.ToIntOrClamp(), value.Y.ToIntOrClamp(), value.Z.ToIntOrClamp());
    public static Vector3<int> ToIntOrClamp(this Vector3<long> value) => new(value.X.ToIntOrClamp(), value.Y.ToIntOrClamp(), value.Z.ToIntOrClamp());
    public static Vector3<int> ToIntOrClamp(this Vector3<ulong> value) => new(value.X.ToIntOrClamp(), value.Y.ToIntOrClamp(), value.Z.ToIntOrClamp());
    public static Vector3<int> ToIntOrClamp(this Vector3<float> value) => new(value.X.ToIntOrClamp(), value.Y.ToIntOrClamp(), value.Z.ToIntOrClamp());
    public static Vector3<int> ToIntOrClamp(this Vector3<double> value) => new(value.X.ToIntOrClamp(), value.Y.ToIntOrClamp(), value.Z.ToIntOrClamp());
    public static Vector3<int> ToIntOrClamp(this Vector3<decimal> value) => new(value.X.ToIntOrClamp(), value.Y.ToIntOrClamp(), value.Z.ToIntOrClamp());

    public static Vector3<int> ToIntOrDefault(this Vector3<uint> value, int defaultValue) => new(value.X.ToIntOrDefault(defaultValue), value.Y.ToIntOrDefault(defaultValue), value.Z.ToIntOrDefault(defaultValue));
    public static Vector3<int> ToIntOrDefault(this Vector3<long> value, int defaultValue) => new(value.X.ToIntOrDefault(defaultValue), value.Y.ToIntOrDefault(defaultValue), value.Z.ToIntOrDefault(defaultValue));
    public static Vector3<int> ToIntOrDefault(this Vector3<ulong> value, int defaultValue) => new(value.X.ToIntOrDefault(defaultValue), value.Y.ToIntOrDefault(defaultValue), value.Z.ToIntOrDefault(defaultValue));
    public static Vector3<int> ToIntOrDefault(this Vector3<float> value, int defaultValue) => new(value.X.ToIntOrDefault(defaultValue), value.Y.ToIntOrDefault(defaultValue), value.Z.ToIntOrDefault(defaultValue));
    public static Vector3<int> ToIntOrDefault(this Vector3<double> value, int defaultValue) => new(value.X.ToIntOrDefault(defaultValue), value.Y.ToIntOrDefault(defaultValue), value.Z.ToIntOrDefault(defaultValue));
    public static Vector3<int> ToIntOrDefault(this Vector3<decimal> value, int defaultValue) => new(value.X.ToIntOrDefault(defaultValue), value.Y.ToIntOrDefault(defaultValue), value.Z.ToIntOrDefault(defaultValue));

    public static Vector3<uint> ToUInt(this Vector3<sbyte> value) => new((uint)value.X, (uint)value.Y, (uint)value.Z);
    public static Vector3<uint> ToUInt(this Vector3<byte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<uint> ToUInt(this Vector3<short> value) => new((uint)value.X, (uint)value.Y, (uint)value.Z);
    public static Vector3<uint> ToUInt(this Vector3<ushort> value) => new(value.X, value.Y, value.Z);
    public static Vector3<uint> ToUInt(this Vector3<int> value) => new((uint)value.X, (uint)value.Y, (uint)value.Z);
    public static Vector3<uint> ToUInt(this Vector3<long> value) => new((uint)value.X, (uint)value.Y, (uint)value.Z);
    public static Vector3<uint> ToUInt(this Vector3<ulong> value) => new((uint)value.X, (uint)value.Y, (uint)value.Z);
    public static Vector3<uint> ToUInt(this Vector3<float> value) => new((uint)value.X, (uint)value.Y, (uint)value.Z);
    public static Vector3<uint> ToUInt(this Vector3<double> value) => new((uint)value.X, (uint)value.Y, (uint)value.Z);
    public static Vector3<uint> ToUInt(this Vector3<decimal> value) => new((uint)value.X, (uint)value.Y, (uint)value.Z);

    public static Vector3<uint> ToUIntOrClamp(this Vector3<sbyte> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp(), value.Z.ToUIntOrClamp());
    public static Vector3<uint> ToUIntOrClamp(this Vector3<short> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp(), value.Z.ToUIntOrClamp());
    public static Vector3<uint> ToUIntOrClamp(this Vector3<int> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp(), value.Z.ToUIntOrClamp());
    public static Vector3<uint> ToUIntOrClamp(this Vector3<long> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp(), value.Z.ToUIntOrClamp());
    public static Vector3<uint> ToUIntOrClamp(this Vector3<ulong> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp(), value.Z.ToUIntOrClamp());
    public static Vector3<uint> ToUIntOrClamp(this Vector3<float> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp(), value.Z.ToUIntOrClamp());
    public static Vector3<uint> ToUIntOrClamp(this Vector3<double> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp(), value.Z.ToUIntOrClamp());
    public static Vector3<uint> ToUIntOrClamp(this Vector3<decimal> value) => new(value.X.ToUIntOrClamp(), value.Y.ToUIntOrClamp(), value.Z.ToUIntOrClamp());

    public static Vector3<uint> ToUIntOrDefault(this Vector3<sbyte> value, uint defaultValue) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue), value.Z.ToUIntOrDefault(defaultValue));
    public static Vector3<uint> ToUIntOrDefault(this Vector3<short> value, uint defaultValue) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue), value.Z.ToUIntOrDefault(defaultValue));
    public static Vector3<uint> ToUIntOrDefault(this Vector3<int> value, uint defaultValue) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue), value.Z.ToUIntOrDefault(defaultValue));
    public static Vector3<uint> ToUIntOrDefault(this Vector3<long> value, uint defaultValue) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue), value.Z.ToUIntOrDefault(defaultValue));
    public static Vector3<uint> ToUIntOrDefault(this Vector3<ulong> value, uint defaultValue) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue), value.Z.ToUIntOrDefault(defaultValue));
    public static Vector3<uint> ToUIntOrDefault(this Vector3<float> value, uint defaultValue) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue), value.Z.ToUIntOrDefault(defaultValue));
    public static Vector3<uint> ToUIntOrDefault(this Vector3<double> value, uint defaultValue) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue), value.Z.ToUIntOrDefault(defaultValue));
    public static Vector3<uint> ToUIntOrDefault(this Vector3<decimal> value, uint defaultValue) => new(value.X.ToUIntOrDefault(defaultValue), value.Y.ToUIntOrDefault(defaultValue), value.Z.ToUIntOrDefault(defaultValue));

    public static Vector3<long> ToLong(this Vector3<sbyte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<long> ToLong(this Vector3<byte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<long> ToLong(this Vector3<short> value) => new(value.X, value.Y, value.Z);
    public static Vector3<long> ToLong(this Vector3<ushort> value) => new(value.X, value.Y, value.Z);
    public static Vector3<long> ToLong(this Vector3<int> value) => new(value.X, value.Y, value.Z);
    public static Vector3<long> ToLong(this Vector3<uint> value) => new(value.X, value.Y, value.Z);
    public static Vector3<long> ToLong(this Vector3<ulong> value) => new((long)value.X, (long)value.Y, (long)value.Z);
    public static Vector3<long> ToLong(this Vector3<float> value) => new((long)value.X, (long)value.Y, (long)value.Z);
    public static Vector3<long> ToLong(this Vector3<double> value) => new((long)value.X, (long)value.Y, (long)value.Z);
    public static Vector3<long> ToLong(this Vector3<decimal> value) => new((long)value.X, (long)value.Y, (long)value.Z);

    public static Vector3<long> ToLongOrClamp(this Vector3<ulong> value) => new(value.X.ToLongOrClamp(), value.Y.ToLongOrClamp(), value.Z.ToLongOrClamp());
    public static Vector3<long> ToLongOrClamp(this Vector3<float> value) => new(value.X.ToLongOrClamp(), value.Y.ToLongOrClamp(), value.Z.ToLongOrClamp());
    public static Vector3<long> ToLongOrClamp(this Vector3<double> value) => new(value.X.ToLongOrClamp(), value.Y.ToLongOrClamp(), value.Z.ToLongOrClamp());
    public static Vector3<long> ToLongOrClamp(this Vector3<decimal> value) => new(value.X.ToLongOrClamp(), value.Y.ToLongOrClamp(), value.Z.ToLongOrClamp());

    public static Vector3<long> ToLongOrDefault(this Vector3<ulong> value, long defaultValue) => new(value.X.ToLongOrDefault(defaultValue), value.Y.ToLongOrDefault(defaultValue), value.Z.ToLongOrDefault(defaultValue));
    public static Vector3<long> ToLongOrDefault(this Vector3<float> value, long defaultValue) => new(value.X.ToLongOrDefault(defaultValue), value.Y.ToLongOrDefault(defaultValue), value.Z.ToLongOrDefault(defaultValue));
    public static Vector3<long> ToLongOrDefault(this Vector3<double> value, long defaultValue) => new(value.X.ToLongOrDefault(defaultValue), value.Y.ToLongOrDefault(defaultValue), value.Z.ToLongOrDefault(defaultValue));
    public static Vector3<long> ToLongOrDefault(this Vector3<decimal> value, long defaultValue) => new(value.X.ToLongOrDefault(defaultValue), value.Y.ToLongOrDefault(defaultValue), value.Z.ToLongOrDefault(defaultValue));

    public static Vector3<ulong> ToULong(this Vector3<sbyte> value) => new((ulong)value.X, (ulong)value.Y, (ulong)value.Z);
    public static Vector3<ulong> ToULong(this Vector3<byte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<ulong> ToULong(this Vector3<short> value) => new((ulong)value.X, (ulong)value.Y, (ulong)value.Z);
    public static Vector3<ulong> ToULong(this Vector3<ushort> value) => new(value.X, value.Y, value.Z);
    public static Vector3<ulong> ToULong(this Vector3<int> value) => new((ulong)value.X, (ulong)value.Y, (ulong)value.Z);
    public static Vector3<ulong> ToULong(this Vector3<uint> value) => new(value.X, value.Y, value.Z);
    public static Vector3<ulong> ToULong(this Vector3<long> value) => new((ulong)value.X, (ulong)value.Y, (ulong)value.Z);
    public static Vector3<ulong> ToULong(this Vector3<float> value) => new((ulong)value.X, (ulong)value.Y, (ulong)value.Z);
    public static Vector3<ulong> ToULong(this Vector3<double> value) => new((ulong)value.X, (ulong)value.Y, (ulong)value.Z);
    public static Vector3<ulong> ToULong(this Vector3<decimal> value) => new((ulong)value.X, (ulong)value.Y, (ulong)value.Z);

    public static Vector3<ulong> ToULongOrClamp(this Vector3<sbyte> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp(), value.Z.ToULongOrClamp());
    public static Vector3<ulong> ToULongOrClamp(this Vector3<short> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp(), value.Z.ToULongOrClamp());
    public static Vector3<ulong> ToULongOrClamp(this Vector3<int> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp(), value.Z.ToULongOrClamp());
    public static Vector3<ulong> ToULongOrClamp(this Vector3<long> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp(), value.Z.ToULongOrClamp());
    public static Vector3<ulong> ToULongOrClamp(this Vector3<float> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp(), value.Z.ToULongOrClamp());
    public static Vector3<ulong> ToULongOrClamp(this Vector3<double> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp(), value.Z.ToULongOrClamp());
    public static Vector3<ulong> ToULongOrClamp(this Vector3<decimal> value) => new(value.X.ToULongOrClamp(), value.Y.ToULongOrClamp(), value.Z.ToULongOrClamp());

    public static Vector3<ulong> ToULongOrDefault(this Vector3<sbyte> value, ulong defaultValue) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue), value.Z.ToULongOrDefault(defaultValue));
    public static Vector3<ulong> ToULongOrDefault(this Vector3<short> value, ulong defaultValue) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue), value.Z.ToULongOrDefault(defaultValue));
    public static Vector3<ulong> ToULongOrDefault(this Vector3<int> value, ulong defaultValue) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue), value.Z.ToULongOrDefault(defaultValue));
    public static Vector3<ulong> ToULongOrDefault(this Vector3<long> value, ulong defaultValue) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue), value.Z.ToULongOrDefault(defaultValue));
    public static Vector3<ulong> ToULongOrDefault(this Vector3<float> value, ulong defaultValue) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue), value.Z.ToULongOrDefault(defaultValue));
    public static Vector3<ulong> ToULongOrDefault(this Vector3<double> value, ulong defaultValue) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue), value.Z.ToULongOrDefault(defaultValue));
    public static Vector3<ulong> ToULongOrDefault(this Vector3<decimal> value, ulong defaultValue) => new(value.X.ToULongOrDefault(defaultValue), value.Y.ToULongOrDefault(defaultValue), value.Z.ToULongOrDefault(defaultValue));

    public static Vector3<float> ToFloat(this Vector3<sbyte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<float> ToFloat(this Vector3<byte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<float> ToFloat(this Vector3<short> value) => new(value.X, value.Y, value.Z);
    public static Vector3<float> ToFloat(this Vector3<ushort> value) => new(value.X, value.Y, value.Z);
    public static Vector3<float> ToFloat(this Vector3<int> value) => new(value.X, value.Y, value.Z);
    public static Vector3<float> ToFloat(this Vector3<uint> value) => new(value.X, value.Y, value.Z);
    public static Vector3<float> ToFloat(this Vector3<long> value) => new(value.X, value.Y, value.Z);
    public static Vector3<float> ToFloat(this Vector3<ulong> value) => new(value.X, value.Y, value.Z);
    public static Vector3<float> ToFloat(this Vector3<double> value) => new((float)value.X, (float)value.Y, (float)value.Z);
    public static Vector3<float> ToFloat(this Vector3<decimal> value) => new((float)value.X, (float)value.Y, (float)value.Z);

    public static Vector3<float> ToFloatOrClamp(this Vector3<double> value) => new(value.X.ToFloatOrClamp(), value.Y.ToFloatOrClamp(), value.Z.ToFloatOrClamp());
    public static Vector3<float> ToFloatOrClamp(this Vector3<decimal> value) => new(value.X.ToFloatOrClamp(), value.Y.ToFloatOrClamp(), value.Z.ToFloatOrClamp());

    public static Vector3<float> ToFloatOrDefault(this Vector3<double> value, float defaultValue) => new(value.X.ToFloatOrDefault(defaultValue), value.Y.ToFloatOrDefault(defaultValue), value.Z.ToFloatOrDefault(defaultValue));
    public static Vector3<float> ToFloatOrDefault(this Vector3<decimal> value, float defaultValue) => new(value.X.ToFloatOrDefault(defaultValue), value.Y.ToFloatOrDefault(defaultValue), value.Z.ToFloatOrDefault(defaultValue));

    public static Vector3<double> ToDouble(this Vector3<sbyte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<double> ToDouble(this Vector3<byte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<double> ToDouble(this Vector3<short> value) => new(value.X, value.Y, value.Z);
    public static Vector3<double> ToDouble(this Vector3<ushort> value) => new(value.X, value.Y, value.Z);
    public static Vector3<double> ToDouble(this Vector3<int> value) => new(value.X, value.Y, value.Z);
    public static Vector3<double> ToDouble(this Vector3<uint> value) => new(value.X, value.Y, value.Z);
    public static Vector3<double> ToDouble(this Vector3<long> value) => new(value.X, value.Y, value.Z);
    public static Vector3<double> ToDouble(this Vector3<ulong> value) => new(value.X, value.Y, value.Z);
    public static Vector3<double> ToDouble(this Vector3<float> value) => new(value.X, value.Y, value.Z);
    public static Vector3<double> ToDouble(this Vector3<decimal> value) => new((double)value.X, (double)value.Y, (double)value.Z);

    public static Vector3<double> ToDoubleOrClamp(this Vector3<decimal> value) => new(value.X.ToDoubleOrClamp(), value.Y.ToDoubleOrClamp(), value.Z.ToDoubleOrClamp());

    public static Vector3<double> ToDoubleOrDefault(this Vector3<decimal> value, double defaultValue) => new(value.X.ToDoubleOrDefault(defaultValue), value.Y.ToDoubleOrDefault(defaultValue), value.Z.ToDoubleOrDefault(defaultValue));

    public static Vector3<decimal> ToDecimal(this Vector3<sbyte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<decimal> ToDecimal(this Vector3<byte> value) => new(value.X, value.Y, value.Z);
    public static Vector3<decimal> ToDecimal(this Vector3<short> value) => new(value.X, value.Y, value.Z);
    public static Vector3<decimal> ToDecimal(this Vector3<ushort> value) => new(value.X, value.Y, value.Z);
    public static Vector3<decimal> ToDecimal(this Vector3<int> value) => new(value.X, value.Y, value.Z);
    public static Vector3<decimal> ToDecimal(this Vector3<uint> value) => new(value.X, value.Y, value.Z);
    public static Vector3<decimal> ToDecimal(this Vector3<long> value) => new(value.X, value.Y, value.Z);
    public static Vector3<decimal> ToDecimal(this Vector3<ulong> value) => new(value.X, value.Y, value.Z);
    public static Vector3<decimal> ToDecimal(this Vector3<float> value) => new((decimal)value.X, (decimal)value.Y, (decimal)value.Z);
    public static Vector3<decimal> ToDecimal(this Vector3<double> value) => new((decimal)value.X, (decimal)value.Y, (decimal)value.Z);

    public static Vector3<float> Floor(this Vector3<float> value) => new(MathF.Floor(value.X), MathF.Floor(value.Y), MathF.Floor(value.Z));
    public static Vector3<double> Floor(this Vector3<double> value) => new(Math.Floor(value.X), Math.Floor(value.Y), Math.Floor(value.Z));
    public static Vector3<decimal> Floor(this Vector3<decimal> value) => new(Math.Floor(value.X), Math.Floor(value.Y), Math.Floor(value.Z));

    public static Vector3<float> Ceiling(this Vector3<float> value) => new(MathF.Ceiling(value.X), MathF.Ceiling(value.Y), MathF.Ceiling(value.Z));
    public static Vector3<double> Ceiling(this Vector3<double> value) => new(Math.Ceiling(value.X), Math.Floor(value.Y), Math.Ceiling(value.Z));
    public static Vector3<decimal> Ceiling(this Vector3<decimal> value) => new(Math.Ceiling(value.X), Math.Ceiling(value.Y), Math.Ceiling(value.Z));

    public static Vector3<float> Interpolate(this Vector3<float> start, Vector3<float> target, float progress)
    {
        return new Vector3<float>(Interpolation.Calculate(start.X, target.X, progress), Interpolation.Calculate(start.Y, target.Y, progress), Interpolation.Calculate(start.Z, target.Z, progress));
    }

    public static Vector3<double> Interpolate(this Vector3<double> start, Vector3<double> target, double progress)
    {
        return new Vector3<double>(Interpolation.Calculate(start.X, target.X, progress), Interpolation.Calculate(start.Y, target.Y, progress), Interpolation.Calculate(start.Z, target.Z, progress));
    }

    public static Vector2<decimal> Interpolate(this Vector3<decimal> start, Vector3<decimal> target, decimal progress)
    {
        return new Vector3<decimal>(Interpolation.Calculate(start.X, target.X, progress), Interpolation.Calculate(start.Y, target.Y, progress), Interpolation.Calculate(start.Z, target.Z, progress));
    }

    public static Vector3<float> GetDelta(this Vector3<float> startPosition, Vector3<float> targetPosition, float elapsedTime, float targetTime)
    {
        if (elapsedTime >= targetTime)
            return targetPosition;
        var progress = elapsedTime / targetTime;

        return startPosition.Interpolate(targetPosition, progress);
    }

    public static Vector3<double> GetDelta(this Vector3<double> startPosition, Vector3<double> targetPosition, double elapsedTime, double targetTime)
    {
        if (elapsedTime >= targetTime)
            return targetPosition;
        var progress = elapsedTime / targetTime;

        return startPosition.Interpolate(targetPosition, progress);
    }

    public static Vector3<decimal> GetDelta(this Vector3<decimal> startPosition, Vector3<decimal> targetPosition, decimal elapsedTime, decimal targetTime)
    {
        if (elapsedTime >= targetTime)
            return targetPosition;
        var progress = elapsedTime / targetTime;

        return startPosition.Interpolate(targetPosition, progress);
    }
}