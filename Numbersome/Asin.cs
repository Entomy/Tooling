namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the arc-sine of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whose arc-sine is to be computed.</param>
	/// <returns>The arc-sine of <paramref name="value"/>.</returns>
	/// <remarks>
	/// This computes <c>arcsin(x)</c> in the interval <c>[-π / 2, +π / 2]</c> radians.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Asin<T>(this T value) where T : ITrigonometricFunctions<T> => T.Asin(value);
}
