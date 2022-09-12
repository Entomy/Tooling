namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxNumber<T>(this T[]? values) where T : IMinMaxValue<T>, INumber<T> => MaxNumber(values.AsSpan());

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxNumber<T>(this ArraySegment<T> values) where T : IMinMaxValue<T>, INumber<T> => MaxNumber(values.AsSpan());

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxNumber<T>(this Memory<T> values) where T : IMinMaxValue<T>, INumber<T> => MaxNumber(values.Span);

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxNumber<T>(this ReadOnlyMemory<T> values) where T : IMinMaxValue<T>, INumber<T> => MaxNumber(values.Span);

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxNumber<T>(this Span<T> values) where T : IMinMaxValue<T>, INumber<T> => MaxNumber((ReadOnlySpan<T>)values);

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxNumber<T>(this ReadOnlySpan<T> values) where T : IMinMaxValue<T>, INumber<T> {
		T max = T.MinValue;
		foreach (T value in values) {
			max = T.MaxNumber(value, max);
		}
		return max;
	}

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater and returning the other value if an input is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximumNumber function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T MaxNumber<T>([NotNull] this IEnumerable<T> values) where T : IMinMaxValue<T>, INumber<T> {
		if (values is null) {
			throw new ArgumentNullException(nameof(values));
		}
		T max = T.MinValue;
		foreach (T value in values) {
			max = T.MaxNumber(value, max);
		}
		return max;
	}
}
