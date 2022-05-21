namespace ToolBX.Mathemancy;

public static class RectangleExtensions
{
    public static Vector2<byte> GetCenter(this Rectangle<byte> value)
    {
        return new Vector2<byte> ((byte)(value.X + value.Width / 2), (byte)(value.Y + value.Height / 2));
    }

    public static Vector2<sbyte> GetCenter(this Rectangle<sbyte> value)
    {
        return new Vector2<sbyte>((sbyte)(value.X + value.Width / 2), (sbyte)(value.Y + value.Height / 2));
    }

    public static Vector2<short> GetCenter(this Rectangle<short> value)
    {
        return new Vector2<short>((short)(value.X + value.Width / 2), (short)(value.Y + value.Height / 2));
    }

    public static Vector2<ushort> GetCenter(this Rectangle<ushort> value)
    {
        return new Vector2<ushort>((ushort)(value.X + value.Width / 2), (ushort)(value.Y + value.Height / 2));
    }

    public static Vector2<int> GetCenter(this Rectangle<int> value)
    {
        return new Vector2<int>(value.X + value.Width / 2, value.Y + value.Height / 2);
    }

    public static Vector2<uint> GetCenter(this Rectangle<uint> value)
    {
        return new Vector2<uint>(value.X + value.Width / 2, value.Y + value.Height / 2);
    }

    public static Vector2<long> GetCenter(this Rectangle<long> value)
    {
        return new Vector2<long>(value.X + value.Width / 2, value.Y + value.Height / 2);
    }

    public static Vector2<ulong> GetCenter(this Rectangle<ulong> value)
    {
        return new Vector2<ulong>(value.X + value.Width / 2, value.Y + value.Height / 2);
    }

    public static Vector2<float> GetCenter(this Rectangle<float> value)
    {
        return new Vector2<float>(value.X + value.Width / 2.0f, value.Y + value.Height / 2.0f);
    }

    public static Vector2<double> GetCenter(this Rectangle<double> value)
    {
        return new Vector2<double>(value.X + value.Width / 2.0d, value.Y + value.Height / 2.0d);
    }

    public static Vector2<decimal> GetCenter(this Rectangle<decimal> value)
    {
        return new Vector2<decimal>(value.X + value.Width / 2.0m, value.Y + value.Height / 2.0m);
    }

