namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the square-root of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IRootFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose square-root is to be computed.</param>
	/// <returns>The square-root of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Sqrt<T>(this T value) where T : IRootFunctions<T> => T.Sqrt(value);
}
