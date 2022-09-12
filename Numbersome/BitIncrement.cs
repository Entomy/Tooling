namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Increments a value to the smallest value that compares greater than a given value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointIeee754{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be bitwise incremented.</param>
	/// <returns>The smallest value that compares greater than <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T BitIncrement<T>(this T value) where T : IFloatingPointIeee754<T> => T.BitIncrement(value);
}
