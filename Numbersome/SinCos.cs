namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the sine and cosine of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whose sine and cosine are to be computed.</param>
	/// <returns>The sine and cosine of <paramref name="value"/>.</returns>
	/// <remarks>
	/// This computes <c>(sin(x), cos(x))</c>.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static (T Sin, T Cos) SinCos<T>(this T value) where T : ITrigonometricFunctions<T> => T.SinCos(value);
}
