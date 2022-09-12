namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the hyperbolic chord of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/> and <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos chord is to be computed.</param>
	/// <returns>The hyperbolic chord of <paramref name="value"/>.</returns>
	public static T Crdh<T>(this T value) where T : IHyperbolicFunctions<T> {
		T two = T.One + T.One;
		return two * T.Sinh(value / two);
	}
}
