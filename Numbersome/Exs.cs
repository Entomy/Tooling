namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the exterior secant of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/> and <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos exterior secant is to be computed.</param>
	/// <returns>The exterior secant of <paramref name="value"/>.</returns>
	public static T Exs<T>(this T value) where T : IFloatingPointConstants<T>, ITrigonometricFunctions<T> => Sec(value) - T.One;
}
