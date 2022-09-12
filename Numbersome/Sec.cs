namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the secant of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/> and <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos secant is to be computed.</param>
	/// <returns>The secant of <paramref name="value"/>.</returns>
	public static T Sec<T>(this T value) where T : IFloatingPointConstants<T>, ITrigonometricFunctions<T> => T.One / T.Cos(value);
}
