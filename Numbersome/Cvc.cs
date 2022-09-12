﻿namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the versed compliment sine compliment of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointConstants{TSelf}"/> and <see cref="ITrigonometricFunctions{TSelf}"/>.</typeparam>
	/// <param name="value">The value, in radians, whos versed sine compliment is to be computed.</param>
	/// <returns>The versed compliment sine compliment of <paramref name="value"/>.</returns>
	public static T Cvc<T>(this T value) where T : IFloatingPointConstants<T>, ITrigonometricFunctions<T> => T.One + T.Sin(value);
}
