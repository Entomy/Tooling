namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the ones-complement representation of a given value.
	/// </summary>
	/// <typeparam name="TValue">The type of the <paramref name="value"/>.</typeparam>
	/// <typeparam name="TResult">The type of the return value.</typeparam>
	/// <param name="value">The value for which to compute the ones-complement.</param>
	/// <returns>The ones-complement of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static TResult OnesComplement<TValue, TResult>(TValue value) where TValue : IBitwiseOperators<TValue, TValue, TResult> => ~value;
}
