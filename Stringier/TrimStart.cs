namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Removes all leading whitespace characters from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimStart(this String? source) => source is not null ? MemoryExtensions.TrimStart(source).ToString() : null;

	/// <summary>
	/// Removes all leading whitespace characters from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <returns>The trimmed source.</returns>
	public static Char[]? TrimStart(this Char[]? source) => source is not null ? MemoryExtensions.TrimStart(source.AsSpan()).ToArray() : null;

	/// <summary>
	/// Removes all leading whitespace characters from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <returns>The trimmed source.</returns>
	public static ArraySegment<Char> TrimStart(this ArraySegment<Char> source) => MemoryExtensions.TrimStart(source.AsSpan()).ToArray();

	/// <summary>
	/// Removes all leading occurrences of a specified <paramref name="trimElement"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElement">The specified element to look for and remove.</param>
	/// <returns>The trimmed source.</returns>
	public static ReadOnlySpan<Char> TrimStart(this String? source, Char trimElement) => MemoryExtensions.TrimStart(source.AsSpan(), trimElement);

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimStart(this String? source, Char[]? trimElements) => source is not null ? MemoryExtensions.TrimStart(source.AsSpan(), trimElements.AsSpan()).ToString() : null;

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimStart(this String? source, ArraySegment<Char> trimElements) => source is not null ? MemoryExtensions.TrimStart(source.AsSpan(), trimElements.AsSpan()).ToString() : null;

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimStart(this String? source, Memory<Char> trimElements) => source is not null ? MemoryExtensions.TrimStart(source.AsSpan(), trimElements.Span).ToString() : null;

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimStart(this String? source, ReadOnlyMemory<Char> trimElements) => source is not null ? MemoryExtensions.TrimStart(source.AsSpan(), trimElements.Span).ToString() : null;

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimStart(this String? source, Span<Char> trimElements) => source is not null ? MemoryExtensions.TrimStart(source.AsSpan(), trimElements).ToString() : null;

	/// <summary>
	/// Removes all leading occurrences of the set of <paramref name="trimElements"/> from the <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The source from which the element is removed.</param>
	/// <param name="trimElements">The set of elements to remove.</param>
	/// <returns>The trimmed source.</returns>
	public static String? TrimStart(this String? source, ReadOnlySpan<Char> trimElements) => source is not null ? MemoryExtensions.TrimStart(source, trimElements).ToString() : null;
}
