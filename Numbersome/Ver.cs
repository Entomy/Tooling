namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the versed sine of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/> and <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos versed sine is to be computed.</param>
	/// <returns>The versed sine of <paramref name="value"/>.</returns>
	public static T Ver<T>(this T value) where T : IFloatingPointConstants<T>, ITrigonometricFunctions<T> => T.One - T.Cos(value);
}
