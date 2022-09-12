namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines if a value represents a complex number.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be checked.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is a complex number; otherwise, <see langword="false"/>.</returns>
	/// <remarks>
	/// This function returns <see langword="false"/> for a complex number <c>a + bi</c> where <c>b</c> is <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean IsComplexNumber<T>(this T value) where T : INumberBase<T> => T.IsComplexNumber(value);
}
