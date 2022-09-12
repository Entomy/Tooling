namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the integer logarithm of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointIeee754{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose integer logarithm is to be computed.</param>
	/// <returns>The integer logarithm of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Int32 ILogB<T>(this T value) where T : IFloatingPointIeee754<T> => T.ILogB(value);
}
