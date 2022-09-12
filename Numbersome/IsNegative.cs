namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines if a value is negative.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be checked.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is negative; otherwise, <see langword="false"/>.</returns>
	/// <remarks>
	/// A return value of <see langword="false"/> does not imply that <see cref="IsPositive{T}(T)"/> will return <see langword="true"/>. A complex number, <c>a + bi</c> for non-zero <c>b</c>, is not positive or negative.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean IsNegative<T>(this T value) where T : INumberBase<T> => T.IsNegative(value);
}
