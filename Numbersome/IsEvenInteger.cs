namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines if a value represents an even integral number.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be checked.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is an even integer; otherwise, <see langword="false"/>.</returns>
	/// <remarks>
	/// <para>This method correctly handles floating-point values and so <c>2.0</c> will return <see langword="true"/> while <c>2.2</c> will return <see langword="false"/>.</para>
	/// <para>A return value of <see langword="false"/> does not imply that <see cref="IsOddInteger{T}(T)"/> will return <see langword="true"/>. A number with a fractional portion, for example, <c>3.3</c>, is not even or odd.</para>
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean IsEvenInteger<T>(this T value) where T : INumberBase<T> => T.IsEvenInteger(value);
}
