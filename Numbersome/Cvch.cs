namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the hyperbolic versed compliment sine compliment of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IHyperbolicFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos versed sine compliment is to be computed.</param>
	/// <returns>The hyperbolic versed compliment sine compliment of <paramref name="value"/>.</returns>
	public static T Cvch<T>(this T value) where T : IHyperbolicFunctions<T> => T.One + T.Sinh(value);
}
