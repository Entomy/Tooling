namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the hyperbolic halved versed sine of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IHyperbolicFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos halved versed sine is to be computed.</param>
	/// <returns>The hyperbolic halved versed sine of <paramref name="value"/>.</returns>
	public static T Havh<T>(this T value) where T : IHyperbolicFunctions<T> => Verh(value) / (T.One + T.One);
}
