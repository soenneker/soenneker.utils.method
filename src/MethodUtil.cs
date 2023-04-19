using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Soenneker.Utils.Method;

/// <summary>
/// A utility library providing various method() related operations
/// </summary>
public static class MethodUtil
{
    /// <summary>
    /// Gets the name of the current method (calling this)
    /// </summary>
    /// <param name="methodName">Not intended to ever be set from caller</param>
    [Pure]
    public static string? Get([CallerMemberName] string? methodName = null)
    {
        return methodName;
    }
}