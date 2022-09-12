namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the floor of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPoint{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose floor is to be computed.</param>
	/// <returns>The floor of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Floor<T>(this T value) where T : IFloatingPoint<T> => T.Floor(value);
}
