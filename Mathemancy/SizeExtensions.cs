namespace ToolBX.Mathemancy;

public static class SizeExtensions
{
    public static Size<sbyte> ToSByte(this Size<byte> value) => new((sbyte)value.Width, (sbyte)value.Height);
    public static Size<sbyte> ToSByte(this Size<short> value) => new((sbyte)value.Width, (sbyte)value.Height);
    public static Size<sbyte> ToSByte(this Size<ushort> value) => new((sbyte)value.Width, (sbyte)value.Height);
    public static Size<sbyte> ToSByte(this Size<int> value) => new((sbyte)value.Width, (sbyte)value.Height);
    public static Size<sbyte> ToSByte(this Size<uint> value) => new((sbyte)value.Width, (sbyte)value.Height);
    public static Size<sbyte> ToSByte(this Size<long> value) => new((sbyte)value.Width, (sbyte)value.Height);
    public static Size<sbyte> ToSByte(this Size<ulong> value) => new((sbyte)value.Width, (sbyte)value.Height);
    public static Size<sbyte> ToSByte(this Size<float> value) => new((sbyte)value.Width, (sbyte)value.Height);
    public static Size<sbyte> ToSByte(this Size<double> value) => new((sbyte)value.Width, (sbyte)value.Height);
    public static Size<sbyte> ToSByte(this Size<decimal> value) => new((sbyte)value.Width, (sbyte)value.Height);

