namespace System;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Resizes the <paramref name="source"/> to the <paramref name="size"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the <paramref name="source"/>.</typeparam>
	/// <param name="source">The source to resize.</param>
	/// <param name="size">The new size of the <see cref="Array"/>.</param>
	/// <returns>A new <see cref="Array"/> with the <paramref name="size"/>, and the elements from the <paramref name="source"/>.</returns>
	/// <remarks>
	/// If the <paramref name="source"/> <see cref="Array.Length"/> is greater than or equal to the <paramref name="size"/>, this copies the entire <paramref name="source"/> into the result; otherwise, this copies as many elements as will fit in the result.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	[return: NotNullIfNotNull(nameof(source))]
	public static T[]? Resize<T>(this T[]? source, Int32 size) {
		if (source is not null) {
			return ResizeKernel<T>(source.AsSpan(), size);
		} else {
			return null;
		}
	}

	/// <summary>
	/// Resizes the <paramref name="source"/> to the <paramref name="size"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the <paramref name="source"/>.</typeparam>
	/// <param name="source">The source to resize.</param>
	/// <param name="size">The new size of the <see cref="ArraySegment{T}"/>.</param>
	/// <returns>A new <see cref="ArraySegment{T}"/> with the <paramref name="size"/>, and the elements from the <paramref name="source"/>.</returns>
	/// <remarks>
	/// If the <paramref name="source"/> <see cref="ArraySegment{T}.Count"/> is greater than or equal to the <paramref name="size"/>, this copies the entire <paramref name="source"/> into the result; otherwise, this copies as many elements as will fit in the result.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<T> Resize<T>(this ArraySegment<T> source, Int32 size) => ResizeKernel<T>(source.AsSpan(), size);

	/// <summary>
	/// Resizes the <paramref name="source"/> to the <paramref name="size"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the <paramref name="source"/>.</typeparam>
	/// <param name="source">The source to resize.</param>
	/// <param name="size">The new size of the <see cref="Memory{T}"/>.</param>
	/// <returns>A new <see cref="Memory{T}"/> with the <paramref name="size"/>, and the elements from the <paramref name="source"/>.</returns>
	/// <remarks>
	/// If the <paramref name="source"/> <see cref="Memory{T}.Length"/> is greater than or equal to the <paramref name="size"/>, this copies the entire <paramref name="source"/> into the result; otherwise, this copies as many elements as will fit in the result.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static Memory<T> Resize<T>(this Memory<T> source, Int32 size) => ResizeKernel<T>(source.Span, size);

	/// <summary>
	/// Resizes the <paramref name="source"/> to the <paramref name="size"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the <paramref name="source"/>.</typeparam>
	/// <param name="source">The source to resize.</param>
	/// <param name="size">The new size of the <see cref="ReadOnlyMemory{T}"/>.</param>
	/// <returns>A new <see cref="ReadOnlyMemory{T}"/> with the <paramref name="size"/>, and the elements from the <paramref name="source"/>.</returns>
	/// <remarks>
	/// If the <paramref name="source"/> <see cref="ReadOnlyMemory{T}.Length"/> is greater than or equal to the <paramref name="size"/>, this copies the entire <paramref name="source"/> into the result; otherwise, this copies as many elements as will fit in the result.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<T> Resize<T>(this ReadOnlyMemory<T> source, Int32 size) => ResizeKernel(source.Span, size);

	/// <summary>
	/// Resizes the <paramref name="source"/> to the <paramref name="size"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the <paramref name="source"/>.</typeparam>
	/// <param name="source">The source to resize.</param>
	/// <param name="size">The new size of the <see cref="Span{T}"/>.</param>
	/// <returns>A new <see cref="Span{T}"/> with the <paramref name="size"/>, and the elements from the <paramref name="source"/>.</returns>
	/// <remarks>
	/// If the <paramref name="source"/> <see cref="Span{T}.Length"/> is greater than or equal to the <paramref name="size"/>, this copies the entire <paramref name="source"/> into the result; otherwise, this copies as many elements as will fit in the result.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static Span<T> Resize<T>(this Span<T> source, Int32 size) => ResizeKernel((ReadOnlySpan<T>)source, size);

	/// <summary>
	/// Resizes the <paramref name="source"/> to the <paramref name="size"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the <paramref name="source"/>.</typeparam>
	/// <param name="source">The source to resize.</param>
	/// <param name="size">The new size of the <see cref="ReadOnlySpan{T}"/>.</param>
	/// <returns>A new <see cref="ReadOnlySpan{T}"/> with the <paramref name="size"/>, and the elements from the <paramref name="source"/>.</returns>
	/// <remarks>
	/// If the <paramref name="source"/> <see cref="ReadOnlySpan{T}.Length"/> is greater than or equal to the <paramref name="size"/>, this copies the entire <paramref name="source"/> into the result; otherwise, this copies as many elements as will fit in the result.
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<T> Resize<T>(this ReadOnlySpan<T> source, Int32 size) => ResizeKernel(source, size);

	private static T[] ResizeKernel<T>(this ReadOnlySpan<T> source, Int32 size) {
		T[] result = new T[size];
		if (source.Length <= size) {
			source.CopyTo(result);
		} else {
			source[..size].CopyTo(result);
		}
		return result;
	}
}
