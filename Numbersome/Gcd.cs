namespace System;

using System.Numerics;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Finds the greatest common divisor of two values.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumber{TSelf}"/>.</typeparam>
	/// <param name="value">This value to get the greatest common divisor of.</param>
	/// <param name="other">The other value to get the greatest common divisor of.</param>
	/// <returns>The greatest common divisor of <paramref name="value"/> and <paramref name="other"/>.</returns>
	public static T Gcd<T>(this T value, T other) where T : INumber<T> {
		T gcd = T.One;
		for (T i = T.One; i <= value && i <= other; i++) {
			if (value % i == T.Zero && other % i == T.Zero) {
				gcd = i;
			}
		}
		return gcd;
	}
}
