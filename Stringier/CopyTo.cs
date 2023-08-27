namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	public static void CopyTo(this String? source, Char[]? destination) => source.AsSpan().CopyTo(destination);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	public static void CopyTo(this String? source, ArraySegment<Char> destination) => source.AsSpan().CopyTo(destination);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	public static void CopyTo(this String? source, Memory<Char> destination) => source.AsSpan().CopyTo(destination);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	public static void CopyTo(this String? source, Span<Char> destination) => source.AsSpan().CopyTo(destination);
}
