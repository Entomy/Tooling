namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the arc-tangent of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whose arc-tangent is to be computed.</param>
	/// <returns>The arc-tangent of <paramref name="value"/>.</returns>
	/// <remarks>
	/// This computes <c>arctan(x)</c> in the interval <c>[-π / 2, +π / 2]</c> radians.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Atan<T>(this T value) where T : ITrigonometricFunctions<T> => T.Atan(value);

	/// <summary>
	/// Computes the arc-tangent for the quotient of two values.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointIeee754{TSelf}"/>.</typeparam>
	/// <param name="point">The point (X, Y) providing the two values.</param>
	/// <returns>The arc-tangent of Y divided-by X.</returns>
	/// <remarks>This computes <c>arctan(Y / X)</c> in the interval <c>[-π, +π]</c> radians.</remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Atan<T>(this (T X, T Y) point) where T : IFloatingPointIeee754<T> => T.Atan2(point.Y, point.X);
}
