namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the fused multiply-add of three values.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointIeee754{TSelf}"/>.</typeparam>
	/// <param name="multiplicands">The values which are multiplied together.</param>
	/// <param name="addend">The value that is added to the product of the <paramref name="multiplicands"/>.</param>
	/// <returns>The result of the product of the <paramref name="multiplicands"/> plus <paramref name="addend"/> computed as one ternary operation.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T FusedMultiplyAdd<T>(this (T Left, T Right) multiplicands, T addend) where T : IFloatingPointIeee754<T> => T.FusedMultiplyAdd(multiplicands.Left, multiplicands.Right, addend);
}
