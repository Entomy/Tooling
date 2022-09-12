namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the n-th root of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IRootFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose <paramref name="n"/>-th root is to be computed.</param>
	/// <param name="n">The degree of the root to be computed.</param>
	/// <returns>The <paramref name="n"/>-th root of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Root<T>(this T value, Int32 n) where T : IRootFunctions<T> => T.RootN(value, n);
}
