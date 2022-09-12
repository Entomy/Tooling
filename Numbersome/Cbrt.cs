namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the cube-root of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IRootFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose cube-root is to be computed.</param>
	/// <returns>The cube-root of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Cbrt<T>(this T value) where T : IRootFunctions<T> => T.Cbrt(value);
}
