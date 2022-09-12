namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Computes the sign of a value.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumber{TSelf}"/>.</typeparam>
	/// <param name="value">The value whose sign is to be computed.</param>
	/// <returns>A positive value if <paramref name="value"/> is positive, <see cref="INumberBase{TSelf}.Zero"/> if <paramref name="value"/> is zero, and a negative value if <paramref name="value"/> is negative.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Int32 Sign<T>(this T value) where T : INumber<T> => T.Sign(value);
}
