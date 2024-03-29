﻿namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is lesser.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Min<T>(this T[]? values) where T : IMinMaxValue<T>, INumber<T> => Min(values.AsSpan());

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is lesser.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Min<T>(this ArraySegment<T> values) where T : IMinMaxValue<T>, INumber<T> => Min(values.AsSpan());

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is lesser.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Min<T>(this Memory<T> values) where T : IMinMaxValue<T>, INumber<T> => Min(values.Span);

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is lesser.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Min<T>(this ReadOnlyMemory<T> values) where T : IMinMaxValue<T>, INumber<T> => Min(values.Span);

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is lesser.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Min<T>(this Span<T> values) where T : IMinMaxValue<T>, INumber<T> => Min((ReadOnlySpan<T>)values);

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is lesser.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Min<T>(this ReadOnlySpan<T> values) where T : IMinMaxValue<T>, INumber<T> {
		T min = T.MaxValue;
		foreach (T value in values) {
			min = T.Min(value, min);
		}
		return min;
	}

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is lesser.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The least of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 minimum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Min<T>([NotNull] this IEnumerable<T> values) where T : IMinMaxValue<T>, INumber<T> {
		if (values is null) {
			throw new ArgumentNullException(nameof(values));
		}
		T min = T.MaxValue;
		foreach (T value in values) {
			min = T.Min(value, min);
		}
		return min;
	}
}
