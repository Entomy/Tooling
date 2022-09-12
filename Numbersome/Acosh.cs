namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the hyperbolic arc-cosine of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IHyperbolicFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whose hyperbolic arc-cosine is to be computed.</param>
	/// <returns>The hyperbolic arc-cosine of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Acosh<T>(this T value) where T : IHyperbolicFunctions<T> => T.Acosh(value);
}
