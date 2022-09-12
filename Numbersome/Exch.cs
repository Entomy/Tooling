namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the hyperbolic exterior secant compliment of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IHyperbolicFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos exterior secant compliment is to be computed.</param>
	/// <returns>The hyperbolic exterior secant compliment of <paramref name="value"/>.</returns>
	public static T Exch<T>(this T value) where T : IHyperbolicFunctions<T> => Csch(value) - T.One;
}
