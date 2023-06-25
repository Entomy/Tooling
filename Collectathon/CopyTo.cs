namespace System;

public static partial class CollectathonExtensions {
	#region CopyTo(T[], Buffer)
	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this T[]? source, T[]? destination) => source.AsSpan().CopyTo(destination.AsSpan());

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this T[]? source, ArraySegment<T> destination) => source.AsSpan().CopyTo(destination.AsSpan());

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this T[]? source, Memory<T> destination) => source.AsSpan().CopyTo(destination.Span);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this T[]? source, Span<T> destination) => source.AsSpan().CopyTo(destination);
	#endregion

	#region CopyTo(ArraySegment<T>, Buffer)
	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this ArraySegment<T> source, T[]? destination) => source.AsSpan().CopyTo(destination);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this ArraySegment<T> source, Memory<T> destination) => source.AsSpan().CopyTo(destination);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this ArraySegment<T> source, Span<T> destination) => source.AsSpan().CopyTo(destination);
	#endregion

	#region CopyTo(Memory<T>, Buffer)
	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this Memory<T> source, T[]? destination) => source.Span.CopyTo(destination);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this Memory<T> source, Memory<T> destination) => source.Span.CopyTo(destination);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this Memory<T> source, Span<T> destination) => source.Span.CopyTo(destination);
	#endregion

	#region CopyTo(ReadOnlyMemory<T>, Buffer)
	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this ReadOnlyMemory<T> source, T[]? destination) => source.Span.CopyTo(destination);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this ReadOnlyMemory<T> source, ArraySegment<T> destination) => source.Span.CopyTo(destination.AsSpan());

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this ReadOnlyMemory<T> source, Memory<T> destination) => source.Span.CopyTo(destination);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this ReadOnlyMemory<T> source, Span<T> destination) => source.Span.CopyTo(destination);
	#endregion

	#region CopyTo(Span<T>, Buffer)
	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this Span<T> source, T[]? destination) => source.CopyTo(destination);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this Span<T> source, ArraySegment<T> destination) => source.CopyTo(destination.AsSpan());

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this Span<T> source, Memory<T> destination) => source.CopyTo(destination);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this Span<T> source, Span<T> destination) => source.CopyTo(destination);
	#endregion

	#region CopyTo(ReadOnlySpan<T>, Buffer)
	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this ReadOnlySpan<T> source, T[]? destination) => source.CopyTo(destination.AsSpan());

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this ReadOnlySpan<T> source, ArraySegment<T> destination) => source.CopyTo(destination.AsSpan());

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this ReadOnlySpan<T> source, Memory<T> destination) => source.CopyTo(destination.Span);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements to copy.</typeparam>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	[ExcludeFromCodeCoverage]
	public static void CopyTo<T>(this ReadOnlySpan<T> source, Span<T> destination) => source.CopyTo(destination);
	#endregion
}
