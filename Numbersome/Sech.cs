namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the hyperbolic secant of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IHyperbolicFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos secant is to be computed.</param>
	/// <returns>The hyperbolic secant of <paramref name="value"/>.</returns>
	public static T Sech<T>(this T value) where T : IHyperbolicFunctions<T> => T.One / T.Cosh(value);
}
