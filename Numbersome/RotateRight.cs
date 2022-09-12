namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Rotates a value right by a given amount.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IBinaryInteger{TSelf}"/>.</typeparam>
	/// <param name="value">The value which is rotated right by <paramref name="amount"/>.</param>
	/// <param name="amount">The amount by which <paramref name="value"/> is rotated right.</param>
	/// <returns>The result of rotating <paramref name="value"/> right by <paramref name="amount"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T RotateRight<T>(this T value, Int32 amount) where T : IBinaryInteger<T> => T.RotateLeft(value, amount);
}
