namespace System;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Shrinks the collection by a computed factor.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <returns>A new <see cref="Array"/> that is larger than the <paramref name="source"/>, and contains the elements from the <paramref name="source"/>.</returns>
	/// <remarks>
	/// This copies as many elements as will fit in the result.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[return: NotNullIfNotNull("source")]
	public static T[]? Shrink<T>(this T[]? source) => source is not null ? ShrinkKernel<T>(source.AsSpan()) : null;

	/// <summary>
	/// Shrinks the collection by a computed factor.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <returns>A new <see cref="ArraySegment{T}"/> that is larger than the <paramref name="source"/>, and contains the elements from the <paramref name="source"/>.</returns>
	/// <remarks>
	/// This copies as many elements as will fit in the result.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> Shrink<T>(this ArraySegment<T> source) => ShrinkKernel<T>(source.AsSpan());

	/// <summary>
	/// Shrinks the collection by a computed factor.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <returns>A new <see cref="Memory{T}"/> that is larger than the <paramref name="source"/>, and contains the elements from the <paramref name="source"/>.</returns>
	/// <remarks>
	/// This copies as many elements as will fit in the result.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static Memory<T> Shrink<T>(this Memory<T> source) => ShrinkKernel<T>(source.Span);

	/// <summary>
	/// Shrinks the collection by a computed factor.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <returns>A new <see cref="ReadOnlyMemory{T}"/> that is larger than the <paramref name="source"/>, and contains the elements from the <paramref name="source"/>.</returns>
	/// <remarks>
	/// This copies as many elements as will fit in the result.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> Shrink<T>(this ReadOnlyMemory<T> source) => ShrinkKernel(source.Span);

	/// <summary>
	/// Shrinks the collection by a computed factor.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <returns>A new <see cref="Span{T}"/> that is larger than the <paramref name="source"/>, and contains the elements from the <paramref name="source"/>.</returns>
	/// <remarks>
	/// This copies as many elements as will fit in the result.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static Span<T> Shrink<T>(this Span<T> source) => ShrinkKernel((ReadOnlySpan<T>)source);

	/// <summary>
	/// Shrinks the collection by a computed factor.
	/// </summary>
	/// <param name="source">The source to resize.</param>
	/// <returns>A new <see cref="ReadOnlyMemory{T}"/> that is larger than the <paramref name="source"/>, and contains the elements from the <paramref name="source"/>.</returns>
	/// <remarks>
	/// This copies as many elements as will fit in the result.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> Shrink<T>(this ReadOnlySpan<T> source) => ShrinkKernel(source);

	private static T[] ShrinkKernel<T>(this ReadOnlySpan<T> source) => source.ResizeKernel((Int32)(source.Length / φ));
}
