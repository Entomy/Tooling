namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>Computes the absolute of a value.</summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <param name="value">The value for which to get its absolute.</param>
	/// <returns>The absolute of <paramref name="value" />.</returns>
	/// <exception cref="OverflowException">The absolute of <paramref name="value" /> is not representable by <typeparamref name="T"/>.</exception>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Abs<T>(this T value) where T : INumberBase<T> => T.Abs(value);
}
