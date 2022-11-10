namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Multiplies two values together to compute their product.
	/// </summary>
	/// <typeparam name="TLeft">The type of the <paramref name="left"/> multiplicand.</typeparam>
	/// <typeparam name="TRight">The type of the <paramref name="right"/> multiplicand.</typeparam>
	/// <typeparam name="TResult">The type of the result product.</typeparam>
	/// <param name="left">The value which <paramref name="right"/> multiplies; the multiplicand.</param>
	/// <param name="right">The value which multiplies <paramref name="left"/>; the multiplicand.</param>
	/// <returns>The product of <paramref name="left"/> </returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static TResult Multiply<TLeft, TRight, TResult>(TLeft left, TRight right) where TLeft : IMultiplyOperators<TLeft, TRight, TResult> => left * right;
}
