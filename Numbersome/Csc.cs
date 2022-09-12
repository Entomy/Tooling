namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the secant compliment of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/> and <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos secant compliment is to be computed.</param>
	/// <returns>The secant compliment of <paramref name="value"/>.</returns>
	public static T Csc<T>(this T value) where T : IFloatingPointConstants<T>, ITrigonometricFunctions<T> => T.One / T.Sin(value);
}
