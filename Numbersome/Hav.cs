namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the halved versed sine of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/>and <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos halved versed sine is to be computed.</param>
	/// <returns>The halved versed sine of <paramref name="value"/>.</returns>
	public static T Hav<T>(this T value) where T : IFloatingPointConstants<T>, ITrigonometricFunctions<T> => Ver(value) / (T.One + T.One);
}
