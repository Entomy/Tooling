namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Compares two values to compute which has the lesser magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MinMagnitudeNumber<T>(this T[]? values) where T : IMinMaxValue<T>, INumber<T> => MinMagnitudeNumber(values.AsSpan());

	/// <summary>
	/// Compares two values to compute which has the lesser magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MinMagnitudeNumber<T>(this ArraySegment<T> values) where T : IMinMaxValue<T>, INumber<T> => MinMagnitudeNumber(values.AsSpan());

	/// <summary>
	/// Compares two values to compute which has the lesser magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MinMagnitudeNumber<T>(this Memory<T> values) where T : IMinMaxValue<T>, INumber<T> => MinMagnitudeNumber(values.Span);

	/// <summary>
	/// Compares two values to compute which has the lesser magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MinMagnitudeNumber<T>(this ReadOnlyMemory<T> values) where T : IMinMaxValue<T>, INumber<T> => MinMagnitudeNumber(values.Span);

	/// <summary>
	/// Compares two values to compute which has the lesser magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MinMagnitudeNumber<T>(this Span<T> values) where T : IMinMaxValue<T>, INumber<T> => MinMagnitudeNumber((ReadOnlySpan<T>)values);

	/// <summary>
	/// Compares two values to compute which has the lesser magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MinMagnitudeNumber<T>(this ReadOnlySpan<T> values) where T : IMinMaxValue<T>, INumber<T> {
		T min = T.MaxValue;
		foreach (T value in values) {
			min = T.MinMagnitudeNumber(value, min);
		}
		return min;
	}

	/// <summary>
	/// Compares two values to compute which has the lesser magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MinMagnitudeNumber<T>([NotNull] this IEnumerable<T> values) where T : IMinMaxValue<T>, INumber<T> {
		if (values is null) {
			throw new ArgumentNullException(nameof(values));
		}
		T min = T.MaxValue;
		foreach (T value in values) {
			min = T.MinMagnitudeNumber(value, min);
		}
		return min;
	}
}
