namespace System;

public static partial class CollectathonExtensions {
	#region Grow(Collection)
	/// <summary>
	/// Grows the collection by a computed factor.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <returns>A new <see cref="Array"/> that is larger than the <paramref name="source"/>, and contains the elements from the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	[return: NotNullIfNotNull("source")]
	public static T[]? Grow<T>(this T[]? source) => source is not null ? GrowKernel<T>(source.AsSpan()) : null;

	/// <summary>
	/// Grows the collection by a computed factor.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <returns>A new <see cref="ArraySegment{T}"/> that is larger than the <paramref name="source"/>, and contains the elements from the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> Grow<T>(this ArraySegment<T> source) => GrowKernel<T>(source.AsSpan());

	/// <summary>
	/// Grows the collection by a computed factor.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <returns>A new <see cref="Memory{T}"/> that is larger than the <paramref name="source"/>, and contains the elements from the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<T> Grow<T>(this Memory<T> source) => GrowKernel<T>(source.Span);

	/// <summary>
	/// Grows the collection by a computed factor.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <returns>A new <see cref="ReadOnlyMemory{T}"/> that is larger than the <paramref name="source"/>, and contains the elements from the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> Grow<T>(this ReadOnlyMemory<T> source) => GrowKernel(source.Span);

	/// <summary>
	/// Grows the collection by a computed factor.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <returns>A new <see cref="Span{T}"/> that is larger than the <paramref name="source"/>, and contains the elements from the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<T> Grow<T>(this Span<T> source) => GrowKernel((ReadOnlySpan<T>)source);

	/// <summary>
	/// Grows the collection by a computed factor.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <returns>A new <see cref="ReadOnlySpan{T}"/> that is larger than the <paramref name="source"/>, and contains the elements from the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> Grow<T>(this ReadOnlySpan<T> source) => GrowKernel(source);
	#endregion

	#region Grow(Collection, Int32)
	/// <summary>
	/// Grows the collection by a computed factor, to at least a specified <paramref name="minimum"/>.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <param name="minimum">The minimum allowed size.</param>
	/// <returns>A new <see cref="Memory{T}"/> that is at least the <paramref name="minimum"/> size, and contains the elements from the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static T[]? Grow<T>(this T[]? source, Int32 minimum) {
		if (source is not null) {
			return GrowKernel<T>(source.AsSpan(), minimum);
		} else {
			return null;
		}
	}

	/// <summary>
	/// Grows the collection by a computed factor, to at least a specified <paramref name="minimum"/>.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <param name="minimum">The minimum allowed size.</param>
	/// <returns>A new <see cref="ArraySegment{T}"/> that is at least the <paramref name="minimum"/> size, and contains the elements from the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> Grow<T>(this ArraySegment<T> source, Int32 minimum) => GrowKernel<T>(source.AsSpan(), minimum);

	/// <summary>
	/// Grows the collection by a computed factor, to at least a specified <paramref name="minimum"/>.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <param name="minimum">The minimum allowed size.</param>
	/// <returns>A new <see cref="Memory{T}"/> that is at least the <paramref name="minimum"/> size, and contains the elements from the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<T> Grow<T>(this Memory<T> source, Int32 minimum) => GrowKernel<T>(source.Span, minimum);

	/// <summary>
	/// Grows the collection by a computed factor, to at least a specified <paramref name="minimum"/>.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <param name="minimum">The minimum allowed size.</param>
	/// <returns>A new <see cref="ReadOnlyMemory{T}"/> that is at least the <paramref name="minimum"/> size, and contains the elements from the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> Grow<T>(this ReadOnlyMemory<T> source, Int32 minimum) => GrowKernel(source.Span, minimum);

	/// <summary>
	/// Grows the collection by a computed factor, to at least a specified <paramref name="minimum"/>.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <param name="minimum">The minimum allowed size.</param>
	/// <returns>A new <see cref="Span{T}"/> that is at least the <paramref name="minimum"/> size, and contains the elements from the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<T> Grow<T>(this Span<T> source, Int32 minimum) => GrowKernel((ReadOnlySpan<T>)source, minimum);

	/// <summary>
	/// Grows the collection by a computed factor, to at least a specified <paramref name="minimum"/>.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <param name="minimum">The minimum allowed size.</param>
	/// <returns>A new <see cref="ReadOnlySpan{T}"/> that is at least the <paramref name="minimum"/> size, and contains the elements from the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> Grow<T>(this ReadOnlySpan<T> source, Int32 minimum) => GrowKernel(source, minimum);
	#endregion

	private static T[] GrowKernel<T>(this ReadOnlySpan<T> source) => source.ResizeKernel((Int32)(source.Length * φ));

	private static T[] GrowKernel<T>(this ReadOnlySpan<T> source, Int32 minimum) {
		Double size = source.Length;
		while (size < minimum) {
			size += 4.0;
			size *= φ;
		}
		return source.ResizeKernel((Int32)size);
	}
}
