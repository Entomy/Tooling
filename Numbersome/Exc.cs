namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the exterior secant compliment of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/> and <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos exterior secant compliment is to be computed.</param>
	/// <returns>The exterior secant compliment of <paramref name="value"/>.</returns>
	public static T Exc<T>(this T value) where T : IFloatingPointConstants<T>, ITrigonometricFunctions<T> => Csc(value) - T.One;
}
