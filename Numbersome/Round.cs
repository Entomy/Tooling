namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Rounds a value to the nearest integer using the default rounding mode (<see cref="MidpointRounding.ToEven"/>).
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPoint{TSelf}"/>.</typeparam>
	/// <param name="value">The value to round.</param>
	/// <returns>The result of rounding <paramref name="value"/> to the nearest integer using the default rounding mode.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("Maintainability", "AV1551:Method overload should call another overload", Justification = "Instead, this directly calls the static abstract that Microsoft wrote, essentially still 'calling an overload'.")]
	public static T Round<T>(this T value) where T : IFloatingPoint<T> => T.Round(value);

	/// <summary>
	/// Rounds a value to a specified number of fractional-digits using the default rounding mode (<see cref="MidpointRounding.ToEven"/>).
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPoint{TSelf}"/>.</typeparam>
	/// <param name="value">The value to round.</param>
	/// <param name="digits">The number of fractional digits to which <paramref name="value"/> should be rounded.</param>
	/// <returns>The result of rounding <paramref name="value"/> to <paramref name="digits"/> fractional-digits using the default rounding mode.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("Maintainability", "AV1551:Method overload should call another overload", Justification = "Instead, this directly calls the static abstract that Microsoft wrote, essentially still 'calling an overload'.")]
	public static T Round<T>(this T value, Int32 digits) where T : IFloatingPoint<T> => T.Round(value, digits);

	/// <summary>
	/// Rounds a value to the nearest integer using the specified rounding mode.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPoint{TSelf}"/>.</typeparam>
	/// <param name="value">The value to round.</param>
	/// <param name="mode">The mode under which <paramref name="value"/> should be rounded.</param>
	/// <returns>The result of rounding <paramref name="value"/> to the nearest integer using <paramref name="mode"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("Maintainability", "AV1551:Method overload should call another overload", Justification = "Instead, this directly calls the static abstract that Microsoft wrote, essentially still 'calling an overload'.")]
	public static T Round<T>(this T value, MidpointRounding mode) where T : IFloatingPoint<T> => T.Round(value, mode);

	/// <summary>
	/// Rounds a value to a specified number of fractional-digits using the specified rounding mode.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IFloatingPoint{TSelf}"/>.</typeparam>
	/// <param name="value">The value to round.</param>
	/// <param name="digits">The number of fractional digits to which <paramref name="value"/> should be rounded.</param>
	/// <param name="mode">The mode under which <paramref name="value"/> should be rounded.</param>
	/// <returns>The result of rounding <paramref name="value"/> to <paramref name="digits"/> fractional-digits using <paramref name="mode"/>.</returns>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SuppressMessage("Maintainability", "AV1551:Method overload should call another overload", Justification = "Instead, this directly calls the static abstract that Microsoft wrote, essentially still 'calling an overload'.")]
	public static T Round<T>(this T value, Int32 digits, MidpointRounding mode) where T : IFloatingPoint<T> => T.Round(value, digits, mode);
}
