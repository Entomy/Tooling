namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the ceiling of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPoint{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose ceiling is to be computed.</param>
	/// <returns>The ceiling of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Ceiling<T>(this T value) where T : IFloatingPoint<T> => T.Ceiling(value);
}
