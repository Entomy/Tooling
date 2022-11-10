namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Divides two values together to compute their modulus or remainder.
	/// </summary>
	/// <typeparam name="TLeft">The type of the <paramref name="left"/> value.</typeparam>
	/// <typeparam name="TRight">The type of the <paramref name="right"/> value.</typeparam>
	/// <typeparam name="TResult">The type of the result value.</typeparam>
	/// <param name="left">The value which <paramref name="right"/> divides; the dividend.</param>
	/// <param name="right">The value which divides <paramref name="left"/>; the divisor.</param>
	/// <returns>The modulus or remainder of <paramref name="left"/> divided by <paramref name="right"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static TResult Modulus<TLeft, TRight, TResult>(TLeft left, TRight right) where TLeft : IModulusOperators<TLeft, TRight, TResult> => left % right;
}
