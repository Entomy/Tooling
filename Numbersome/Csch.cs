namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the hyperbolic secant compliment of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IHyperbolicFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos secant compliment is to be computed.</param>
	/// <returns>The hyperbolic secant compliment of <paramref name="value"/>.</returns>
	public static T Csch<T>(this T value) where T : IHyperbolicFunctions<T> => T.One / T.Sinh(value);
}
