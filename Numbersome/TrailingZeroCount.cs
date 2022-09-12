namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the number of trailing zeros in a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IBinaryInteger{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose trailing zeroes are to be counted.</param>
	/// <returns>The number of trailing zeros in <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T TrailingZeroCount<T>(this T value) where T : IBinaryInteger<T> => T.TrailingZeroCount(value);
}
