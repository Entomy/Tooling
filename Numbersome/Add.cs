namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Adds two values together to compute their sum.
	/// </summary>
	/// <typeparam name="TLeft">The type of the <paramref name="left"/> addend.</typeparam>
	/// <typeparam name="TRight">The type of the <paramref name="right"/> addend.</typeparam>
	/// <typeparam name="TResult">The type of the returned sum.</typeparam>
	/// <param name="left">The value to which <paramref name="right"/> is added.</param>
	/// <param name="right">The value to which is added to <paramref name="left"/>.</param>
	/// <returns>The sum of <paramref name="left"/> and <paramref name="right"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TResult Add<TLeft, TRight, TResult>(TLeft left, TRight right) where TLeft : IAdditionOperators<TLeft, TRight, TResult> => left + right;
}
