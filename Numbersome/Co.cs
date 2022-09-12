namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the compliment of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos compliment is to be computed.</param>
	/// <returns>The compliment of <paramref name="value"/>.</returns>
	public static T Co<T>(this T value) where T : IFloatingPointConstants<T> => (T.Pi / (T.One + T.One)) - value;
}
