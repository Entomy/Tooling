namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines if a value represents an integral number.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumberBase{TSelf}"/>.</typeparam>
	/// <param name="value">The value to be checked.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is an integer; otherwise, <see langword="false"/>.</returns>
	/// <remarks>
	///	This method correctly handles floating-point values and so <c>2.0</c> and <c>3.0</c> will return <see langword="true"/> while <c>2.2</c> and <c>3.3</c> will return <see langword="false"/>.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean IsInteger<T>(this T value) where T : INumberBase<T> => T.IsInteger(value);
}
