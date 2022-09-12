namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the number of bits that are set in a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IBinaryInteger{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose set bits are to be counted.</param>
	/// <returns>The number of set bits in <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T PopCount<T>(this T value) where T : IBinaryInteger<T> => T.PopCount(value);
}
