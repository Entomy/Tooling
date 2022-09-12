namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the arc-cosine of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whose arc-cosine is to be computed.</param>
	/// <returns>The arc-cosine of <paramref name="value"/>.</returns>
	/// <remarks>
	/// This computes <c>arccos(x)</c> in the interval <c>[+0, +π]</c> radians.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Acos<T>(this T value) where T : ITrigonometricFunctions<T> => T.Acos(value);
}
