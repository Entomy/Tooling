namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the hyperbolic versed sine of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IHyperbolicFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos versed sine is to be computed.</param>
	/// <returns>The hyperbolic versed sine of <paramref name="value"/>.</returns>
	public static T Verh<T>(this T value) where T : IHyperbolicFunctions<T> => T.One - T.Cosh(value);
}
