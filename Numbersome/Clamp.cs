namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Clamps a value to an inclusive minimum and maximum value.
	/// </summary>
	/// <param name="value">The value to clamp.</param>
	/// <param name="bounds">The inclusive bounds to which <paramref name="value"/> should clamp.</param>
	/// <returns>The result of clamping <paramref name="value"/> to the inclusive range of <paramref name="bounds"/>.</returns>
	/// <exception cref="ArgumentException"><paramref name="bounds"/>.<see cref="Range.Start"/> is greater than <paramref name="bounds"/>.<see cref="Range.End"/>.</exception>
	public static Int32 Clamp(this Int32 value, Range bounds) {
		(Int32 start, Int32 length) = bounds.GetOffsetAndLength(Int32.MaxValue);
		return value.Clamp(start, start + length);
	}

	/// <summary>
	/// Clamps a value to an inclusive minimum and maximum value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumber{TSelf}"/>.</typeparam>
	/// <param name="value">The value to clamp.</param>
	/// <param name="min">The inclusive minimum to which <paramref name="value"/> should clamp.</param>
	/// <param name="max">The inclusive maximum to which <paramref name="value"/> should clamp.</param>
	/// <returns>The result of clamping <paramref name="value"/> to the inclusive range of <paramref name="min"/> and <paramref name="max"/>.</returns>
	/// <exception cref="ArgumentException"><paramref name="min"/> is greater than <paramref name="max"/>.</exception>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Clamp<T>(this T value, T min, T max) where T : INumber<T> => T.Clamp(value, min, max);
}
