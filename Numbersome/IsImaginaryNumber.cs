namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines if a value represents an imaginary number.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be checked.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is an imaginary number; otherwise, <see langword="false"/>.</returns>
	/// <remarks>
	/// This function returns <see langword="false"/> for a complex number <c>a + bi</c> where <c>a</c> is non-zero.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean IsImaginaryNumber<T>(this T value) where T : INumberBase<T> => T.IsImaginaryNumber(value);
}
