namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Averages the <paramref name="values"/>, by arithmetic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T ArithmeticMean<T>(this T[]? values) where T : INumberBase<T> => ArithmeticMean(values.AsSpan());

	/// <summary>
	/// Averages the <paramref name="values"/>, by arithmetic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T ArithmeticMean<T>(this ArraySegment<T> values) where T : INumberBase<T> => ArithmeticMean(values.AsSpan());

	/// <summary>
	/// Averages the <paramref name="values"/>, by arithmetic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T ArithmeticMean<T>(this Memory<T> values) where T : INumberBase<T> => ArithmeticMean(values.Span);

	/// <summary>
	/// Averages the <paramref name="values"/>, by arithmetic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T ArithmeticMean<T>(this ReadOnlyMemory<T> values) where T : INumberBase<T> => ArithmeticMean(values.Span);

	/// <summary>
	/// Averages the <paramref name="values"/>, by arithmetic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T ArithmeticMean<T>(this Span<T> values) where T : INumberBase<T> => ArithmeticMean((ReadOnlySpan<T>)values);

	/// <summary>
	/// Averages the <paramref name="values"/>, by arithmetic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T ArithmeticMean<T>(this ReadOnlySpan<T> values) where T : INumberBase<T> {
		T sum = T.Zero;
		T count = T.Zero;
		foreach (T value in values) {
			sum += value;
			count++;
		}
		return sum / count;
	}

	/// <summary>
	/// Averages the <paramref name="values"/>, by arithmetic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T ArithmeticMean<T>([NotNull] this IEnumerable<T> values) where T : INumberBase<T> {
		if (values is null) {
			throw new ArgumentNullException(nameof(values));
		}
		T sum = T.Zero;
		T count = T.Zero;
		foreach (T value in values) {
			sum += value;
			count++;
		}
		return sum / count;
	}
}
