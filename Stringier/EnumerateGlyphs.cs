#if NET6_0_OR_GREATER
namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Returns an enumeration of <see cref="Glyph"/> from this string.
	/// </summary>
	/// <param name="text">The source text.</param>
	/// <returns>A string glyph enumerator.</returns>
	public static GlyphEnumerator EnumerateGlyphs(this String? text) => new GlyphEnumerator(text.AsSpan());

	/// <summary>
	/// Returns an enumeration of <see cref="Glyph"/> from this string.
	/// </summary>
	/// <param name="text">The source text.</param>
	/// <returns>A string glyph enumerator.</returns>
	public static GlyphEnumerator EnumerateGlyphs(this Char[]? text) => new GlyphEnumerator(text.AsSpan());

	/// <summary>
	/// Returns an enumeration of <see cref="Glyph"/> from this string.
	/// </summary>
	/// <param name="text">The source text.</param>
	/// <returns>A string glyph enumerator.</returns>
	public static GlyphEnumerator EnumerateGlyphs(this ArraySegment<Char> text) => new GlyphEnumerator(text.AsSpan());

	/// <summary>
	/// Returns an enumeration of <see cref="Glyph"/> from this string.
	/// </summary>
	/// <param name="text">The source text.</param>
	/// <returns>A string glyph enumerator.</returns>
	public static GlyphEnumerator EnumerateGlyphs(this Memory<Char> text) => new GlyphEnumerator(text.Span);

	/// <summary>
	/// Returns an enumeration of <see cref="Glyph"/> from this string.
	/// </summary>
	/// <param name="text">The source text.</param>
	/// <returns>A string glyph enumerator.</returns>
	public static GlyphEnumerator EnumerateGlyphs(this ReadOnlyMemory<Char> text) => new GlyphEnumerator(text.Span);

	/// <summary>
	/// Returns an enumeration of <see cref="Glyph"/> from this string.
	/// </summary>
	/// <param name="text">The source text.</param>
	/// <returns>A string glyph enumerator.</returns>
	public static GlyphEnumerator EnumerateGlyphs(this Span<Char> text) => new GlyphEnumerator(text);

	/// <summary>
	/// Returns an enumeration of <see cref="Glyph"/> from this string.
	/// </summary>
	/// <param name="text">The source text.</param>
	/// <returns>A string glyph enumerator.</returns>
	public static GlyphEnumerator EnumerateGlyphs(this ReadOnlySpan<Char> text) => new GlyphEnumerator(text);
}
#endif
