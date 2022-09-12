﻿namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the hyperbolic sine of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IHyperbolicFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whose hyperbolic sine is to be computed.</param>
	/// <returns>The hyperbolic sine of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Sinh<T>(this T value) where T : IHyperbolicFunctions<T> => T.Sinh(value);
}
