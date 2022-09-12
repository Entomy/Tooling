namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Compares two values to compute which has the greater magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitudeNumber<T>(this T[]? values) where T : IMinMaxValue<T>, INumberBase<T> => MaxMagnitudeNumber(values.AsSpan());

	/// <summary>
	/// Compares two values to compute which has the greater magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitudeNumber<T>(this ArraySegment<T> values) where T : IMinMaxValue<T>, INumberBase<T> => MaxMagnitudeNumber(values.AsSpan());

	/// <summary>
	/// Compares two values to compute which has the greater magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitudeNumber<T>(this Memory<T> values) where T : IMinMaxValue<T>, INumberBase<T> => MaxMagnitudeNumber(values.Span);

	/// <summary>
	/// Compares two values to compute which has the greater magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitudeNumber<T>(this ReadOnlyMemory<T> values) where T : IMinMaxValue<T>, INumberBase<T> => MaxMagnitudeNumber(values.Span);

	/// <summary>
	/// Compares two values to compute which has the greater magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitudeNumber<T>(this Span<T> values) where T : IMinMaxValue<T>, INumberBase<T> => MaxMagnitudeNumber((ReadOnlySpan<T>)values);

	/// <summary>
	/// Compares two values to compute which has the greater magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitudeNumber<T>(this ReadOnlySpan<T> values) where T : IMinMaxValue<T>, INumberBase<T> {
		T max = T.MinValue;
		foreach (T value in values) {
			max = T.MaxMagnitude(value, max);
		}
		return max;
	}

	/// <summary>
	/// Compares two values to compute which has the greater magnitude and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitudeNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitudeNumber<T>([NotNull] this IEnumerable<T> values) where T : IMinMaxValue<T>, INumberBase<T> {
		if (values is null) {
			throw new ArgumentNullException(nameof(values));
		}
		T max = T.MinValue;
		foreach (T value in values) {
			max = T.MaxMagnitude(value, max);
		}
		return max;
	}
}
