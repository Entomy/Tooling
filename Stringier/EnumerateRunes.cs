namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Returns an enumeration of <see cref="Rune"/> from the provided <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The source text.</param>
	/// <returns>A rune enumerator.</returns>
	public static StringRuneEnumerator EnumerateRunes(this String? text) => text?.EnumerateRunes() ?? String.Empty.EnumerateRunes();

	/// <summary>
	/// Returns an enumeration of <see cref="Rune"/> from the provided <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The source text.</param>
	/// <returns>A rune enumerator.</returns>
	public static SpanRuneEnumerator EnumerateRunes(this Char[]? text) => MemoryExtensions.EnumerateRunes(text.AsSpan());

	/// <summary>
	/// Returns an enumeration of <see cref="Rune"/> from the provided <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The source text.</param>
	/// <returns>A rune enumerator.</returns>
	public static SpanRuneEnumerator EnumerateRunes(this ArraySegment<Char> text) => MemoryExtensions.EnumerateRunes(text.AsSpan());

	/// <summary>
	/// Returns an enumeration of <see cref="Rune"/> from the provided <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The source text.</param>
	/// <returns>A rune enumerator.</returns>
	public static SpanRuneEnumerator EnumerateRunes(this Memory<Char> text) => MemoryExtensions.EnumerateRunes(text.Span);

	/// <summary>
	/// Returns an enumeration of <see cref="Rune"/> from the provided <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The source text.</param>
	/// <returns>A rune enumerator.</returns>
	public static SpanRuneEnumerator EnumerateRunes(this ReadOnlyMemory<Char> text) => MemoryExtensions.EnumerateRunes(text.Span);
}
