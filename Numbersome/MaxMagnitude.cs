namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitude function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitude<T>(this T[]? values) where T : IMinMaxValue<T>, INumberBase<T> => MaxMagnitude(values.AsSpan());

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitude function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitude<T>(this ArraySegment<T> values) where T : IMinMaxValue<T>, INumberBase<T> => MaxMagnitude(values.AsSpan());

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitude function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitude<T>(this Memory<T> values) where T : IMinMaxValue<T>, INumberBase<T> => MaxMagnitude(values.Span);

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitude function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitude<T>(this ReadOnlyMemory<T> values) where T : IMinMaxValue<T>, INumberBase<T> => MaxMagnitude(values.Span);

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitude function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitude<T>(this Span<T> values) where T : IMinMaxValue<T>, INumberBase<T> => MaxMagnitude((ReadOnlySpan<T>)values);

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitude function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitude<T>(this ReadOnlySpan<T> values) where T : IMinMaxValue<T>, INumberBase<T> {
		T max = T.MinValue;
		foreach (T value in values) {
			max = T.MaxMagnitude(value, max);
		}
		return max;
	}

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumMagnitude function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxMagnitude<T>([NotNull] this IEnumerable<T> values) where T : IMinMaxValue<T>, INumberBase<T> {
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
