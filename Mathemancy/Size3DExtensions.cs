namespace ToolBX.Mathemancy;

public static class Size3DExtensions
{
    public static Size3D<sbyte> ToSByte(this Size3D<byte> value) => new((sbyte)value.Length, (sbyte)value.Width, (sbyte)value.Height);
    public static Size3D<sbyte> ToSByte(this Size3D<short> value) => new((sbyte)value.Length, (sbyte)value.Width, (sbyte)value.Height);
    public static Size3D<sbyte> ToSByte(this Size3D<ushort> value) => new((sbyte)value.Length, (sbyte)value.Width, (sbyte)value.Height);
    public static Size3D<sbyte> ToSByte(this Size3D<int> value) => new((sbyte)value.Length, (sbyte)value.Width, (sbyte)value.Height);
    public static Size3D<sbyte> ToSByte(this Size3D<uint> value) => new((sbyte)value.Length, (sbyte)value.Width, (sbyte)value.Height);
    public static Size3D<sbyte> ToSByte(this Size3D<long> value) => new((sbyte)value.Length, (sbyte)value.Width, (sbyte)value.Height);
    public static Size3D<sbyte> ToSByte(this Size3D<ulong> value) => new((sbyte)value.Length, (sbyte)value.Width, (sbyte)value.Height);
    public static Size3D<sbyte> ToSByte(this Size3D<float> value) => new((sbyte)value.Length, (sbyte)value.Width, (sbyte)value.Height);
    public static Size3D<sbyte> ToSByte(this Size3D<double> value) => new((sbyte)value.Length, (sbyte)value.Width, (sbyte)value.Height);
    public static Size3D<sbyte> ToSByte(this Size3D<decimal> value) => new((sbyte)value.Length, (sbyte)value.Width, (sbyte)value.Height);

