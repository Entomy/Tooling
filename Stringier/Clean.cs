namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Trim and replace multiple whitespace characters with a single occurrences.
	/// </summary>
	/// <param name="source">The <see cref="String"/> to clean.</param>
	/// <returns>The cleaned up <paramref name="source"/>.</returns>
	[return: NotNullIfNotNull("source")]
	public static String? Clean(this String? source) => Trim(source).Squeeze();

	/// <summary>
	/// Trim and replace multiple whitespace characters with a single occurrences.
	/// </summary>
	/// <param name="source">The <see cref="Array"/> to clean.</param>
	/// <returns>The cleaned up <paramref name="source"/>.</returns>
	[return: NotNullIfNotNull("source")]
	public static Char[]? Clean(this Char[]? source) => Trim(source).Squeeze();

	/// <summary>
	/// Trim and replace multiple whitespace characters with a single occurrences.
	/// </summary>
	/// <param name="source">The <see cref="ArraySegment{T}"/> to clean.</param>
	/// <returns>The cleaned up <paramref name="source"/>.</returns>
	public static ArraySegment<Char> Clean(this ArraySegment<Char> source) => source.Trim().Squeeze();

	/// <summary>
	/// Trim and replace multiple whitespace characters with a single occurrences.
	/// </summary>
	/// <param name="source">The <see cref="Memory{T}"/> to clean.</param>
	/// <returns>The cleaned up <paramref name="source"/>.</returns>
	public static Memory<Char> Clean(this Memory<Char> source) => source.Trim().Squeeze();

	/// <summary>
	/// Trim and replace multiple whitespace characters with a single occurrences.
	/// </summary>
	/// <param name="source">The <see cref="ReadOnlyMemory{T}"/> to clean.</param>
	/// <returns>The cleaned up <paramref name="source"/>.</returns>
	public static ReadOnlyMemory<Char> Clean(this ReadOnlyMemory<Char> source) => source.Trim().Squeeze();

	/// <summary>
	/// Trim and replace multiple whitespace characters with a single occurrences.
	/// </summary>
	/// <param name="source">The <see cref="Span{T}"/> to clean.</param>
	/// <returns>The cleaned up <paramref name="source"/>.</returns>
	public static Span<Char> Clean(this Span<Char> source) => source.Trim().Squeeze();

	/// <summary>
	/// Trim and replace multiple whitespace characters with a single occurrences.
	/// </summary>
	/// <param name="source">The <see cref="ReadOnlySpan{T}"/> to clean.</param>
	/// <returns>The cleaned up <paramref name="source"/>.</returns>
	public static ReadOnlySpan<Char> Clean(this ReadOnlySpan<Char> source) => source.Trim().Squeeze();
}
