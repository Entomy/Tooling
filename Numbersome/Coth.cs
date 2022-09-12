namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the hyperbolic tangent complement of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IHyperbolicFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos tangent compliment is to be computed.</param>
	/// <returns>The hyperbolic tangent compliment of <paramref name="value"/>.</returns>
	public static T Coth<T>(this T value) where T : IHyperbolicFunctions<T> => T.One / T.Tanh(value);
}
