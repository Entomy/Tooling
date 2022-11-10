namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the unary plus of a value.
	/// </summary>
	/// <typeparam name="TValue">The type of the <paramref name="value"/>.</typeparam>
	/// <typeparam name="TResult">The type of the return value.</typeparam>
	/// <param name="value">The value for which to compute the unary plus.</param>
	/// <returns>The unary plus of value.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static TResult Assert<TValue, TResult>(TValue value) where TValue : IUnaryPlusOperators<TValue, TResult> => +value;
}
