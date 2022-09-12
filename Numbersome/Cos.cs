namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the cosine of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whose cosine is to be computed.</param>
	/// <returns>The cosine of <paramref name="value"/>.</returns>
	/// <remarks>
	/// This computes <c>cos(x)</c>.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Cos<T>(this T value) where T : ITrigonometricFunctions<T> => T.Cos(value);
}
