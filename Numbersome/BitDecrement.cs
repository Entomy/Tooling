namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Decrements a value to the smallest value that compares less than a given value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointIeee754{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be bitwise decremented.</param>
	/// <returns>The smallest value that compares less than <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T BitDecrement<T>(this T value) where T : IFloatingPointIeee754<T> => T.BitDecrement(value);
}
