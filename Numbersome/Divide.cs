namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Divides one value by another to compute their quotient.
	/// </summary>
	/// <typeparam name="TLeft">The type of the <paramref name="left"/> dividend.</typeparam>
	/// <typeparam name="TRight">The type of the <paramref name="right"/> divisor.</typeparam>
	/// <typeparam name="TResult">The type of the result quotient.</typeparam>
	/// <param name="left">The value which <paramref name="right"/> divides; the dividend.</param>
	/// <param name="right">The value which divides <paramref name="left"/>; the divisor.</param>
	/// <returns>The quotient of <paramref name="left"/> divided by <paramref name="right"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static TResult Divide<TLeft, TRight, TResult>(TLeft left, TRight right) where TLeft : IDivisionOperators<TLeft, TRight, TResult> => left / right;
}
