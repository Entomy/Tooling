namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the number of leading zeros in a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IBinaryInteger{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose leading zeroes are to be counted.</param>
	/// <returns>The number of leading zeros in value.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T LeadingZeroCount<T>(this T value) where T : IBinaryInteger<T> => T.LeadingZeroCount(value);
}
