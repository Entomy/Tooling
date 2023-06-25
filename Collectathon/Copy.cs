namespace System;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Copies the <paramref name="source"/> into a new <see cref="Array"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the <paramref name="source"/>.</typeparam>
	/// <param name="source">The <see cref="Array"/> to copy.</param>
	/// <returns>A new <see cref="Array"/> with the same size and contents as the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	[return: NotNullIfNotNull("source")]
	public static T[]? Copy<T>(this T[]? source) {
		if (source is not null) {
			return CopyKernel<T>(source.AsSpan());
		} else {
			return source;
		}
	}

	/// <summary>
	/// Copies the <paramref name="source"/> into a new <see cref="ArraySegment{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the <paramref name="source"/>.</typeparam>
	/// <param name="source">The <see cref="ArraySegment{T}"/> to copy.</param>
	/// <returns>A new <see cref="ArraySegment{T}"/> with the same size and contents as the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> Copy<T>(this ArraySegment<T> source) => CopyKernel<T>(source.AsSpan());

	/// <summary>
	/// Copies the <paramref name="source"/> into a new <see cref="Memory{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the <paramref name="source"/>.</typeparam>
	/// <param name="source">The <see cref="Memory{T}"/> to copy.</param>
	/// <returns>A new <see cref="Memory{T}"/> with the same size and contents as the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<T> Copy<T>(this Memory<T> source) => CopyKernel<T>(source.Span);

	/// <summary>
	/// Copies the <paramref name="source"/> into a new <see cref="ReadOnlyMemory{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the <paramref name="source"/>.</typeparam>
	/// <param name="source">The <see cref="ReadOnlyMemory{T}"/> to copy.</param>
	/// <returns>A new <see cref="ReadOnlyMemory{T}"/> with the same size and contents as the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> Copy<T>(this ReadOnlyMemory<T> source) => CopyKernel(source.Span);

	/// <summary>
	/// Copies the <paramref name="source"/> into a new <see cref="Span{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the <paramref name="source"/>.</typeparam>
	/// <param name="source">The <see cref="Span{T}"/> to copy.</param>
	/// <returns>A new <see cref="Span{T}"/> with the same size and contents as the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<T> Copy<T>(this Span<T> source) => CopyKernel((ReadOnlySpan<T>)source);

	/// <summary>
	/// Copies the <paramref name="source"/> into a new <see cref="ReadOnlySpan{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the <paramref name="source"/>.</typeparam>
	/// <param name="source">The <see cref="ReadOnlySpan{T}"/> to copy.</param>
	/// <returns>A new <see cref="ReadOnlySpan{T}"/> with the same size and contents as the <paramref name="source"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> Copy<T>(this ReadOnlySpan<T> source) => CopyKernel(source);

	private static T[] CopyKernel<T>(this ReadOnlySpan<T> source) {
		T[] result = new T[source.Length];
		source.CopyTo(result);
		return result;
	}
}
