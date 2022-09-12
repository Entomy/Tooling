namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines if a value represents an odd integral number.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be checked.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is an odd integer; otherwise, <see langword="false"/>.</returns>
	/// <remarks>
	///	<para>This method correctly handles floating-point values and so <c>3.0</c> will return <see langword="true"/> while <c>3.3</c> will return <see langword="false"/>.</para>
	///	<para>A return value of false does not imply that IsEvenInteger(TSelf) will return true. A number with a fractional portion, for example, 3.3, is not even or odd.</para>
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean IsOddInteger<T>(this T value) where T : INumberBase<T> => T.IsOddInteger(value);
}
