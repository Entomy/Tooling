namespace System;

using System.Numerics;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Finds the least common multiple of two values.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumber{TSelf}"/>.</typeparam>
	/// <param name="value">This value to get the least common multiple of.</param>
	/// <param name="other">The other value to get the least common multipleof.</param>
	/// <returns>The least common multiple of <paramref name="value"/> and <paramref name="other"/>.</returns>
	public static T Lcm<T>(this T value, T other) where T : INumber<T> => (value * other) / Gcd(value, other);
}
