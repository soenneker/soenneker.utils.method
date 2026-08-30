using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Soenneker.Utils.Method;

/// <summary>
/// A utility library providing various method() related operations
/// </summary>
public static class MethodUtil
{
    /// <summary>
    /// Gets the compiler-supplied name of the member containing the call.
    /// </summary>
    /// <param name="methodName">The caller member name supplied by the compiler, or an explicit override.</param>
    /// <returns>The containing member name or explicitly supplied value.</returns>
    [Pure]
    public static string Get([CallerMemberName] string methodName = "")
    {
        return methodName;
    }
}
