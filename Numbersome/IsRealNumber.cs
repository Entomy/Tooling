namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines if a value represents a real number.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be checked.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is a real number; otherwise, <see langword="false"/>.</returns>
	/// <remarks>This function returns <see langword="true"/> for a complex number <c>a + bi</c> where <c>b</c> is <see cref="INumberBase{TSelf}.Zero"/>.</remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean IsRealNumber<T>(this T value) where T : INumberBase<T> => T.IsRealNumber(value);
}
