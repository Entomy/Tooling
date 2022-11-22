namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the unary negation of a value.
	/// </summary>
	/// <typeparam name="TValue">The type of the <paramref name="value"/>.</typeparam>
	/// <typeparam name="TResult">The type of the return value.</typeparam>
	/// <param name="value">The value for which to compute the unary negation.</param>
	/// <returns>The unary negation of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TResult Negate<TValue, TResult>(TValue value) where TValue : IUnaryNegationOperators<TValue, TResult> => -value;
}
