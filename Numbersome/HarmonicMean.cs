namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Averages the <paramref name="values"/>, by harmonic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T HarmonicMean<T>(this T[]? values) where T : IFloatingPoint<T> => HarmonicMean(values.AsSpan());

	/// <summary>
	/// Averages the <paramref name="values"/>, by harmonic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T HarmonicMean<T>(this ArraySegment<T> values) where T : IFloatingPoint<T> => HarmonicMean(values.AsSpan());

	/// <summary>
	/// Averages the <paramref name="values"/>, by harmonic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T HarmonicMean<T>(this Memory<T> values) where T : IFloatingPoint<T> => HarmonicMean(values.Span);

	/// <summary>
	/// Averages the <paramref name="values"/>, by harmonic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T HarmonicMean<T>(this ReadOnlyMemory<T> values) where T : IFloatingPoint<T> => HarmonicMean(values.Span);

	/// <summary>
	/// Averages the <paramref name="values"/>, by harmonic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T HarmonicMean<T>(this Span<T> values) where T : IFloatingPoint<T> => HarmonicMean((ReadOnlySpan<T>)values);

	/// <summary>
	/// Averages the <paramref name="values"/>, by harmonic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T HarmonicMean<T>(this ReadOnlySpan<T> values) where T : IFloatingPoint<T> {
		T sum = T.Zero;
		T count = T.Zero;
		foreach (T value in values) {
			sum += T.One / value;
			count++;
		}
		return count / sum;
	}

	/// <summary>
	/// Averages the <paramref name="values"/>, by harmonic mean.
	/// </summary>
	/// <typeparam name="T">A numeric of <typeparamref name="T"/>.</typeparam>
	/// <param name="values">The values to find the average of.</param>
	/// <returns>The average of the <paramref name="values"/>.</returns>
	public static T HarmonicMean<T>([NotNull] this IEnumerable<T> values) where T : IFloatingPoint<T> {
		if (values is null) {
			throw new ArgumentNullException(nameof(values));
		}
		T sum = T.Zero;
		T count = T.Zero;
		foreach (T value in values) {
			sum += T.One / value;
			count++;
		}
		return count / sum;
	}
}
