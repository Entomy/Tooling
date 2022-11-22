namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the bitwise-and of two values.
	/// </summary>
	/// <typeparam name="TLeft">The type of the <paramref name="left"/> value.</typeparam>
	/// <typeparam name="TRight">The type of the <paramref name="right"/> value.</typeparam>
	/// <typeparam name="TResult">The type of the return value.</typeparam>
	/// <param name="left">The value to <c>and</c> with <paramref name="right"/>.</param>
	/// <param name="right">The value to <c>and</c> with <paramref name="left"/>.</param>
	/// <returns></returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TResult And<TLeft, TRight, TResult>(TLeft left, TRight right) where TLeft : IBitwiseOperators<TLeft, TRight, TResult> => left & right;
}
