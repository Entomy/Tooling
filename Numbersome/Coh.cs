namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the hyperbolic compliment of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IHyperbolicFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos compliment is to be computed.</param>
	/// <returns>The hyperbolic compliment of <paramref name="value"/>.</returns>
	public static T Coh<T>(this T value) where T : IHyperbolicFunctions<T> => (T.Pi / (T.One + T.One)) - value;
}
