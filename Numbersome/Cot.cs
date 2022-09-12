namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the tangent complement of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/> and <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos tangent compliment is to be computed.</param>
	/// <returns>The tangent compliment of <paramref name="value"/>.</returns>
	public static T Cot<T>(this T value) where T : INumberBase<T>, ITrigonometricFunctions<T> => T.One / T.Tan(value);
}
