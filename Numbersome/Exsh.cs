namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the hyperbolic exterior secant of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IHyperbolicFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos exterior secant is to be computed.</param>
	/// <returns>The hyperbolic exterior secant of <paramref name="value"/>.</returns>
	public static T Exsh<T>(this T value) where T : IHyperbolicFunctions<T> => Sech(value) - T.One;
}
