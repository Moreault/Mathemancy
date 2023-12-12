using System.Linq;
using System.Numerics;

namespace Mathemancy.Tests;

public static class Numbers
{
    public static bool IsUnsigned<T>() where T : INumber<T>
    {
        return new[] { typeof(ushort), typeof(uint), typeof(ulong), typeof(byte) }.Contains(typeof(T));
    }
}