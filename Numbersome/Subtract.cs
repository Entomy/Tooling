namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Subtracts two values to compute their difference.
	/// </summary>
	/// <typeparam name="TLeft">The type of the <paramref name="left"/> minuend.</typeparam>
	/// <typeparam name="TRight">The type of the <paramref name="right"/> subtrahend.</typeparam>
	/// <typeparam name="TResult">The type of the product value.</typeparam>
	/// <param name="left">The value from which <paramref name="right"/> is subtracted; the minuend.</param>
	/// <param name="right">The value which is subtracted from <paramref name="left"/>; the subtrahend.</param>
	/// <returns>The value of <paramref name="right"/> subtracted from <paramref name="left"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static TResult Subtract<TLeft, TRight, TResult>(TLeft left, TRight right) where TLeft : ISubtractionOperators<TLeft, TRight, TResult> => left - right;
}
