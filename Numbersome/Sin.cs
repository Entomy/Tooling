namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the sine of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whose sine is to be computed.</param>
	/// <returns>The sine of <paramref name="value"/>.</returns>
	/// <remarks>
	///	This computes <c>sin(x)</c>.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Sin<T>(this T value) where T : ITrigonometricFunctions<T> => T.Sin(value);
}