    public static Rectangle<sbyte> ToSByte(this Rectangle<byte> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Rectangle<sbyte> ToSByte(this Rectangle<short> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Rectangle<sbyte> ToSByte(this Rectangle<ushort> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Rectangle<sbyte> ToSByte(this Rectangle<int> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Rectangle<sbyte> ToSByte(this Rectangle<uint> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Rectangle<sbyte> ToSByte(this Rectangle<long> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Rectangle<sbyte> ToSByte(this Rectangle<ulong> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Rectangle<sbyte> ToSByte(this Rectangle<float> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Rectangle<sbyte> ToSByte(this Rectangle<double> value) => new(value.Position.ToSByte(), value.Size.ToSByte());
    public static Rectangle<sbyte> ToSByte(this Rectangle<decimal> value) => new(value.Position.ToSByte(), value.Size.ToSByte());

    public static Rectangle<sbyte> ToSByteOrClamp(this Rectangle<byte> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Rectangle<sbyte> ToSByteOrClamp(this Rectangle<short> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Rectangle<sbyte> ToSByteOrClamp(this Rectangle<ushort> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Rectangle<sbyte> ToSByteOrClamp(this Rectangle<int> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Rectangle<sbyte> ToSByteOrClamp(this Rectangle<uint> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Rectangle<sbyte> ToSByteOrClamp(this Rectangle<long> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Rectangle<sbyte> ToSByteOrClamp(this Rectangle<ulong> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Rectangle<sbyte> ToSByteOrClamp(this Rectangle<float> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Rectangle<sbyte> ToSByteOrClamp(this Rectangle<double> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());
    public static Rectangle<sbyte> ToSByteOrClamp(this Rectangle<decimal> value) => new(value.Position.ToSByteOrClamp(), value.Size.ToSByteOrClamp());

    public static Rectangle<sbyte> ToSByteOrDefault(this Rectangle<byte> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Rectangle<sbyte> ToSByteOrDefault(this Rectangle<short> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Rectangle<sbyte> ToSByteOrDefault(this Rectangle<ushort> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Rectangle<sbyte> ToSByteOrDefault(this Rectangle<int> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Rectangle<sbyte> ToSByteOrDefault(this Rectangle<uint> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Rectangle<sbyte> ToSByteOrDefault(this Rectangle<long> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Rectangle<sbyte> ToSByteOrDefault(this Rectangle<ulong> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Rectangle<sbyte> ToSByteOrDefault(this Rectangle<float> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Rectangle<sbyte> ToSByteOrDefault(this Rectangle<double> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));
    public static Rectangle<sbyte> ToSByteOrDefault(this Rectangle<decimal> value, sbyte defaultValue) => new(value.Position.ToSByteOrDefault(defaultValue), value.Size.ToSByteOrDefault(defaultValue));

    public static Rectangle<byte> ToByte(this Rectangle<sbyte> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Rectangle<byte> ToByte(this Rectangle<short> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Rectangle<byte> ToByte(this Rectangle<ushort> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Rectangle<byte> ToByte(this Rectangle<int> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Rectangle<byte> ToByte(this Rectangle<uint> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Rectangle<byte> ToByte(this Rectangle<long> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Rectangle<byte> ToByte(this Rectangle<ulong> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Rectangle<byte> ToByte(this Rectangle<float> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Rectangle<byte> ToByte(this Rectangle<double> value) => new(value.Position.ToByte(), value.Size.ToByte());
    public static Rectangle<byte> ToByte(this Rectangle<decimal> value) => new(value.Position.ToByte(), value.Size.ToByte());

    public static Rectangle<byte> ToByteOrClamp(this Rectangle<sbyte> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Rectangle<byte> ToByteOrClamp(this Rectangle<short> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Rectangle<byte> ToByteOrClamp(this Rectangle<ushort> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Rectangle<byte> ToByteOrClamp(this Rectangle<int> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Rectangle<byte> ToByteOrClamp(this Rectangle<uint> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Rectangle<byte> ToByteOrClamp(this Rectangle<long> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Rectangle<byte> ToByteOrClamp(this Rectangle<ulong> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Rectangle<byte> ToByteOrClamp(this Rectangle<float> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Rectangle<byte> ToByteOrClamp(this Rectangle<double> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());
    public static Rectangle<byte> ToByteOrClamp(this Rectangle<decimal> value) => new(value.Position.ToByteOrClamp(), value.Size.ToByteOrClamp());

    public static Rectangle<byte> ToByteOrDefault(this Rectangle<sbyte> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Rectangle<byte> ToByteOrDefault(this Rectangle<short> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Rectangle<byte> ToByteOrDefault(this Rectangle<ushort> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Rectangle<byte> ToByteOrDefault(this Rectangle<int> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Rectangle<byte> ToByteOrDefault(this Rectangle<uint> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Rectangle<byte> ToByteOrDefault(this Rectangle<long> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Rectangle<byte> ToByteOrDefault(this Rectangle<ulong> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Rectangle<byte> ToByteOrDefault(this Rectangle<float> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Rectangle<byte> ToByteOrDefault(this Rectangle<double> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));
    public static Rectangle<byte> ToByteOrDefault(this Rectangle<decimal> value, byte defaultValue) => new(value.Position.ToByteOrDefault(defaultValue), value.Size.ToByteOrDefault(defaultValue));

    public static Rectangle<short> ToShort(this Rectangle<sbyte> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Rectangle<short> ToShort(this Rectangle<byte> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Rectangle<short> ToShort(this Rectangle<ushort> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Rectangle<short> ToShort(this Rectangle<int> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Rectangle<short> ToShort(this Rectangle<uint> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Rectangle<short> ToShort(this Rectangle<long> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Rectangle<short> ToShort(this Rectangle<ulong> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Rectangle<short> ToShort(this Rectangle<float> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Rectangle<short> ToShort(this Rectangle<double> value) => new(value.Position.ToShort(), value.Size.ToShort());
    public static Rectangle<short> ToShort(this Rectangle<decimal> value) => new(value.Position.ToShort(), value.Size.ToShort());

    public static Rectangle<short> ToShortOrClamp(this Rectangle<ushort> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Rectangle<short> ToShortOrClamp(this Rectangle<int> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Rectangle<short> ToShortOrClamp(this Rectangle<uint> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Rectangle<short> ToShortOrClamp(this Rectangle<long> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Rectangle<short> ToShortOrClamp(this Rectangle<ulong> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Rectangle<short> ToShortOrClamp(this Rectangle<float> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Rectangle<short> ToShortOrClamp(this Rectangle<double> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());
    public static Rectangle<short> ToShortOrClamp(this Rectangle<decimal> value) => new(value.Position.ToShortOrClamp(), value.Size.ToShortOrClamp());

    public static Rectangle<short> ToShortOrDefault(this Rectangle<ushort> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Rectangle<short> ToShortOrDefault(this Rectangle<int> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Rectangle<short> ToShortOrDefault(this Rectangle<uint> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Rectangle<short> ToShortOrDefault(this Rectangle<long> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Rectangle<short> ToShortOrDefault(this Rectangle<ulong> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Rectangle<short> ToShortOrDefault(this Rectangle<float> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Rectangle<short> ToShortOrDefault(this Rectangle<double> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));
    public static Rectangle<short> ToShortOrDefault(this Rectangle<decimal> value, short defaultValue) => new(value.Position.ToShortOrDefault(defaultValue), value.Size.ToShortOrDefault(defaultValue));

    public static Rectangle<ushort> ToUShort(this Rectangle<sbyte> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Rectangle<ushort> ToUShort(this Rectangle<byte> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Rectangle<ushort> ToUShort(this Rectangle<short> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Rectangle<ushort> ToUShort(this Rectangle<int> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Rectangle<ushort> ToUShort(this Rectangle<uint> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Rectangle<ushort> ToUShort(this Rectangle<long> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Rectangle<ushort> ToUShort(this Rectangle<ulong> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Rectangle<ushort> ToUShort(this Rectangle<float> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Rectangle<ushort> ToUShort(this Rectangle<double> value) => new(value.Position.ToUShort(), value.Size.ToUShort());
    public static Rectangle<ushort> ToUShort(this Rectangle<decimal> value) => new(value.Position.ToUShort(), value.Size.ToUShort());

    public static Rectangle<ushort> ToUShortOrClamp(this Rectangle<sbyte> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Rectangle<ushort> ToUShortOrClamp(this Rectangle<short> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Rectangle<ushort> ToUShortOrClamp(this Rectangle<int> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Rectangle<ushort> ToUShortOrClamp(this Rectangle<uint> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Rectangle<ushort> ToUShortOrClamp(this Rectangle<long> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Rectangle<ushort> ToUShortOrClamp(this Rectangle<ulong> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Rectangle<ushort> ToUShortOrClamp(this Rectangle<float> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Rectangle<ushort> ToUShortOrClamp(this Rectangle<double> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());
    public static Rectangle<ushort> ToUShortOrClamp(this Rectangle<decimal> value) => new(value.Position.ToUShortOrClamp(), value.Size.ToUShortOrClamp());

    public static Rectangle<ushort> ToUShortOrDefault(this Rectangle<sbyte> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Rectangle<ushort> ToUShortOrDefault(this Rectangle<short> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Rectangle<ushort> ToUShortOrDefault(this Rectangle<int> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Rectangle<ushort> ToUShortOrDefault(this Rectangle<uint> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Rectangle<ushort> ToUShortOrDefault(this Rectangle<long> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Rectangle<ushort> ToUShortOrDefault(this Rectangle<ulong> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Rectangle<ushort> ToUShortOrDefault(this Rectangle<float> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Rectangle<ushort> ToUShortOrDefault(this Rectangle<double> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));
    public static Rectangle<ushort> ToUShortOrDefault(this Rectangle<decimal> value, ushort defaultValue) => new(value.Position.ToUShortOrDefault(defaultValue), value.Size.ToUShortOrDefault(defaultValue));

    public static Rectangle<int> ToInt(this Rectangle<sbyte> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Rectangle<int> ToInt(this Rectangle<byte> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Rectangle<int> ToInt(this Rectangle<short> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Rectangle<int> ToInt(this Rectangle<ushort> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Rectangle<int> ToInt(this Rectangle<uint> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Rectangle<int> ToInt(this Rectangle<long> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Rectangle<int> ToInt(this Rectangle<ulong> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Rectangle<int> ToInt(this Rectangle<float> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Rectangle<int> ToInt(this Rectangle<double> value) => new(value.Position.ToInt(), value.Size.ToInt());
    public static Rectangle<int> ToInt(this Rectangle<decimal> value) => new(value.Position.ToInt(), value.Size.ToInt());

    public static Rectangle<int> ToIntOrClamp(this Rectangle<uint> value) => new(value.Position.ToIntOrClamp(), value.Size.ToIntOrClamp());
    public static Rectangle<int> ToIntOrClamp(this Rectangle<long> value) => new(value.Position.ToIntOrClamp(), value.Size.ToIntOrClamp());
    public static Rectangle<int> ToIntOrClamp(this Rectangle<ulong> value) => new(value.Position.ToIntOrClamp(), value.Size.ToIntOrClamp());
    public static Rectangle<int> ToIntOrClamp(this Rectangle<float> value) => new(value.Position.ToIntOrClamp(), value.Size.ToIntOrClamp());
    public static Rectangle<int> ToIntOrClamp(this Rectangle<double> value) => new(value.Position.ToIntOrClamp(), value.Size.ToIntOrClamp());
    public static Rectangle<int> ToIntOrClamp(this Rectangle<decimal> value) => new(value.Position.ToIntOrClamp(), value.Size.ToIntOrClamp());

    public static Rectangle<int> ToIntOrDefault(this Rectangle<uint> value, int defaultValue) => new(value.Position.ToIntOrDefault(defaultValue), value.Size.ToIntOrDefault(defaultValue));
    public static Rectangle<int> ToIntOrDefault(this Rectangle<long> value, int defaultValue) => new(value.Position.ToIntOrDefault(defaultValue), value.Size.ToIntOrDefault(defaultValue));
    public static Rectangle<int> ToIntOrDefault(this Rectangle<ulong> value, int defaultValue) => new(value.Position.ToIntOrDefault(defaultValue), value.Size.ToIntOrDefault(defaultValue));
    public static Rectangle<int> ToIntOrDefault(this Rectangle<float> value, int defaultValue) => new(value.Position.ToIntOrDefault(defaultValue), value.Size.ToIntOrDefault(defaultValue));
    public static Rectangle<int> ToIntOrDefault(this Rectangle<double> value, int defaultValue) => new(value.Position.ToIntOrDefault(defaultValue), value.Size.ToIntOrDefault(defaultValue));
    public static Rectangle<int> ToIntOrDefault(this Rectangle<decimal> value, int defaultValue) => new(value.Position.ToIntOrDefault(defaultValue), value.Size.ToIntOrDefault(defaultValue));

    public static Rectangle<uint> ToUInt(this Rectangle<sbyte> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Rectangle<uint> ToUInt(this Rectangle<byte> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Rectangle<uint> ToUInt(this Rectangle<short> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Rectangle<uint> ToUInt(this Rectangle<ushort> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Rectangle<uint> ToUInt(this Rectangle<int> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Rectangle<uint> ToUInt(this Rectangle<long> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Rectangle<uint> ToUInt(this Rectangle<ulong> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Rectangle<uint> ToUInt(this Rectangle<float> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Rectangle<uint> ToUInt(this Rectangle<double> value) => new(value.Position.ToUInt(), value.Size.ToUInt());
    public static Rectangle<uint> ToUInt(this Rectangle<decimal> value) => new(value.Position.ToUInt(), value.Size.ToUInt());

    public static Rectangle<uint> ToUIntOrClamp(this Rectangle<sbyte> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());
    public static Rectangle<uint> ToUIntOrClamp(this Rectangle<short> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());
    public static Rectangle<uint> ToUIntOrClamp(this Rectangle<int> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());
    public static Rectangle<uint> ToUIntOrClamp(this Rectangle<long> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());
    public static Rectangle<uint> ToUIntOrClamp(this Rectangle<ulong> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());
    public static Rectangle<uint> ToUIntOrClamp(this Rectangle<float> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());
    public static Rectangle<uint> ToUIntOrClamp(this Rectangle<double> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());
    public static Rectangle<uint> ToUIntOrClamp(this Rectangle<decimal> value) => new(value.Position.ToUIntOrClamp(), value.Size.ToUIntOrClamp());

    public static Rectangle<uint> ToUIntOrDefault(this Rectangle<sbyte> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Rectangle<uint> ToUIntOrDefault(this Rectangle<short> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Rectangle<uint> ToUIntOrDefault(this Rectangle<int> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Rectangle<uint> ToUIntOrDefault(this Rectangle<long> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Rectangle<uint> ToUIntOrDefault(this Rectangle<ulong> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Rectangle<uint> ToUIntOrDefault(this Rectangle<float> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Rectangle<uint> ToUIntOrDefault(this Rectangle<double> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));
    public static Rectangle<uint> ToUIntOrDefault(this Rectangle<decimal> value, uint defaultValue) => new(value.Position.ToUIntOrDefault(defaultValue), value.Size.ToUIntOrDefault(defaultValue));

    public static Rectangle<long> ToLong(this Rectangle<sbyte> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Rectangle<long> ToLong(this Rectangle<byte> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Rectangle<long> ToLong(this Rectangle<short> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Rectangle<long> ToLong(this Rectangle<ushort> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Rectangle<long> ToLong(this Rectangle<int> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Rectangle<long> ToLong(this Rectangle<uint> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Rectangle<long> ToLong(this Rectangle<ulong> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Rectangle<long> ToLong(this Rectangle<float> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Rectangle<long> ToLong(this Rectangle<double> value) => new(value.Position.ToLong(), value.Size.ToLong());
    public static Rectangle<long> ToLong(this Rectangle<decimal> value) => new(value.Position.ToLong(), value.Size.ToLong());

    public static Rectangle<long> ToLongOrClamp(this Rectangle<ulong> value) => new(value.Position.ToLongOrClamp(), value.Size.ToLongOrClamp());
    public static Rectangle<long> ToLongOrClamp(this Rectangle<float> value) => new(value.Position.ToLongOrClamp(), value.Size.ToLongOrClamp());
    public static Rectangle<long> ToLongOrClamp(this Rectangle<double> value) => new(value.Position.ToLongOrClamp(), value.Size.ToLongOrClamp());
    public static Rectangle<long> ToLongOrClamp(this Rectangle<decimal> value) => new(value.Position.ToLongOrClamp(), value.Size.ToLongOrClamp());

    public static Rectangle<long> ToLongOrDefault(this Rectangle<ulong> value, long defaultValue) => new(value.Position.ToLongOrDefault(defaultValue), value.Size.ToLongOrDefault(defaultValue));
    public static Rectangle<long> ToLongOrDefault(this Rectangle<float> value, long defaultValue) => new(value.Position.ToLongOrDefault(defaultValue), value.Size.ToLongOrDefault(defaultValue));
    public static Rectangle<long> ToLongOrDefault(this Rectangle<double> value, long defaultValue) => new(value.Position.ToLongOrDefault(defaultValue), value.Size.ToLongOrDefault(defaultValue));
    public static Rectangle<long> ToLongOrDefault(this Rectangle<decimal> value, long defaultValue) => new(value.Position.ToLongOrDefault(defaultValue), value.Size.ToLongOrDefault(defaultValue));

    public static Rectangle<ulong> ToULong(this Rectangle<sbyte> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Rectangle<ulong> ToULong(this Rectangle<byte> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Rectangle<ulong> ToULong(this Rectangle<short> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Rectangle<ulong> ToULong(this Rectangle<ushort> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Rectangle<ulong> ToULong(this Rectangle<int> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Rectangle<ulong> ToULong(this Rectangle<uint> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Rectangle<ulong> ToULong(this Rectangle<long> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Rectangle<ulong> ToULong(this Rectangle<float> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Rectangle<ulong> ToULong(this Rectangle<double> value) => new(value.Position.ToULong(), value.Size.ToULong());
    public static Rectangle<ulong> ToULong(this Rectangle<decimal> value) => new(value.Position.ToULong(), value.Size.ToULong());

    public static Rectangle<ulong> ToULongOrClamp(this Rectangle<sbyte> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());
    public static Rectangle<ulong> ToULongOrClamp(this Rectangle<short> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());
    public static Rectangle<ulong> ToULongOrClamp(this Rectangle<int> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());
    public static Rectangle<ulong> ToULongOrClamp(this Rectangle<long> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());
    public static Rectangle<ulong> ToULongOrClamp(this Rectangle<float> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());
    public static Rectangle<ulong> ToULongOrClamp(this Rectangle<double> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());
    public static Rectangle<ulong> ToULongOrClamp(this Rectangle<decimal> value) => new(value.Position.ToULongOrClamp(), value.Size.ToULongOrClamp());

    public static Rectangle<ulong> ToULongOrDefault(this Rectangle<sbyte> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));
    public static Rectangle<ulong> ToULongOrDefault(this Rectangle<short> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));
    public static Rectangle<ulong> ToULongOrDefault(this Rectangle<int> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));
    public static Rectangle<ulong> ToULongOrDefault(this Rectangle<long> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));
    public static Rectangle<ulong> ToULongOrDefault(this Rectangle<float> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));
    public static Rectangle<ulong> ToULongOrDefault(this Rectangle<double> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));
    public static Rectangle<ulong> ToULongOrDefault(this Rectangle<decimal> value, ulong defaultValue) => new(value.Position.ToULongOrDefault(defaultValue), value.Size.ToULongOrDefault(defaultValue));

    public static Rectangle<float> ToFloat(this Rectangle<sbyte> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Rectangle<float> ToFloat(this Rectangle<byte> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Rectangle<float> ToFloat(this Rectangle<short> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Rectangle<float> ToFloat(this Rectangle<ushort> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Rectangle<float> ToFloat(this Rectangle<int> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Rectangle<float> ToFloat(this Rectangle<uint> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Rectangle<float> ToFloat(this Rectangle<long> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Rectangle<float> ToFloat(this Rectangle<ulong> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Rectangle<float> ToFloat(this Rectangle<double> value) => new(value.Position.ToFloat(), value.Size.ToFloat());
    public static Rectangle<float> ToFloat(this Rectangle<decimal> value) => new(value.Position.ToFloat(), value.Size.ToFloat());

    public static Rectangle<float> ToFloatOrClamp(this Rectangle<double> value) => new(value.Position.ToFloatOrClamp(), value.Size.ToFloatOrClamp());
    public static Rectangle<float> ToFloatOrClamp(this Rectangle<decimal> value) => new(value.Position.ToFloatOrClamp(), value.Size.ToFloatOrClamp());

    public static Rectangle<float> ToFloatOrDefault(this Rectangle<double> value, float defaultValue) => new(value.Position.ToFloatOrDefault(defaultValue), value.Size.ToFloatOrDefault(defaultValue));
    public static Rectangle<float> ToFloatOrDefault(this Rectangle<decimal> value, float defaultValue) => new(value.Position.ToFloatOrDefault(defaultValue), value.Size.ToFloatOrDefault(defaultValue));

    public static Rectangle<double> ToDouble(this Rectangle<sbyte> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Rectangle<double> ToDouble(this Rectangle<byte> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Rectangle<double> ToDouble(this Rectangle<short> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Rectangle<double> ToDouble(this Rectangle<ushort> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Rectangle<double> ToDouble(this Rectangle<int> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Rectangle<double> ToDouble(this Rectangle<uint> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Rectangle<double> ToDouble(this Rectangle<long> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Rectangle<double> ToDouble(this Rectangle<ulong> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Rectangle<double> ToDouble(this Rectangle<float> value) => new(value.Position.ToDouble(), value.Size.ToDouble());
    public static Rectangle<double> ToDouble(this Rectangle<decimal> value) => new(value.Position.ToDouble(), value.Size.ToDouble());

    public static Rectangle<double> ToDoubleOrClamp(this Rectangle<decimal> value) => new(value.Position.ToDoubleOrClamp(), value.Size.ToDoubleOrClamp());

    public static Rectangle<double> ToDoubleOrDefault(this Rectangle<decimal> value, double defaultValue) => new(value.Position.ToDoubleOrDefault(defaultValue), value.Size.ToDoubleOrDefault(defaultValue));

    public static Rectangle<decimal> ToDecimal(this Rectangle<sbyte> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Rectangle<decimal> ToDecimal(this Rectangle<byte> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Rectangle<decimal> ToDecimal(this Rectangle<short> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Rectangle<decimal> ToDecimal(this Rectangle<ushort> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Rectangle<decimal> ToDecimal(this Rectangle<int> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Rectangle<decimal> ToDecimal(this Rectangle<uint> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Rectangle<decimal> ToDecimal(this Rectangle<long> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Rectangle<decimal> ToDecimal(this Rectangle<ulong> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Rectangle<decimal> ToDecimal(this Rectangle<float> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());
    public static Rectangle<decimal> ToDecimal(this Rectangle<double> value) => new(value.Position.ToDecimal(), value.Size.ToDecimal());

}