    public static Size3D<sbyte> ToSByteOrClamp(this Size3D<byte> value) => new(value.Length.ToSByteOrClamp(), value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size3D<sbyte> ToSByteOrClamp(this Size3D<short> value) => new(value.Length.ToSByteOrClamp(), value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size3D<sbyte> ToSByteOrClamp(this Size3D<ushort> value) => new(value.Length.ToSByteOrClamp(), value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size3D<sbyte> ToSByteOrClamp(this Size3D<int> value) => new(value.Length.ToSByteOrClamp(), value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size3D<sbyte> ToSByteOrClamp(this Size3D<uint> value) => new(value.Length.ToSByteOrClamp(), value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size3D<sbyte> ToSByteOrClamp(this Size3D<long> value) => new(value.Length.ToSByteOrClamp(), value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size3D<sbyte> ToSByteOrClamp(this Size3D<ulong> value) => new(value.Length.ToSByteOrClamp(), value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size3D<sbyte> ToSByteOrClamp(this Size3D<float> value) => new(value.Length.ToSByteOrClamp(), value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size3D<sbyte> ToSByteOrClamp(this Size3D<double> value) => new(value.Length.ToSByteOrClamp(), value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());
    public static Size3D<sbyte> ToSByteOrClamp(this Size3D<decimal> value) => new(value.Length.ToSByteOrClamp(), value.Width.ToSByteOrClamp(), value.Height.ToSByteOrClamp());

    public static Size3D<sbyte> ToSByteOrDefault(this Size3D<byte> value, sbyte defaultValue) => new(value.Length.ToSByteOrDefault(defaultValue), value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size3D<sbyte> ToSByteOrDefault(this Size3D<short> value, sbyte defaultValue) => new(value.Length.ToSByteOrDefault(defaultValue), value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size3D<sbyte> ToSByteOrDefault(this Size3D<ushort> value, sbyte defaultValue) => new(value.Length.ToSByteOrDefault(defaultValue), value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size3D<sbyte> ToSByteOrDefault(this Size3D<int> value, sbyte defaultValue) => new(value.Length.ToSByteOrDefault(defaultValue), value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size3D<sbyte> ToSByteOrDefault(this Size3D<uint> value, sbyte defaultValue) => new(value.Length.ToSByteOrDefault(defaultValue), value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size3D<sbyte> ToSByteOrDefault(this Size3D<long> value, sbyte defaultValue) => new(value.Length.ToSByteOrDefault(defaultValue), value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size3D<sbyte> ToSByteOrDefault(this Size3D<ulong> value, sbyte defaultValue) => new(value.Length.ToSByteOrDefault(defaultValue), value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size3D<sbyte> ToSByteOrDefault(this Size3D<float> value, sbyte defaultValue) => new(value.Length.ToSByteOrDefault(defaultValue), value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size3D<sbyte> ToSByteOrDefault(this Size3D<double> value, sbyte defaultValue) => new(value.Length.ToSByteOrDefault(defaultValue), value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));
    public static Size3D<sbyte> ToSByteOrDefault(this Size3D<decimal> value, sbyte defaultValue) => new(value.Length.ToSByteOrDefault(defaultValue), value.Width.ToSByteOrDefault(defaultValue), value.Height.ToSByteOrDefault(defaultValue));

    public static Size3D<byte> ToByte(this Size3D<sbyte> value) => new((byte)value.Length, (byte)value.Width, (byte)value.Height);
    public static Size3D<byte> ToByte(this Size3D<short> value) => new((byte)value.Length, (byte)value.Width, (byte)value.Height);
    public static Size3D<byte> ToByte(this Size3D<ushort> value) => new((byte)value.Length, (byte)value.Width, (byte)value.Height);
    public static Size3D<byte> ToByte(this Size3D<int> value) => new((byte)value.Length, (byte)value.Width, (byte)value.Height);
    public static Size3D<byte> ToByte(this Size3D<uint> value) => new((byte)value.Length, (byte)value.Width, (byte)value.Height);
    public static Size3D<byte> ToByte(this Size3D<long> value) => new((byte)value.Length, (byte)value.Width, (byte)value.Height);
    public static Size3D<byte> ToByte(this Size3D<ulong> value) => new((byte)value.Length, (byte)value.Width, (byte)value.Height);
    public static Size3D<byte> ToByte(this Size3D<float> value) => new((byte)value.Length, (byte)value.Width, (byte)value.Height);
    public static Size3D<byte> ToByte(this Size3D<double> value) => new((byte)value.Length, (byte)value.Width, (byte)value.Height);
    public static Size3D<byte> ToByte(this Size3D<decimal> value) => new((byte)value.Length, (byte)value.Width, (byte)value.Height);

    public static Size3D<byte> ToByteOrClamp(this Size3D<sbyte> value) => new(value.Length.ToByteOrClamp(), value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size3D<byte> ToByteOrClamp(this Size3D<short> value) => new(value.Length.ToByteOrClamp(), value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size3D<byte> ToByteOrClamp(this Size3D<ushort> value) => new(value.Length.ToByteOrClamp(), value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size3D<byte> ToByteOrClamp(this Size3D<int> value) => new(value.Length.ToByteOrClamp(), value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size3D<byte> ToByteOrClamp(this Size3D<uint> value) => new(value.Length.ToByteOrClamp(), value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size3D<byte> ToByteOrClamp(this Size3D<long> value) => new(value.Length.ToByteOrClamp(), value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size3D<byte> ToByteOrClamp(this Size3D<ulong> value) => new(value.Length.ToByteOrClamp(), value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size3D<byte> ToByteOrClamp(this Size3D<float> value) => new(value.Length.ToByteOrClamp(), value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size3D<byte> ToByteOrClamp(this Size3D<double> value) => new(value.Length.ToByteOrClamp(), value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());
    public static Size3D<byte> ToByteOrClamp(this Size3D<decimal> value) => new(value.Length.ToByteOrClamp(), value.Width.ToByteOrClamp(), value.Height.ToByteOrClamp());

    public static Size3D<byte> ToByteOrDefault(this Size3D<sbyte> value, byte defaultValue) => new(value.Length.ToByteOrDefault(defaultValue), value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size3D<byte> ToByteOrDefault(this Size3D<short> value, byte defaultValue) => new(value.Length.ToByteOrDefault(defaultValue), value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size3D<byte> ToByteOrDefault(this Size3D<ushort> value, byte defaultValue) => new(value.Length.ToByteOrDefault(defaultValue), value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size3D<byte> ToByteOrDefault(this Size3D<int> value, byte defaultValue) => new(value.Length.ToByteOrDefault(defaultValue), value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size3D<byte> ToByteOrDefault(this Size3D<uint> value, byte defaultValue) => new(value.Length.ToByteOrDefault(defaultValue), value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size3D<byte> ToByteOrDefault(this Size3D<long> value, byte defaultValue) => new(value.Length.ToByteOrDefault(defaultValue), value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size3D<byte> ToByteOrDefault(this Size3D<ulong> value, byte defaultValue) => new(value.Length.ToByteOrDefault(defaultValue), value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size3D<byte> ToByteOrDefault(this Size3D<float> value, byte defaultValue) => new(value.Length.ToByteOrDefault(defaultValue), value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size3D<byte> ToByteOrDefault(this Size3D<double> value, byte defaultValue) => new(value.Length.ToByteOrDefault(defaultValue), value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));
    public static Size3D<byte> ToByteOrDefault(this Size3D<decimal> value, byte defaultValue) => new(value.Length.ToByteOrDefault(defaultValue), value.Width.ToByteOrDefault(defaultValue), value.Height.ToByteOrDefault(defaultValue));

    public static Size3D<short> ToShort(this Size3D<sbyte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<short> ToShort(this Size3D<byte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<short> ToShort(this Size3D<ushort> value) => new((short)value.Length, (short)value.Width, (short)value.Height);
    public static Size3D<short> ToShort(this Size3D<int> value) => new((short)value.Length, (short)value.Width, (short)value.Height);
    public static Size3D<short> ToShort(this Size3D<uint> value) => new((short)value.Length, (short)value.Width, (short)value.Height);
    public static Size3D<short> ToShort(this Size3D<long> value) => new((short)value.Length, (short)value.Width, (short)value.Height);
    public static Size3D<short> ToShort(this Size3D<ulong> value) => new((short)value.Length, (short)value.Width, (short)value.Height);
    public static Size3D<short> ToShort(this Size3D<float> value) => new((short)value.Length, (short)value.Width, (short)value.Height);
    public static Size3D<short> ToShort(this Size3D<double> value) => new((short)value.Length, (short)value.Width, (short)value.Height);
    public static Size3D<short> ToShort(this Size3D<decimal> value) => new((short)value.Length, (short)value.Width, (short)value.Height);

    public static Size3D<short> ToShortOrClamp(this Size3D<ushort> value) => new(value.Length.ToShortOrClamp(), value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size3D<short> ToShortOrClamp(this Size3D<int> value) => new(value.Length.ToShortOrClamp(), value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size3D<short> ToShortOrClamp(this Size3D<uint> value) => new(value.Length.ToShortOrClamp(), value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size3D<short> ToShortOrClamp(this Size3D<long> value) => new(value.Length.ToShortOrClamp(), value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size3D<short> ToShortOrClamp(this Size3D<ulong> value) => new(value.Length.ToShortOrClamp(), value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size3D<short> ToShortOrClamp(this Size3D<float> value) => new(value.Length.ToShortOrClamp(), value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size3D<short> ToShortOrClamp(this Size3D<double> value) => new(value.Length.ToShortOrClamp(), value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());
    public static Size3D<short> ToShortOrClamp(this Size3D<decimal> value) => new(value.Length.ToShortOrClamp(), value.Width.ToShortOrClamp(), value.Height.ToShortOrClamp());

    public static Size3D<short> ToShortOrDefault(this Size3D<ushort> value, short defaultValue) => new(value.Length.ToShortOrDefault(defaultValue), value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size3D<short> ToShortOrDefault(this Size3D<int> value, short defaultValue) => new(value.Length.ToShortOrDefault(defaultValue), value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size3D<short> ToShortOrDefault(this Size3D<uint> value, short defaultValue) => new(value.Length.ToShortOrDefault(defaultValue), value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size3D<short> ToShortOrDefault(this Size3D<long> value, short defaultValue) => new(value.Length.ToShortOrDefault(defaultValue), value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size3D<short> ToShortOrDefault(this Size3D<ulong> value, short defaultValue) => new(value.Length.ToShortOrDefault(defaultValue), value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size3D<short> ToShortOrDefault(this Size3D<float> value, short defaultValue) => new(value.Length.ToShortOrDefault(defaultValue), value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size3D<short> ToShortOrDefault(this Size3D<double> value, short defaultValue) => new(value.Length.ToShortOrDefault(defaultValue), value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));
    public static Size3D<short> ToShortOrDefault(this Size3D<decimal> value, short defaultValue) => new(value.Length.ToShortOrDefault(defaultValue), value.Width.ToShortOrDefault(defaultValue), value.Height.ToShortOrDefault(defaultValue));

    public static Size3D<ushort> ToUShort(this Size3D<sbyte> value) => new((ushort)value.Length, (ushort)value.Width, (ushort)value.Height);
    public static Size3D<ushort> ToUShort(this Size3D<byte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<ushort> ToUShort(this Size3D<short> value) => new((ushort)value.Length, (ushort)value.Width, (ushort)value.Height);
    public static Size3D<ushort> ToUShort(this Size3D<int> value) => new((ushort)value.Length, (ushort)value.Width, (ushort)value.Height);
    public static Size3D<ushort> ToUShort(this Size3D<uint> value) => new((ushort)value.Length, (ushort)value.Width, (ushort)value.Height);
    public static Size3D<ushort> ToUShort(this Size3D<long> value) => new((ushort)value.Length, (ushort)value.Width, (ushort)value.Height);
    public static Size3D<ushort> ToUShort(this Size3D<ulong> value) => new((ushort)value.Length, (ushort)value.Width, (ushort)value.Height);
    public static Size3D<ushort> ToUShort(this Size3D<float> value) => new((ushort)value.Length, (ushort)value.Width, (ushort)value.Height);
    public static Size3D<ushort> ToUShort(this Size3D<double> value) => new((ushort)value.Length, (ushort)value.Width, (ushort)value.Height);
    public static Size3D<ushort> ToUShort(this Size3D<decimal> value) => new((ushort)value.Length, (ushort)value.Width, (ushort)value.Height);

    public static Size3D<ushort> ToUShortOrClamp(this Size3D<sbyte> value) => new(value.Length.ToUShortOrClamp(), value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size3D<ushort> ToUShortOrClamp(this Size3D<short> value) => new(value.Length.ToUShortOrClamp(), value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size3D<ushort> ToUShortOrClamp(this Size3D<int> value) => new(value.Length.ToUShortOrClamp(), value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size3D<ushort> ToUShortOrClamp(this Size3D<uint> value) => new(value.Length.ToUShortOrClamp(), value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size3D<ushort> ToUShortOrClamp(this Size3D<long> value) => new(value.Length.ToUShortOrClamp(), value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size3D<ushort> ToUShortOrClamp(this Size3D<ulong> value) => new(value.Length.ToUShortOrClamp(), value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size3D<ushort> ToUShortOrClamp(this Size3D<float> value) => new(value.Length.ToUShortOrClamp(), value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size3D<ushort> ToUShortOrClamp(this Size3D<double> value) => new(value.Length.ToUShortOrClamp(), value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());
    public static Size3D<ushort> ToUShortOrClamp(this Size3D<decimal> value) => new(value.Length.ToUShortOrClamp(), value.Width.ToUShortOrClamp(), value.Height.ToUShortOrClamp());

    public static Size3D<ushort> ToUShortOrDefault(this Size3D<sbyte> value, ushort defaultValue) => new(value.Length.ToUShortOrDefault(defaultValue), value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size3D<ushort> ToUShortOrDefault(this Size3D<short> value, ushort defaultValue) => new(value.Length.ToUShortOrDefault(defaultValue), value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size3D<ushort> ToUShortOrDefault(this Size3D<int> value, ushort defaultValue) => new(value.Length.ToUShortOrDefault(defaultValue), value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size3D<ushort> ToUShortOrDefault(this Size3D<uint> value, ushort defaultValue) => new(value.Length.ToUShortOrDefault(defaultValue), value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size3D<ushort> ToUShortOrDefault(this Size3D<long> value, ushort defaultValue) => new(value.Length.ToUShortOrDefault(defaultValue), value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size3D<ushort> ToUShortOrDefault(this Size3D<ulong> value, ushort defaultValue) => new(value.Length.ToUShortOrDefault(defaultValue), value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size3D<ushort> ToUShortOrDefault(this Size3D<float> value, ushort defaultValue) => new(value.Length.ToUShortOrDefault(defaultValue), value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size3D<ushort> ToUShortOrDefault(this Size3D<double> value, ushort defaultValue) => new(value.Length.ToUShortOrDefault(defaultValue), value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));
    public static Size3D<ushort> ToUShortOrDefault(this Size3D<decimal> value, ushort defaultValue) => new(value.Length.ToUShortOrDefault(defaultValue), value.Width.ToUShortOrDefault(defaultValue), value.Height.ToUShortOrDefault(defaultValue));

    public static Size3D<int> ToInt(this Size3D<sbyte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<int> ToInt(this Size3D<byte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<int> ToInt(this Size3D<short> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<int> ToInt(this Size3D<ushort> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<int> ToInt(this Size3D<uint> value) => new((int)value.Length, (int)value.Width, (int)value.Height);
    public static Size3D<int> ToInt(this Size3D<long> value) => new((int)value.Length, (int)value.Width, (int)value.Height);
    public static Size3D<int> ToInt(this Size3D<ulong> value) => new((int)value.Length, (int)value.Width, (int)value.Height);
    public static Size3D<int> ToInt(this Size3D<float> value) => new((int)value.Length, (int)value.Width, (int)value.Height);
    public static Size3D<int> ToInt(this Size3D<double> value) => new((int)value.Length, (int)value.Width, (int)value.Height);
    public static Size3D<int> ToInt(this Size3D<decimal> value) => new((int)value.Length, (int)value.Width, (int)value.Height);

    public static Size3D<int> ToIntOrClamp(this Size3D<uint> value) => new(value.Length.ToIntOrClamp(), value.Width.ToIntOrClamp(), value.Height.ToIntOrClamp());
    public static Size3D<int> ToIntOrClamp(this Size3D<long> value) => new(value.Length.ToIntOrClamp(), value.Width.ToIntOrClamp(), value.Height.ToIntOrClamp());
    public static Size3D<int> ToIntOrClamp(this Size3D<ulong> value) => new(value.Length.ToIntOrClamp(), value.Width.ToIntOrClamp(), value.Height.ToIntOrClamp());
    public static Size3D<int> ToIntOrClamp(this Size3D<float> value) => new(value.Length.ToIntOrClamp(), value.Width.ToIntOrClamp(), value.Height.ToIntOrClamp());
    public static Size3D<int> ToIntOrClamp(this Size3D<double> value) => new(value.Length.ToIntOrClamp(), value.Width.ToIntOrClamp(), value.Height.ToIntOrClamp());
    public static Size3D<int> ToIntOrClamp(this Size3D<decimal> value) => new(value.Length.ToIntOrClamp(), value.Width.ToIntOrClamp(), value.Height.ToIntOrClamp());

    public static Size3D<int> ToIntOrDefault(this Size3D<uint> value, int defaultValue) => new(value.Length.ToIntOrDefault(defaultValue), value.Width.ToIntOrDefault(defaultValue), value.Height.ToIntOrDefault(defaultValue));
    public static Size3D<int> ToIntOrDefault(this Size3D<long> value, int defaultValue) => new(value.Length.ToIntOrDefault(defaultValue), value.Width.ToIntOrDefault(defaultValue), value.Height.ToIntOrDefault(defaultValue));
    public static Size3D<int> ToIntOrDefault(this Size3D<ulong> value, int defaultValue) => new(value.Length.ToIntOrDefault(defaultValue), value.Width.ToIntOrDefault(defaultValue), value.Height.ToIntOrDefault(defaultValue));
    public static Size3D<int> ToIntOrDefault(this Size3D<float> value, int defaultValue) => new(value.Length.ToIntOrDefault(defaultValue), value.Width.ToIntOrDefault(defaultValue), value.Height.ToIntOrDefault(defaultValue));
    public static Size3D<int> ToIntOrDefault(this Size3D<double> value, int defaultValue) => new(value.Length.ToIntOrDefault(defaultValue), value.Width.ToIntOrDefault(defaultValue), value.Height.ToIntOrDefault(defaultValue));
    public static Size3D<int> ToIntOrDefault(this Size3D<decimal> value, int defaultValue) => new(value.Length.ToIntOrDefault(defaultValue), value.Width.ToIntOrDefault(defaultValue), value.Height.ToIntOrDefault(defaultValue));

    public static Size3D<uint> ToUInt(this Size3D<sbyte> value) => new((uint)value.Length, (uint)value.Width, (uint)value.Height);
    public static Size3D<uint> ToUInt(this Size3D<byte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<uint> ToUInt(this Size3D<short> value) => new((uint)value.Length, (uint)value.Width, (uint)value.Height);
    public static Size3D<uint> ToUInt(this Size3D<ushort> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<uint> ToUInt(this Size3D<int> value) => new((uint)value.Length, (uint)value.Width, (uint)value.Height);
    public static Size3D<uint> ToUInt(this Size3D<long> value) => new((uint)value.Length, (uint)value.Width, (uint)value.Height);
    public static Size3D<uint> ToUInt(this Size3D<ulong> value) => new((uint)value.Length, (uint)value.Width, (uint)value.Height);
    public static Size3D<uint> ToUInt(this Size3D<float> value) => new((uint)value.Length, (uint)value.Width, (uint)value.Height);
    public static Size3D<uint> ToUInt(this Size3D<double> value) => new((uint)value.Length, (uint)value.Width, (uint)value.Height);
    public static Size3D<uint> ToUInt(this Size3D<decimal> value) => new((uint)value.Length, (uint)value.Width, (uint)value.Height);

    public static Size3D<uint> ToUIntOrClamp(this Size3D<sbyte> value) => new(value.Length.ToUIntOrClamp(), value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size3D<uint> ToUIntOrClamp(this Size3D<short> value) => new(value.Length.ToUIntOrClamp(), value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size3D<uint> ToUIntOrClamp(this Size3D<int> value) => new(value.Length.ToUIntOrClamp(), value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size3D<uint> ToUIntOrClamp(this Size3D<long> value) => new(value.Length.ToUIntOrClamp(), value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size3D<uint> ToUIntOrClamp(this Size3D<ulong> value) => new(value.Length.ToUIntOrClamp(), value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size3D<uint> ToUIntOrClamp(this Size3D<float> value) => new(value.Length.ToUIntOrClamp(), value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size3D<uint> ToUIntOrClamp(this Size3D<double> value) => new(value.Length.ToUIntOrClamp(), value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());
    public static Size3D<uint> ToUIntOrClamp(this Size3D<decimal> value) => new(value.Length.ToUIntOrClamp(), value.Width.ToUIntOrClamp(), value.Height.ToUIntOrClamp());

    public static Size3D<uint> ToUIntOrDefault(this Size3D<sbyte> value, uint defaultValue) => new(value.Length.ToUIntOrDefault(defaultValue), value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size3D<uint> ToUIntOrDefault(this Size3D<short> value, uint defaultValue) => new(value.Length.ToUIntOrDefault(defaultValue), value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size3D<uint> ToUIntOrDefault(this Size3D<int> value, uint defaultValue) => new(value.Length.ToUIntOrDefault(defaultValue), value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size3D<uint> ToUIntOrDefault(this Size3D<long> value, uint defaultValue) => new(value.Length.ToUIntOrDefault(defaultValue), value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size3D<uint> ToUIntOrDefault(this Size3D<ulong> value, uint defaultValue) => new(value.Length.ToUIntOrDefault(defaultValue), value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size3D<uint> ToUIntOrDefault(this Size3D<float> value, uint defaultValue) => new(value.Length.ToUIntOrDefault(defaultValue), value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size3D<uint> ToUIntOrDefault(this Size3D<double> value, uint defaultValue) => new(value.Length.ToUIntOrDefault(defaultValue), value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));
    public static Size3D<uint> ToUIntOrDefault(this Size3D<decimal> value, uint defaultValue) => new(value.Length.ToUIntOrDefault(defaultValue), value.Width.ToUIntOrDefault(defaultValue), value.Height.ToUIntOrDefault(defaultValue));

    public static Size3D<long> ToLong(this Size3D<sbyte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<long> ToLong(this Size3D<byte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<long> ToLong(this Size3D<short> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<long> ToLong(this Size3D<ushort> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<long> ToLong(this Size3D<int> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<long> ToLong(this Size3D<uint> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<long> ToLong(this Size3D<ulong> value) => new((long)value.Length, (long)value.Width, (long)value.Height);
    public static Size3D<long> ToLong(this Size3D<float> value) => new((long)value.Length, (long)value.Width, (long)value.Height);
    public static Size3D<long> ToLong(this Size3D<double> value) => new((long)value.Length, (long)value.Width, (long)value.Height);
    public static Size3D<long> ToLong(this Size3D<decimal> value) => new((long)value.Length, (long)value.Width, (long)value.Height);

    public static Size3D<long> ToLongOrClamp(this Size3D<ulong> value) => new(value.Length.ToLongOrClamp(), value.Width.ToLongOrClamp(), value.Height.ToLongOrClamp());
    public static Size3D<long> ToLongOrClamp(this Size3D<float> value) => new(value.Length.ToLongOrClamp(), value.Width.ToLongOrClamp(), value.Height.ToLongOrClamp());
    public static Size3D<long> ToLongOrClamp(this Size3D<double> value) => new(value.Length.ToLongOrClamp(), value.Width.ToLongOrClamp(), value.Height.ToLongOrClamp());
    public static Size3D<long> ToLongOrClamp(this Size3D<decimal> value) => new(value.Length.ToLongOrClamp(), value.Width.ToLongOrClamp(), value.Height.ToLongOrClamp());

    public static Size3D<long> ToLongOrDefault(this Size3D<ulong> value, long defaultValue) => new(value.Length.ToLongOrDefault(defaultValue), value.Width.ToLongOrDefault(defaultValue), value.Height.ToLongOrDefault(defaultValue));
    public static Size3D<long> ToLongOrDefault(this Size3D<float> value, long defaultValue) => new(value.Length.ToLongOrDefault(defaultValue), value.Width.ToLongOrDefault(defaultValue), value.Height.ToLongOrDefault(defaultValue));
    public static Size3D<long> ToLongOrDefault(this Size3D<double> value, long defaultValue) => new(value.Length.ToLongOrDefault(defaultValue), value.Width.ToLongOrDefault(defaultValue), value.Height.ToLongOrDefault(defaultValue));
    public static Size3D<long> ToLongOrDefault(this Size3D<decimal> value, long defaultValue) => new(value.Length.ToLongOrDefault(defaultValue), value.Width.ToLongOrDefault(defaultValue), value.Height.ToLongOrDefault(defaultValue));

    public static Size3D<ulong> ToULong(this Size3D<sbyte> value) => new((ulong)value.Length, (ulong)value.Width, (ulong)value.Height);
    public static Size3D<ulong> ToULong(this Size3D<byte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<ulong> ToULong(this Size3D<short> value) => new((ulong)value.Length, (ulong)value.Width, (ulong)value.Height);
    public static Size3D<ulong> ToULong(this Size3D<ushort> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<ulong> ToULong(this Size3D<int> value) => new((ulong)value.Length, (ulong)value.Width, (ulong)value.Height);
    public static Size3D<ulong> ToULong(this Size3D<uint> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<ulong> ToULong(this Size3D<long> value) => new((ulong)value.Length, (ulong)value.Width, (ulong)value.Height);
    public static Size3D<ulong> ToULong(this Size3D<float> value) => new((ulong)value.Length, (ulong)value.Width, (ulong)value.Height);
    public static Size3D<ulong> ToULong(this Size3D<double> value) => new((ulong)value.Length, (ulong)value.Width, (ulong)value.Height);
    public static Size3D<ulong> ToULong(this Size3D<decimal> value) => new((ulong)value.Length, (ulong)value.Width, (ulong)value.Height);

    public static Size3D<ulong> ToULongOrClamp(this Size3D<sbyte> value) => new(value.Length.ToULongOrClamp(), value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());
    public static Size3D<ulong> ToULongOrClamp(this Size3D<short> value) => new(value.Length.ToULongOrClamp(), value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());
    public static Size3D<ulong> ToULongOrClamp(this Size3D<int> value) => new(value.Length.ToULongOrClamp(), value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());
    public static Size3D<ulong> ToULongOrClamp(this Size3D<long> value) => new(value.Length.ToULongOrClamp(), value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());
    public static Size3D<ulong> ToULongOrClamp(this Size3D<float> value) => new(value.Length.ToULongOrClamp(), value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());
    public static Size3D<ulong> ToULongOrClamp(this Size3D<double> value) => new(value.Length.ToULongOrClamp(), value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());
    public static Size3D<ulong> ToULongOrClamp(this Size3D<decimal> value) => new(value.Length.ToULongOrClamp(), value.Width.ToULongOrClamp(), value.Height.ToULongOrClamp());

    public static Size3D<ulong> ToULongOrDefault(this Size3D<sbyte> value, ulong defaultValue) => new(value.Length.ToULongOrDefault(defaultValue), value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));
    public static Size3D<ulong> ToULongOrDefault(this Size3D<short> value, ulong defaultValue) => new(value.Length.ToULongOrDefault(defaultValue), value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));
    public static Size3D<ulong> ToULongOrDefault(this Size3D<int> value, ulong defaultValue) => new(value.Length.ToULongOrDefault(defaultValue), value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));
    public static Size3D<ulong> ToULongOrDefault(this Size3D<long> value, ulong defaultValue) => new(value.Length.ToULongOrDefault(defaultValue), value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));
    public static Size3D<ulong> ToULongOrDefault(this Size3D<float> value, ulong defaultValue) => new(value.Length.ToULongOrDefault(defaultValue), value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));
    public static Size3D<ulong> ToULongOrDefault(this Size3D<double> value, ulong defaultValue) => new(value.Length.ToULongOrDefault(defaultValue), value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));
    public static Size3D<ulong> ToULongOrDefault(this Size3D<decimal> value, ulong defaultValue) => new(value.Length.ToULongOrDefault(defaultValue), value.Width.ToULongOrDefault(defaultValue), value.Height.ToULongOrDefault(defaultValue));

    public static Size3D<float> ToFloat(this Size3D<sbyte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<float> ToFloat(this Size3D<byte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<float> ToFloat(this Size3D<short> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<float> ToFloat(this Size3D<ushort> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<float> ToFloat(this Size3D<int> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<float> ToFloat(this Size3D<uint> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<float> ToFloat(this Size3D<long> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<float> ToFloat(this Size3D<ulong> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<float> ToFloat(this Size3D<double> value) => new((float)value.Length, (float)value.Width, (float)value.Height);
    public static Size3D<float> ToFloat(this Size3D<decimal> value) => new((float)value.Length, (float)value.Width, (float)value.Height);

    public static Size3D<float> ToFloatOrClamp(this Size3D<double> value) => new(value.Length.ToFloatOrClamp(), value.Width.ToFloatOrClamp(), value.Height.ToFloatOrClamp());
    public static Size3D<float> ToFloatOrClamp(this Size3D<decimal> value) => new(value.Length.ToFloatOrClamp(), value.Width.ToFloatOrClamp(), value.Height.ToFloatOrClamp());

    public static Size3D<float> ToFloatOrDefault(this Size3D<double> value, float defaultValue) => new(value.Length.ToFloatOrDefault(defaultValue), value.Width.ToFloatOrDefault(defaultValue), value.Height.ToFloatOrDefault(defaultValue));
    public static Size3D<float> ToFloatOrDefault(this Size3D<decimal> value, float defaultValue) => new(value.Length.ToFloatOrDefault(defaultValue), value.Width.ToFloatOrDefault(defaultValue), value.Height.ToFloatOrDefault(defaultValue));

    public static Size3D<double> ToDouble(this Size3D<sbyte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<double> ToDouble(this Size3D<byte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<double> ToDouble(this Size3D<short> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<double> ToDouble(this Size3D<ushort> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<double> ToDouble(this Size3D<int> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<double> ToDouble(this Size3D<uint> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<double> ToDouble(this Size3D<long> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<double> ToDouble(this Size3D<ulong> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<double> ToDouble(this Size3D<float> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<double> ToDouble(this Size3D<decimal> value) => new((double)value.Length, (double)value.Width, (double)value.Height);

    public static Size3D<double> ToDoubleOrClamp(this Size3D<decimal> value) => new(value.Length.ToDoubleOrClamp(), value.Width.ToDoubleOrClamp(), value.Height.ToDoubleOrClamp());

    public static Size3D<double> ToDoubleOrDefault(this Size3D<decimal> value, double defaultValue) => new(value.Length.ToDoubleOrDefault(defaultValue), value.Width.ToDoubleOrDefault(defaultValue), value.Height.ToDoubleOrDefault(defaultValue));

    public static Size3D<decimal> ToDecimal(this Size3D<sbyte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<decimal> ToDecimal(this Size3D<byte> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<decimal> ToDecimal(this Size3D<short> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<decimal> ToDecimal(this Size3D<ushort> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<decimal> ToDecimal(this Size3D<int> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<decimal> ToDecimal(this Size3D<uint> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<decimal> ToDecimal(this Size3D<long> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<decimal> ToDecimal(this Size3D<ulong> value) => new(value.Length, value.Width, value.Height);
    public static Size3D<decimal> ToDecimal(this Size3D<float> value) => new((decimal)value.Length, (decimal)value.Width, (decimal)value.Height);
    public static Size3D<decimal> ToDecimal(this Size3D<double> value) => new((decimal)value.Length, (decimal)value.Width, (decimal)value.Height);
}