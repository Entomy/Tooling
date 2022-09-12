namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Rotates a value left by a given amount.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IBinaryInteger{TSelf}"/>.</typeparam>
	/// <param name="value">The value which is rotated left by <paramref name="amount"/>.</param>
	/// <param name="amount">The amount by which <paramref name="value"/> is rotated left.</param>
	/// <returns>The result of rotating <paramref name="value"/> left by <paramref name="amount"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T RotateLeft<T>(this T value, Int32 amount) where T : IBinaryInteger<T> => T.RotateLeft(value, amount);
}
