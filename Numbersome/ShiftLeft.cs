namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Shifts a value left by a given amount.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IShiftOperators{TSelf, TOther, TResult}"/>.</typeparam>
	/// <param name="value">The value which is shifted left by <paramref name="amount"/>.</param>
	/// <param name="amount">The amount by which <paramref name="value"/> is shifted left.</param>
	/// <returns>The result of shifting <paramref name="value"/> left by <paramref name="amount"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ShiftLeft<T>(this T value, Int32 amount) where T : IShiftOperators<T, Int32, T> => value << amount;
}
