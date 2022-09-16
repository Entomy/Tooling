namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Compares two values to compute which is greater.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="INumber{TSelf}"/>.</typeparam>
	/// <param name="first">The value to compare to <paramref name="second"/>.</param>
	/// <param name="second">The value to compare to <paramref name="first"/>.</param>
	/// <returns><paramref name="first"/> if it is greater than <paramref name="second"/>; otherwise, <paramref name="second"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Max<T>(this T first, T second) where T : INumber<T> => T.Max(first, second);

	/// <summary>
	/// Compares the values to compute which is greater.
	/// </summary>
	/// <typeparam name="T">A numeric of <see cref="IMinMaxValue{TSelf}"/> and <see cref="INumber{TSelf}"/>.</typeparam>
	/// <param name="first">The first of the values to compare.</param>
	/// <param name="others">The other values to compare.</param>
	/// <returns>The greatest of the values.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Max<T>(this T first, params T[] others) where T : IMinMaxValue<T>, INumber<T> {
		if (others is null) {
			return first;
		}
		T max = T.MinValue;
		foreach (T value in others) {
			max = T.Max(value, max);
		}
		return T.Max(first, max);
	}

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Max<T>(this T[]? values) where T : IMinMaxValue<T>, INumber<T> => Max(values.AsSpan());

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Max<T>(this ArraySegment<T> values) where T : IMinMaxValue<T>, INumber<T> => Max(values.AsSpan());

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Max<T>(this Memory<T> values) where T : IMinMaxValue<T>, INumber<T> => Max(values.Span);

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Max<T>(this ReadOnlyMemory<T> values) where T : IMinMaxValue<T>, INumber<T> => Max(values.Span);

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Max<T>(this Span<T> values) where T : IMinMaxValue<T>, INumber<T> => Max((ReadOnlySpan<T>)values);

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Max<T>(this ReadOnlySpan<T> values) where T : IMinMaxValue<T>, INumber<T> {
		T max = T.MinValue;
		foreach (T value in values) {
			max = T.Max(value, max);
		}
		return max;
	}

	/// <summary>
	/// Compares the <paramref name="values"/> to compute which is greater.
	/// </summary>
	/// <param name="values">The values to compare.</param>
	/// <returns>The greatest of the <paramref name="values"/>.</returns>
	/// <remarks>
	/// For <see cref="IFloatingPoint{TSelf}"/>, this method matches the IEEE 754:2019 maximum function. This requires <see cref="IFloatingPointIeee754{TSelf}.NaN"/> inputs to be propagated back to the caller and for <see cref="IFloatingPointIeee754{TSelf}.NegativeZero"/> to be treated as less than <see cref="INumberBase{TSelf}.Zero"/>.
	/// </remarks>
	public static T Max<T>([NotNull] this IEnumerable<T> values) where T : IMinMaxValue<T>, INumber<T> {
		if (values is null) {
			throw new ArgumentNullException(nameof(values));
		}
		T max = T.MinValue;
		foreach (T value in values) {
			max = T.Max(value, max);
		}
		return max;
	}
}
