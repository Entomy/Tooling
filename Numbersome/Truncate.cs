namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Truncates a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPoint{TSelf}"/>.</typeparam>
	/// <param name="value">The value to truncate.</param>
	/// <returns>The truncation of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Truncate<T>(this T value) where T : IFloatingPoint<T> => T.Truncate(value);
}
