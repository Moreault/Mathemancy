namespace ToolBX.Mathemancy;

public static class CuboidExtensions
{
    public static Cuboid<sbyte> ToSByte(this Cuboid<byte> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Cuboid<sbyte> ToSByte(this Cuboid<short> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Cuboid<sbyte> ToSByte(this Cuboid<ushort> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Cuboid<sbyte> ToSByte(this Cuboid<int> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Cuboid<sbyte> ToSByte(this Cuboid<uint> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Cuboid<sbyte> ToSByte(this Cuboid<long> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Cuboid<sbyte> ToSByte(this Cuboid<ulong> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Cuboid<sbyte> ToSByte(this Cuboid<float> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Cuboid<sbyte> ToSByte(this Cuboid<double> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Cuboid<sbyte> ToSByte(this Cuboid<decimal> value) => new(value.Position.ToSByte(), value.Size.ToSByte());

    public static Cuboid<sbyte> ToSByteOrClamp(this Cuboid<byte> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Cuboid<sbyte> ToSByteOrClamp(this Cuboid<short> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Cuboid<sbyte> ToSByteOrClamp(this Cuboid<ushort> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Cuboid<sbyte> ToSByteOrClamp(this Cuboid<int> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Cuboid<sbyte> ToSByteOrClamp(this Cuboid<uint> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Cuboid<sbyte> ToSByteOrClamp(this Cuboid<long> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Cuboid<sbyte> ToSByteOrClamp(this Cuboid<ulong> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Cuboid<sbyte> ToSByteOrClamp(this Cuboid<float> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Cuboid<sbyte> ToSByteOrClamp(this Cuboid<double> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Cuboid<sbyte> ToSByteOrClamp(this Cuboid<decimal> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());

    public static Cuboid<sbyte> ToSByteOrDefault(this Cuboid<byte> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Cuboid<sbyte> ToSByteOrDefault(this Cuboid<short> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Cuboid<sbyte> ToSByteOrDefault(this Cuboid<ushort> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Cuboid<sbyte> ToSByteOrDefault(this Cuboid<int> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Cuboid<sbyte> ToSByteOrDefault(this Cuboid<uint> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Cuboid<sbyte> ToSByteOrDefault(this Cuboid<long> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Cuboid<sbyte> ToSByteOrDefault(this Cuboid<ulong> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Cuboid<sbyte> ToSByteOrDefault(this Cuboid<float> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Cuboid<sbyte> ToSByteOrDefault(this Cuboid<double> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Cuboid<sbyte> ToSByteOrDefault(this Cuboid<decimal> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));

    public static Cuboid<byte> ToByte(this Cuboid<sbyte> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Cuboid<byte> ToByte(this Cuboid<short> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Cuboid<byte> ToByte(this Cuboid<ushort> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Cuboid<byte> ToByte(this Cuboid<int> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Cuboid<byte> ToByte(this Cuboid<uint> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Cuboid<byte> ToByte(this Cuboid<long> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Cuboid<byte> ToByte(this Cuboid<ulong> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Cuboid<byte> ToByte(this Cuboid<float> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Cuboid<byte> ToByte(this Cuboid<double> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Cuboid<byte> ToByte(this Cuboid<decimal> value) => new(value.Position.ToByte(), value.Size.ToByte());

    public static Cuboid<byte> ToByteOrClamp(this Cuboid<sbyte> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Cuboid<byte> ToByteOrClamp(this Cuboid<short> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Cuboid<byte> ToByteOrClamp(this Cuboid<ushort> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Cuboid<byte> ToByteOrClamp(this Cuboid<int> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Cuboid<byte> ToByteOrClamp(this Cuboid<uint> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Cuboid<byte> ToByteOrClamp(this Cuboid<long> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Cuboid<byte> ToByteOrClamp(this Cuboid<ulong> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Cuboid<byte> ToByteOrClamp(this Cuboid<float> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Cuboid<byte> ToByteOrClamp(this Cuboid<double> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Cuboid<byte> ToByteOrClamp(this Cuboid<decimal> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());

    public static Cuboid<byte> ToByteOrDefault(this Cuboid<sbyte> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Cuboid<byte> ToByteOrDefault(this Cuboid<short> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Cuboid<byte> ToByteOrDefault(this Cuboid<ushort> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Cuboid<byte> ToByteOrDefault(this Cuboid<int> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Cuboid<byte> ToByteOrDefault(this Cuboid<uint> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Cuboid<byte> ToByteOrDefault(this Cuboid<long> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Cuboid<byte> ToByteOrDefault(this Cuboid<ulong> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Cuboid<byte> ToByteOrDefault(this Cuboid<float> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Cuboid<byte> ToByteOrDefault(this Cuboid<double> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Cuboid<byte> ToByteOrDefault(this Cuboid<decimal> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));

    public static Cuboid<short> ToShort(this Cuboid<sbyte> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Cuboid<short> ToShort(this Cuboid<byte> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Cuboid<short> ToShort(this Cuboid<ushort> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Cuboid<short> ToShort(this Cuboid<int> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Cuboid<short> ToShort(this Cuboid<uint> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Cuboid<short> ToShort(this Cuboid<long> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Cuboid<short> ToShort(this Cuboid<ulong> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Cuboid<short> ToShort(this Cuboid<float> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Cuboid<short> ToShort(this Cuboid<double> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Cuboid<short> ToShort(this Cuboid<decimal> value) => new(value.Position.ToShort(), value.Size.ToShort());

    public static Cuboid<short> ToShortOrClamp(this Cuboid<ushort> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Cuboid<short> ToShortOrClamp(this Cuboid<int> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Cuboid<short> ToShortOrClamp(this Cuboid<uint> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Cuboid<short> ToShortOrClamp(this Cuboid<long> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Cuboid<short> ToShortOrClamp(this Cuboid<ulong> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Cuboid<short> ToShortOrClamp(this Cuboid<float> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Cuboid<short> ToShortOrClamp(this Cuboid<double> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Cuboid<short> ToShortOrClamp(this Cuboid<decimal> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());

    public static Cuboid<short> ToShortOrDefault(this Cuboid<ushort> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Cuboid<short> ToShortOrDefault(this Cuboid<int> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Cuboid<short> ToShortOrDefault(this Cuboid<uint> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Cuboid<short> ToShortOrDefault(this Cuboid<long> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Cuboid<short> ToShortOrDefault(this Cuboid<ulong> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Cuboid<short> ToShortOrDefault(this Cuboid<float> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Cuboid<short> ToShortOrDefault(this Cuboid<double> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Cuboid<short> ToShortOrDefault(this Cuboid<decimal> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));

    public static Cuboid<ushort> ToUShort(this Cuboid<sbyte> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Cuboid<ushort> ToUShort(this Cuboid<byte> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Cuboid<ushort> ToUShort(this Cuboid<short> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Cuboid<ushort> ToUShort(this Cuboid<int> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Cuboid<ushort> ToUShort(this Cuboid<uint> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Cuboid<ushort> ToUShort(this Cuboid<long> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Cuboid<ushort> ToUShort(this Cuboid<ulong> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Cuboid<ushort> ToUShort(this Cuboid<float> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Cuboid<ushort> ToUShort(this Cuboid<double> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Cuboid<ushort> ToUShort(this Cuboid<decimal> value) => new(value.Position.ToUShort(), value.Size.ToUShort());

    public static Cuboid<ushort> ToUShortOrClamp(this Cuboid<sbyte> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Cuboid<ushort> ToUShortOrClamp(this Cuboid<short> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Cuboid<ushort> ToUShortOrClamp(this Cuboid<int> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Cuboid<ushort> ToUShortOrClamp(this Cuboid<uint> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Cuboid<ushort> ToUShortOrClamp(this Cuboid<long> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Cuboid<ushort> ToUShortOrClamp(this Cuboid<ulong> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Cuboid<ushort> ToUShortOrClamp(this Cuboid<float> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Cuboid<ushort> ToUShortOrClamp(this Cuboid<double> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Cuboid<ushort> ToUShortOrClamp(this Cuboid<decimal> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());

    public static Cuboid<ushort> ToUShortOrDefault(this Cuboid<sbyte> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Cuboid<ushort> ToUShortOrDefault(this Cuboid<short> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Cuboid<ushort> ToUShortOrDefault(this Cuboid<int> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Cuboid<ushort> ToUShortOrDefault(this Cuboid<uint> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Cuboid<ushort> ToUShortOrDefault(this Cuboid<long> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Cuboid<ushort> ToUShortOrDefault(this Cuboid<ulong> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Cuboid<ushort> ToUShortOrDefault(this Cuboid<float> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Cuboid<ushort> ToUShortOrDefault(this Cuboid<double> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Cuboid<ushort> ToUShortOrDefault(this Cuboid<decimal> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));

    public static Cuboid<int> ToInt(this Cuboid<sbyte> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Cuboid<int> ToInt(this Cuboid<byte> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Cuboid<int> ToInt(this Cuboid<short> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Cuboid<int> ToInt(this Cuboid<ushort> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Cuboid<int> ToInt(this Cuboid<uint> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Cuboid<int> ToInt(this Cuboid<long> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Cuboid<int> ToInt(this Cuboid<ulong> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Cuboid<int> ToInt(this Cuboid<float> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Cuboid<int> ToInt(this Cuboid<double> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Cuboid<int> ToInt(this Cuboid<decimal> value) => new(value.Position.ToInt(), value.Size.ToInt());

    public static Cuboid<int> ToIntOrClamp(this Cuboid<uint> value) => new(value.Position.ToIntOrClamp(), value.Size.ToIntOrClamp());
    public static Cuboid<int> ToIntOrClamp(this Cuboid<long> value) => new(value.Position.ToIntOrClamp(), value.Size.ToIntOrClamp());
    public static Cuboid<int> ToIntOrClamp(this Cuboid<ulong> value) => new(value.Position.ToIntOrClamp(), value.Size.ToIntOrClamp());
    public static Cuboid<int> ToIntOrClamp(this Cuboid<float> value) => new(value.Position.ToIntOrClamp(), value.Size.ToIntOrClamp());
    public static Cuboid<int> ToIntOrClamp(this Cuboid<double> value) => new(value.Position.ToIntOrClamp(), value.Size.ToIntOrClamp());
    public static Cuboid<int> ToIntOrClamp(this Cuboid<decimal> value) => new(value.Position.ToIntOrClamp(), value.Size.ToIntOrClamp());

    public static Cuboid<int> ToIntOrDefault(this Cuboid<uint> value, int defaultValue) => new(value.Position.ToIntOrDefault(defaultValue), value.Size.ToIntOrDefault(defaultValue));
    public static Cuboid<int> ToIntOrDefault(this Cuboid<long> value, int defaultValue) => new(value.Position.ToIntOrDefault(defaultValue), value.Size.ToIntOrDefault(defaultValue));
    public static Cuboid<int> ToIntOrDefault(this Cuboid<ulong> value, int defaultValue) => new(value.Position.ToIntOrDefault(defaultValue), value.Size.ToIntOrDefault(defaultValue));
    public static Cuboid<int> ToIntOrDefault(this Cuboid<float> value, int defaultValue) => new(value.Position.ToIntOrDefault(defaultValue), value.Size.ToIntOrDefault(defaultValue));
    public static Cuboid<int> ToIntOrDefault(this Cuboid<double> value, int defaultValue) => new(value.Position.ToIntOrDefault(defaultValue), value.Size.ToIntOrDefault(defaultValue));
    public static Cuboid<int> ToIntOrDefault(this Cuboid<decimal> value, int defaultValue) => new(value.Position.ToIntOrDefault(defaultValue), value.Size.ToIntOrDefault(defaultValue));

    public static Cuboid<uint> ToUInt(this Cuboid<sbyte> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Cuboid<uint> ToUInt(this Cuboid<byte> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Cuboid<uint> ToUInt(this Cuboid<short> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Cuboid<uint> ToUInt(this Cuboid<ushort> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Cuboid<uint> ToUInt(this Cuboid<int> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Cuboid<uint> ToUInt(this Cuboid<long> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Cuboid<uint> ToUInt(this Cuboid<ulong> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Cuboid<uint> ToUInt(this Cuboid<float> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Cuboid<uint> ToUInt(this Cuboid<double> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Cuboid<uint> ToUInt(this Cuboid<decimal> value) => new(value.Position.ToUInt(), value.Size.ToUInt());

    public static Cuboid<uint> ToUIntOrClamp(this Cuboid<sbyte> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());
    public static Cuboid<uint> ToUIntOrClamp(this Cuboid<int> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());
    public static Cuboid<uint> ToUIntOrClamp(this Cuboid<long> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());
    public static Cuboid<uint> ToUIntOrClamp(this Cuboid<ulong> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());
    public static Cuboid<uint> ToUIntOrClamp(this Cuboid<float> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());
    public static Cuboid<uint> ToUIntOrClamp(this Cuboid<double> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());
    public static Cuboid<uint> ToUIntOrClamp(this Cuboid<decimal> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());

    public static Cuboid<uint> ToUIntOrDefault(this Cuboid<sbyte> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Cuboid<uint> ToUIntOrDefault(this Cuboid<short> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Cuboid<uint> ToUIntOrDefault(this Cuboid<int> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Cuboid<uint> ToUIntOrDefault(this Cuboid<long> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Cuboid<uint> ToUIntOrDefault(this Cuboid<ulong> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Cuboid<uint> ToUIntOrDefault(this Cuboid<float> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Cuboid<uint> ToUIntOrDefault(this Cuboid<double> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Cuboid<uint> ToUIntOrDefault(this Cuboid<decimal> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));

    public static Cuboid<long> ToLong(this Cuboid<sbyte> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Cuboid<long> ToLong(this Cuboid<byte> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Cuboid<long> ToLong(this Cuboid<short> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Cuboid<long> ToLong(this Cuboid<ushort> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Cuboid<long> ToLong(this Cuboid<int> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Cuboid<long> ToLong(this Cuboid<uint> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Cuboid<long> ToLong(this Cuboid<ulong> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Cuboid<long> ToLong(this Cuboid<float> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Cuboid<long> ToLong(this Cuboid<double> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Cuboid<long> ToLong(this Cuboid<decimal> value) => new(value.Position.ToLong(), value.Size.ToLong());

    public static Cuboid<long> ToLongOrClamp(this Cuboid<ulong> value) => new(value.Position.ToLongOrClamp(), value.Size.ToLongOrClamp());
    public static Cuboid<long> ToLongOrClamp(this Cuboid<float> value) => new(value.Position.ToLongOrClamp(), value.Size.ToLongOrClamp());
    public static Cuboid<long> ToLongOrClamp(this Cuboid<double> value) => new(value.Position.ToLongOrClamp(), value.Size.ToLongOrClamp());
    public static Cuboid<long> ToLongOrClamp(this Cuboid<decimal> value) => new(value.Position.ToLongOrClamp(), value.Size.ToLongOrClamp());

    public static Cuboid<long> ToLongOrDefault(this Cuboid<ulong> value, long defaultValue) => new(value.Position.ToLongOrDefault(defaultValue), value.Size.ToLongOrDefault(defaultValue));
    public static Cuboid<long> ToLongOrDefault(this Cuboid<float> value, long defaultValue) => new(value.Position.ToLongOrDefault(defaultValue), value.Size.ToLongOrDefault(defaultValue));
    public static Cuboid<long> ToLongOrDefault(this Cuboid<double> value, long defaultValue) => new(value.Position.ToLongOrDefault(defaultValue), value.Size.ToLongOrDefault(defaultValue));
    public static Cuboid<long> ToLongOrDefault(this Cuboid<decimal> value, long defaultValue) => new(value.Position.ToLongOrDefault(defaultValue), value.Size.ToLongOrDefault(defaultValue));

    public static Cuboid<ulong> ToULong(this Cuboid<sbyte> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Cuboid<ulong> ToULong(this Cuboid<byte> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Cuboid<ulong> ToULong(this Cuboid<short> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Cuboid<ulong> ToULong(this Cuboid<ushort> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Cuboid<ulong> ToULong(this Cuboid<int> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Cuboid<ulong> ToULong(this Cuboid<uint> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Cuboid<ulong> ToULong(this Cuboid<long> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Cuboid<ulong> ToULong(this Cuboid<float> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Cuboid<ulong> ToULong(this Cuboid<double> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Cuboid<ulong> ToULong(this Cuboid<decimal> value) => new(value.Position.ToULong(), value.Size.ToULong());

    public static Cuboid<ulong> ToULongOrClamp(this Cuboid<sbyte> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());
    public static Cuboid<ulong> ToULongOrClamp(this Cuboid<short> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());
    public static Cuboid<ulong> ToULongOrClamp(this Cuboid<int> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());
    public static Cuboid<ulong> ToULongOrClamp(this Cuboid<long> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());
    public static Cuboid<ulong> ToULongOrClamp(this Cuboid<float> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());
    public static Cuboid<ulong> ToULongOrClamp(this Cuboid<double> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());
    public static Cuboid<ulong> ToULongOrClamp(this Cuboid<decimal> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());

    public static Cuboid<ulong> ToULongOrDefault(this Cuboid<sbyte> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));
    public static Cuboid<ulong> ToULongOrDefault(this Cuboid<short> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));
    public static Cuboid<ulong> ToULongOrDefault(this Cuboid<int> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));
    public static Cuboid<ulong> ToULongOrDefault(this Cuboid<long> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));
    public static Cuboid<ulong> ToULongOrDefault(this Cuboid<float> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));
    public static Cuboid<ulong> ToULongOrDefault(this Cuboid<double> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));
    public static Cuboid<ulong> ToULongOrDefault(this Cuboid<decimal> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));

    public static Cuboid<float> ToFloat(this Cuboid<sbyte> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Cuboid<float> ToFloat(this Cuboid<byte> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Cuboid<float> ToFloat(this Cuboid<short> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Cuboid<float> ToFloat(this Cuboid<ushort> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Cuboid<float> ToFloat(this Cuboid<int> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Cuboid<float> ToFloat(this Cuboid<uint> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Cuboid<float> ToFloat(this Cuboid<long> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Cuboid<float> ToFloat(this Cuboid<ulong> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Cuboid<float> ToFloat(this Cuboid<double> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Cuboid<float> ToFloat(this Cuboid<decimal> value) => new(value.Position.ToFloat(), value.Size.ToFloat());

    public static Cuboid<float> ToFloatOrClamp(this Cuboid<double> value) => new(value.Position.ToFloatOrClamp(), value.Size.ToFloatOrClamp());
    public static Cuboid<float> ToFloatOrClamp(this Cuboid<decimal> value) => new(value.Position.ToFloatOrClamp(), value.Size.ToFloatOrClamp());

    public static Cuboid<float> ToFloatOrDefault(this Cuboid<double> value, float defaultValue) => new(value.Position.ToFloatOrDefault(defaultValue), value.Size.ToFloatOrDefault(defaultValue));
    public static Cuboid<float> ToFloatOrDefault(this Cuboid<decimal> value, float defaultValue) => new(value.Position.ToFloatOrDefault(defaultValue), value.Size.ToFloatOrDefault(defaultValue));

    public static Cuboid<double> ToDouble(this Cuboid<sbyte> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Cuboid<double> ToDouble(this Cuboid<byte> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Cuboid<double> ToDouble(this Cuboid<short> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Cuboid<double> ToDouble(this Cuboid<ushort> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Cuboid<double> ToDouble(this Cuboid<int> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Cuboid<double> ToDouble(this Cuboid<uint> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Cuboid<double> ToDouble(this Cuboid<long> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Cuboid<double> ToDouble(this Cuboid<ulong> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Cuboid<double> ToDouble(this Cuboid<float> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Cuboid<double> ToDouble(this Cuboid<decimal> value) => new(value.Position.ToDouble(), value.Size.ToDouble());

    public static Cuboid<double> ToDoubleOrClamp(this Cuboid<decimal> value) => new(value.Position.ToDoubleOrClamp(), value.Size.ToDoubleOrClamp());

    public static Cuboid<double> ToDoubleOrDefault(this Cuboid<decimal> value, double defaultValue) => new(value.Position.ToDoubleOrDefault(defaultValue), value.Size.ToDoubleOrDefault(defaultValue));

    public static Cuboid<decimal> ToDecimal(this Cuboid<sbyte> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Cuboid<decimal> ToDecimal(this Cuboid<byte> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Cuboid<decimal> ToDecimal(this Cuboid<short> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Cuboid<decimal> ToDecimal(this Cuboid<ushort> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Cuboid<decimal> ToDecimal(this Cuboid<int> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Cuboid<decimal> ToDecimal(this Cuboid<uint> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Cuboid<decimal> ToDecimal(this Cuboid<long> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Cuboid<decimal> ToDecimal(this Cuboid<ulong> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Cuboid<decimal> ToDecimal(this Cuboid<float> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Cuboid<decimal> ToDecimal(this Cuboid<double> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
}