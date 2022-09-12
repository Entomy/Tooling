namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes an estimate of the reciprocal square root of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointIeee754{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose estimate of the reciprocal square root is to be computed.</param>
	/// <returns>An estimate of the reciprocal square root of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ReciprocalSqrtEstimate<T>(this T value) where T : IFloatingPointIeee754<T> => T.ReciprocalSqrtEstimate(value);
}
