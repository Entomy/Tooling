namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the chord of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/> and <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos chord is to be computed.</param>
	/// <returns>The chord of <paramref name="value"/>.</returns>
	public static T Crd<T>(this T value) where T : IFloatingPointConstants<T>, ITrigonometricFunctions<T> {
		T two = T.One + T.One;
		return two * T.Sin(value / two);
	}
}
