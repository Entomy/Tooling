namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes an estimate of the reciprocal of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPointIeee754{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose estimate of the reciprocal is to be computed.</param>
	/// <returns>An estimate of the reciprocal of <paramref name="value"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T ReciprocalEstimate<T>(this T value) where T : IFloatingPointIeee754<T> => T.ReciprocalEstimate(value);
}