    public static Size<sbyte> ToSByteOrClamp(this Size<byte> value) => new(value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size<sbyte> ToSByteOrClamp(this Size<short> value) => new(value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size<sbyte> ToSByteOrClamp(this Size<ushort> value) => new(value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size<sbyte> ToSByteOrClamp(this Size<int> value) => new(value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size<sbyte> ToSByteOrClamp(this Size<uint> value) => new(value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size<sbyte> ToSByteOrClamp(this Size<long> value) => new(value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size<sbyte> ToSByteOrClamp(this Size<ulong> value) => new(value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size<sbyte> ToSByteOrClamp(this Size<float> value) => new(value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size<sbyte> ToSByteOrClamp(this Size<double> value) => new(value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size<sbyte> ToSByteOrClamp(this Size<decimal> value) => new(value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());

    public static Size<sbyte> ToSByteOrDefault(this Size<byte> value, sbyte defaultValue) => new(value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size<sbyte> ToSByteOrDefault(this Size<short> value, sbyte defaultValue) => new(value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size<sbyte> ToSByteOrDefault(this Size<ushort> value, sbyte defaultValue) => new(value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size<sbyte> ToSByteOrDefault(this Size<int> value, sbyte defaultValue) => new(value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size<sbyte> ToSByteOrDefault(this Size<uint> value, sbyte defaultValue) => new(value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size<sbyte> ToSByteOrDefault(this Size<long> value, sbyte defaultValue) => new(value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size<sbyte> ToSByteOrDefault(this Size<ulong> value, sbyte defaultValue) => new(value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size<sbyte> ToSByteOrDefault(this Size<float> value, sbyte defaultValue) => new(value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size<sbyte> ToSByteOrDefault(this Size<double> value, sbyte defaultValue) => new(value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size<sbyte> ToSByteOrDefault(this Size<decimal> value, sbyte defaultValue) => new(value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));

    public static Size<byte> ToByte(this Size<sbyte> value) => new((byte)value.Width, (byte)value.Height);
    public static Size<byte> ToByte(this Size<short> value) => new((byte)value.Width, (byte)value.Height);
    public static Size<byte> ToByte(this Size<ushort> value) => new((byte)value.Width, (byte)value.Height);
    public static Size<byte> ToByte(this Size<int> value) => new((byte)value.Width, (byte)value.Height);
    public static Size<byte> ToByte(this Size<uint> value) => new((byte)value.Width, (byte)value.Height);
    public static Size<byte> ToByte(this Size<long> value) => new((byte)value.Width, (byte)value.Height);
    public static Size<byte> ToByte(this Size<ulong> value) => new((byte)value.Width, (byte)value.Height);
    public static Size<byte> ToByte(this Size<float> value) => new((byte)value.Width, (byte)value.Height);
    public static Size<byte> ToByte(this Size<double> value) => new((byte)value.Width, (byte)value.Height);
    public static Size<byte> ToByte(this Size<decimal> value) => new((byte)value.Width, (byte)value.Height);

    public static Size<byte> ToByteOrClamp(this Size<sbyte> value) => new(value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size<byte> ToByteOrClamp(this Size<short> value) => new(value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size<byte> ToByteOrClamp(this Size<ushort> value) => new(value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size<byte> ToByteOrClamp(this Size<int> value) => new(value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size<byte> ToByteOrClamp(this Size<uint> value) => new(value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size<byte> ToByteOrClamp(this Size<long> value) => new(value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size<byte> ToByteOrClamp(this Size<ulong> value) => new(value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size<byte> ToByteOrClamp(this Size<float> value) => new(value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size<byte> ToByteOrClamp(this Size<double> value) => new(value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size<byte> ToByteOrClamp(this Size<decimal> value) => new(value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());

    public static Size<byte> ToByteOrDefault(this Size<sbyte> value, byte defaultValue) => new(value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size<byte> ToByteOrDefault(this Size<short> value, byte defaultValue) => new(value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size<byte> ToByteOrDefault(this Size<ushort> value, byte defaultValue) => new(value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size<byte> ToByteOrDefault(this Size<int> value, byte defaultValue) => new(value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size<byte> ToByteOrDefault(this Size<uint> value, byte defaultValue) => new(value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size<byte> ToByteOrDefault(this Size<long> value, byte defaultValue) => new(value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size<byte> ToByteOrDefault(this Size<ulong> value, byte defaultValue) => new(value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size<byte> ToByteOrDefault(this Size<float> value, byte defaultValue) => new(value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size<byte> ToByteOrDefault(this Size<double> value, byte defaultValue) => new(value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size<byte> ToByteOrDefault(this Size<decimal> value, byte defaultValue) => new(value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));

    public static Size<short> ToShort(this Size<sbyte> value) => new(value.Width, value.Height);
    public static Size<short> ToShort(this Size<byte> value) => new(value.Width, value.Height);
    public static Size<short> ToShort(this Size<ushort> value) => new((short)value.Width, (short)value.Height);
    public static Size<short> ToShort(this Size<int> value) => new((short)value.Width, (short)value.Height);
    public static Size<short> ToShort(this Size<uint> value) => new((short)value.Width, (short)value.Height);
    public static Size<short> ToShort(this Size<long> value) => new((short)value.Width, (short)value.Height);
    public static Size<short> ToShort(this Size<ulong> value) => new((short)value.Width, (short)value.Height);
    public static Size<short> ToShort(this Size<float> value) => new((short)value.Width, (short)value.Height);
    public static Size<short> ToShort(this Size<double> value) => new((short)value.Width, (short)value.Height);
    public static Size<short> ToShort(this Size<decimal> value) => new((short)value.Width, (short)value.Height);

    public static Size<short> ToShortOrClamp(this Size<ushort> value) => new(value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size<short> ToShortOrClamp(this Size<int> value) => new(value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size<short> ToShortOrClamp(this Size<uint> value) => new(value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size<short> ToShortOrClamp(this Size<long> value) => new(value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size<short> ToShortOrClamp(this Size<ulong> value) => new(value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size<short> ToShortOrClamp(this Size<float> value) => new(value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size<short> ToShortOrClamp(this Size<double> value) => new(value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size<short> ToShortOrClamp(this Size<decimal> value) => new(value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());

    public static Size<short> ToShortOrDefault(this Size<ushort> value, short defaultValue) => new(value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size<short> ToShortOrDefault(this Size<int> value, short defaultValue) => new(value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size<short> ToShortOrDefault(this Size<uint> value, short defaultValue) => new(value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size<short> ToShortOrDefault(this Size<long> value, short defaultValue) => new(value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size<short> ToShortOrDefault(this Size<ulong> value, short defaultValue) => new(value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size<short> ToShortOrDefault(this Size<float> value, short defaultValue) => new(value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size<short> ToShortOrDefault(this Size<double> value, short defaultValue) => new(value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size<short> ToShortOrDefault(this Size<decimal> value, short defaultValue) => new(value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));

    public static Size<ushort> ToUShort(this Size<sbyte> value) => new((ushort)value.Width, (ushort)value.Height);
    public static Size<ushort> ToUShort(this Size<byte> value) => new(value.Width, value.Height);
    public static Size<ushort> ToUShort(this Size<short> value) => new((ushort)value.Width, (ushort)value.Height);
    public static Size<ushort> ToUShort(this Size<int> value) => new((ushort)value.Width, (ushort)value.Height);
    public static Size<ushort> ToUShort(this Size<uint> value) => new((ushort)value.Width, (ushort)value.Height);
    public static Size<ushort> ToUShort(this Size<long> value) => new((ushort)value.Width, (ushort)value.Height);
    public static Size<ushort> ToUShort(this Size<ulong> value) => new((ushort)value.Width, (ushort)value.Height);
    public static Size<ushort> ToUShort(this Size<float> value) => new((ushort)value.Width, (ushort)value.Height);
    public static Size<ushort> ToUShort(this Size<double> value) => new((ushort)value.Width, (ushort)value.Height);
    public static Size<ushort> ToUShort(this Size<decimal> value) => new((ushort)value.Width, (ushort)value.Height);

    public static Size<ushort> ToUShortOrClamp(this Size<sbyte> value) => new(value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size<ushort> ToUShortOrClamp(this Size<short> value) => new(value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size<ushort> ToUShortOrClamp(this Size<int> value) => new(value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size<ushort> ToUShortOrClamp(this Size<uint> value) => new(value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size<ushort> ToUShortOrClamp(this Size<long> value) => new(value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size<ushort> ToUShortOrClamp(this Size<ulong> value) => new(value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size<ushort> ToUShortOrClamp(this Size<float> value) => new(value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size<ushort> ToUShortOrClamp(this Size<double> value) => new(value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size<ushort> ToUShortOrClamp(this Size<decimal> value) => new(value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());

    public static Size<ushort> ToUShortOrDefault(this Size<sbyte> value, ushort defaultValue) => new(value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size<ushort> ToUShortOrDefault(this Size<short> value, ushort defaultValue) => new(value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size<ushort> ToUShortOrDefault(this Size<int> value, ushort defaultValue) => new(value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size<ushort> ToUShortOrDefault(this Size<uint> value, ushort defaultValue) => new(value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size<ushort> ToUShortOrDefault(this Size<long> value, ushort defaultValue) => new(value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size<ushort> ToUShortOrDefault(this Size<ulong> value, ushort defaultValue) => new(value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size<ushort> ToUShortOrDefault(this Size<float> value, ushort defaultValue) => new(value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size<ushort> ToUShortOrDefault(this Size<double> value, ushort defaultValue) => new(value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size<ushort> ToUShortOrDefault(this Size<decimal> value, ushort defaultValue) => new(value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));

    public static Size<int> ToInt(this Size<sbyte> value) => new(value.Width, value.Height);
    public static Size<int> ToInt(this Size<byte> value) => new(value.Width, value.Height);
    public static Size<int> ToInt(this Size<short> value) => new(value.Width, value.Height);
    public static Size<int> ToInt(this Size<ushort> value) => new(value.Width, value.Height);
    public static Size<int> ToInt(this Size<uint> value) => new((int)value.Width, (int)value.Height);
    public static Size<int> ToInt(this Size<long> value) => new((int)value.Width, (int)value.Height);
    public static Size<int> ToInt(this Size<ulong> value) => new((int)value.Width, (int)value.Height);
    public static Size<int> ToInt(this Size<float> value) => new((int)value.Width, (int)value.Height);
    public static Size<int> ToInt(this Size<double> value) => new((int)value.Width, (int)value.Height);
    public static Size<int> ToInt(this Size<decimal> value) => new((int)value.Width, (int)value.Height);

    public static Size<int> ToIntOrClamp(this Size<uint> value) => new(value.Width.ToIntOrClamp(), value.Height.ToIntOrClamp());
    public static Size<int> ToIntOrClamp(this Size<long> value) => new(value.Width.ToIntOrClamp(), value.Height.ToIntOrClamp());
    public static Size<int> ToIntOrClamp(this Size<ulong> value) => new(value.Width.ToIntOrClamp(), value.Height.ToIntOrClamp());
    public static Size<int> ToIntOrClamp(this Size<float> value) => new(value.Width.ToIntOrClamp(), value.Height.ToIntOrClamp());
    public static Size<int> ToIntOrClamp(this Size<double> value) => new(value.Width.ToIntOrClamp(), value.Height.ToIntOrClamp());
    public static Size<int> ToIntOrClamp(this Size<decimal> value) => new(value.Width.ToIntOrClamp(), value.Height.ToIntOrClamp());

    public static Size<int> ToIntOrDefault(this Size<uint> value, int defaultValue) => new(value.Width.ToIntOrDefault(defaultValue), value.Height.ToIntOrDefault(defaultValue));
    public static Size<int> ToIntOrDefault(this Size<long> value, int defaultValue) => new(value.Width.ToIntOrDefault(defaultValue), value.Height.ToIntOrDefault(defaultValue));
    public static Size<int> ToIntOrDefault(this Size<ulong> value, int defaultValue) => new(value.Width.ToIntOrDefault(defaultValue), value.Height.ToIntOrDefault(defaultValue));
    public static Size<int> ToIntOrDefault(this Size<float> value, int defaultValue) => new(value.Width.ToIntOrDefault(defaultValue), value.Height.ToIntOrDefault(defaultValue));
    public static Size<int> ToIntOrDefault(this Size<double> value, int defaultValue) => new(value.Width.ToIntOrDefault(defaultValue), value.Height.ToIntOrDefault(defaultValue));
    public static Size<int> ToIntOrDefault(this Size<decimal> value, int defaultValue) => new(value.Width.ToIntOrDefault(defaultValue), value.Height.ToIntOrDefault(defaultValue));

    public static Size<uint> ToUInt(this Size<sbyte> value) => new((uint)value.Width, (uint)value.Height);
    public static Size<uint> ToUInt(this Size<byte> value) => new(value.Width, value.Height);
    public static Size<uint> ToUInt(this Size<short> value) => new((uint)value.Width, (uint)value.Height);
    public static Size<uint> ToUInt(this Size<ushort> value) => new(value.Width, value.Height);
    public static Size<uint> ToUInt(this Size<int> value) => new((uint)value.Width, (uint)value.Height);
    public static Size<uint> ToUInt(this Size<long> value) => new((uint)value.Width, (uint)value.Height);
    public static Size<uint> ToUInt(this Size<ulong> value) => new((uint)value.Width, (uint)value.Height);
    public static Size<uint> ToUInt(this Size<float> value) => new((uint)value.Width, (uint)value.Height);
    public static Size<uint> ToUInt(this Size<double> value) => new((uint)value.Width, (uint)value.Height);
    public static Size<uint> ToUInt(this Size<decimal> value) => new((uint)value.Width, (uint)value.Height);

    public static Size<uint> ToUIntOrClamp(this Size<sbyte> value) => new(value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size<uint> ToUIntOrClamp(this Size<short> value) => new(value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size<uint> ToUIntOrClamp(this Size<int> value) => new(value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size<uint> ToUIntOrClamp(this Size<long> value) => new(value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size<uint> ToUIntOrClamp(this Size<ulong> value) => new(value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size<uint> ToUIntOrClamp(this Size<float> value) => new(value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size<uint> ToUIntOrClamp(this Size<double> value) => new(value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size<uint> ToUIntOrClamp(this Size<decimal> value) => new(value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());

    public static Size<uint> ToUIntOrDefault(this Size<sbyte> value, uint defaultValue) => new(value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size<uint> ToUIntOrDefault(this Size<short> value, uint defaultValue) => new(value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size<uint> ToUIntOrDefault(this Size<int> value, uint defaultValue) => new(value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size<uint> ToUIntOrDefault(this Size<long> value, uint defaultValue) => new(value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size<uint> ToUIntOrDefault(this Size<ulong> value, uint defaultValue) => new(value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size<uint> ToUIntOrDefault(this Size<float> value, uint defaultValue) => new(value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size<uint> ToUIntOrDefault(this Size<double> value, uint defaultValue) => new(value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size<uint> ToUIntOrDefault(this Size<decimal> value, uint defaultValue) => new(value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));

    public static Size<long> ToLong(this Size<sbyte> value) => new(value.Width, value.Height);
    public static Size<long> ToLong(this Size<byte> value) => new(value.Width, value.Height);
    public static Size<long> ToLong(this Size<short> value) => new(value.Width, value.Height);
    public static Size<long> ToLong(this Size<ushort> value) => new(value.Width, value.Height);
    public static Size<long> ToLong(this Size<int> value) => new(value.Width, value.Height);
    public static Size<long> ToLong(this Size<uint> value) => new(value.Width, value.Height);
    public static Size<long> ToLong(this Size<ulong> value) => new((long)value.Width, (long)value.Height);
    public static Size<long> ToLong(this Size<float> value) => new((long)value.Width, (long)value.Height);
    public static Size<long> ToLong(this Size<double> value) => new((long)value.Width, (long)value.Height);
    public static Size<long> ToLong(this Size<decimal> value) => new((long)value.Width, (long)value.Height);

    public static Size<long> ToLongOrClamp(this Size<ulong> value) => new(value.Width.ToLongOrClamp(), value.Height.ToLongOrClamp());
    public static Size<long> ToLongOrClamp(this Size<float> value) => new(value.Width.ToLongOrClamp(), value.Height.ToLongOrClamp());
    public static Size<long> ToLongOrClamp(this Size<double> value) => new(value.Width.ToLongOrClamp(), value.Height.ToLongOrClamp());
    public static Size<long> ToLongOrClamp(this Size<decimal> value) => new(value.Width.ToLongOrClamp(), value.Height.ToLongOrClamp());

    public static Size<long> ToLongOrDefault(this Size<ulong> value, long defaultValue) => new(value.Width.ToLongOrDefault(defaultValue), value.Height.ToLongOrDefault(defaultValue));
    public static Size<long> ToLongOrDefault(this Size<float> value, long defaultValue) => new(value.Width.ToLongOrDefault(defaultValue), value.Height.ToLongOrDefault(defaultValue));
    public static Size<long> ToLongOrDefault(this Size<double> value, long defaultValue) => new(value.Width.ToLongOrDefault(defaultValue), value.Height.ToLongOrDefault(defaultValue));
    public static Size<long> ToLongOrDefault(this Size<decimal> value, long defaultValue) => new(value.Width.ToLongOrDefault(defaultValue), value.Height.ToLongOrDefault(defaultValue));

    public static Size<ulong> ToULong(this Size<sbyte> value) => new((ulong)value.Width, (ulong)value.Height);
    public static Size<ulong> ToULong(this Size<byte> value) => new(value.Width, value.Height);
    public static Size<ulong> ToULong(this Size<short> value) => new((ulong)value.Width, (ulong)value.Height);
    public static Size<ulong> ToULong(this Size<ushort> value) => new(value.Width, value.Height);
    public static Size<ulong> ToULong(this Size<int> value) => new((ulong)value.Width, (ulong)value.Height);
    public static Size<ulong> ToULong(this Size<uint> value) => new(value.Width, value.Height);
    public static Size<ulong> ToULong(this Size<long> value) => new((ulong)value.Width, (ulong)value.Height);
    public static Size<ulong> ToULong(this Size<float> value) => new((ulong)value.Width, (ulong)value.Height);
    public static Size<ulong> ToULong(this Size<double> value) => new((ulong)value.Width, (ulong)value.Height);
    public static Size<ulong> ToULong(this Size<decimal> value) => new((ulong)value.Width, (ulong)value.Height);

    public static Size<ulong> ToULongOrClamp(this Size<sbyte> value) => new(value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());
    public static Size<ulong> ToULongOrClamp(this Size<short> value) => new(value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());
    public static Size<ulong> ToULongOrClamp(this Size<int> value) => new(value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());
    public static Size<ulong> ToULongOrClamp(this Size<long> value) => new(value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());
    public static Size<ulong> ToULongOrClamp(this Size<float> value) => new(value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());
    public static Size<ulong> ToULongOrClamp(this Size<double> value) => new(value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());
    public static Size<ulong> ToULongOrClamp(this Size<decimal> value) => new(value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());

    public static Size<ulong> ToULongOrDefault(this Size<sbyte> value, ulong defaultValue) => new(value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));
    public static Size<ulong> ToULongOrDefault(this Size<short> value, ulong defaultValue) => new(value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));
    public static Size<ulong> ToULongOrDefault(this Size<int> value, ulong defaultValue) => new(value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));
    public static Size<ulong> ToULongOrDefault(this Size<long> value, ulong defaultValue) => new(value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));
    public static Size<ulong> ToULongOrDefault(this Size<float> value, ulong defaultValue) => new(value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));
    public static Size<ulong> ToULongOrDefault(this Size<double> value, ulong defaultValue) => new(value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));
    public static Size<ulong> ToULongOrDefault(this Size<decimal> value, ulong defaultValue) => new(value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));

    public static Size<float> ToFloat(this Size<sbyte> value) => new(value.Width, value.Height);
    public static Size<float> ToFloat(this Size<byte> value) => new(value.Width, value.Height);
    public static Size<float> ToFloat(this Size<short> value) => new(value.Width, value.Height);
    public static Size<float> ToFloat(this Size<ushort> value) => new(value.Width, value.Height);
    public static Size<float> ToFloat(this Size<int> value) => new(value.Width, value.Height);
    public static Size<float> ToFloat(this Size<uint> value) => new(value.Width, value.Height);
    public static Size<float> ToFloat(this Size<long> value) => new(value.Width, value.Height);
    public static Size<float> ToFloat(this Size<ulong> value) => new(value.Width, value.Height);
    public static Size<float> ToFloat(this Size<double> value) => new((float)value.Width, (float)value.Height);
    public static Size<float> ToFloat(this Size<decimal> value) => new((float)value.Width, (float)value.Height);

    public static Size<float> ToFloatOrClamp(this Size<double> value) => new(value.Width.ToFloatOrClamp(), value.Height.ToFloatOrClamp());
    public static Size<float> ToFloatOrClamp(this Size<decimal> value) => new(value.Width.ToFloatOrClamp(), value.Height.ToFloatOrClamp());

    public static Size<float> ToFloatOrDefault(this Size<double> value, float defaultValue) => new(value.Width.ToFloatOrDefault(defaultValue), value.Height.ToFloatOrDefault(defaultValue));
    public static Size<float> ToFloatOrDefault(this Size<decimal> value, float defaultValue) => new(value.Width.ToFloatOrDefault(defaultValue), value.Height.ToFloatOrDefault(defaultValue));

    public static Size<double> ToDouble(this Size<sbyte> value) => new(value.Width, value.Height);
    public static Size<double> ToDouble(this Size<byte> value) => new(value.Width, value.Height);
    public static Size<double> ToDouble(this Size<short> value) => new(value.Width, value.Height);
    public static Size<double> ToDouble(this Size<ushort> value) => new(value.Width, value.Height);
    public static Size<double> ToDouble(this Size<int> value) => new(value.Width, value.Height);
    public static Size<double> ToDouble(this Size<uint> value) => new(value.Width, value.Height);
    public static Size<double> ToDouble(this Size<long> value) => new(value.Width, value.Height);
    public static Size<double> ToDouble(this Size<ulong> value) => new(value.Width, value.Height);
    public static Size<double> ToDouble(this Size<float> value) => new(value.Width, value.Height);
    public static Size<double> ToDouble(this Size<decimal> value) => new((double)value.Width, (double)value.Height);

    public static Size<double> ToDoubleOrClamp(this Size<decimal> value) => new(value.Width.ToDoubleOrClamp(), value.Height.ToDoubleOrClamp());

    public static Size<double> ToDoubleOrDefault(this Size<decimal> value, double defaultValue) => new(value.Width.ToDoubleOrDefault(defaultValue), value.Height.ToDoubleOrDefault(defaultValue));

    public static Size<decimal> ToDecimal(this Size<sbyte> value) => new(value.Width, value.Height);
    public static Size<decimal> ToDecimal(this Size<byte> value) => new(value.Width, value.Height);
    public static Size<decimal> ToDecimal(this Size<short> value) => new(value.Width, value.Height);
    public static Size<decimal> ToDecimal(this Size<ushort> value) => new(value.Width, value.Height);
    public static Size<decimal> ToDecimal(this Size<int> value) => new(value.Width, value.Height);
    public static Size<decimal> ToDecimal(this Size<uint> value) => new(value.Width, value.Height);
    public static Size<decimal> ToDecimal(this Size<long> value) => new(value.Width, value.Height);
    public static Size<decimal> ToDecimal(this Size<ulong> value) => new(value.Width, value.Height);
    public static Size<decimal> ToDecimal(this Size<float> value) => new((decimal)value.Width, (decimal)value.Height);
    public static Size<decimal> ToDecimal(this Size<double> value) => new((decimal)value.Width, (decimal)value.Height);
}