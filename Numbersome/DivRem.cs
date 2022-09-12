namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the quotient and remainder of two values.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IBinaryInteger{TSelf}"/>.</typeparam>
	/// <param name="dividend">The value which <paramref name="divisor"/> divides.</param>
	/// <param name="divisor">The value which divides the <paramref name="dividend"/>.</param>
	/// <returns>The quotient and remainder of <paramref name="dividend"/> divided by <paramref name="divisor"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static (T Quotient, T Remainder) DivRem<T>(this T dividend, T divisor) where T : IBinaryInteger<T> => T.DivRem(dividend, divisor);
}
