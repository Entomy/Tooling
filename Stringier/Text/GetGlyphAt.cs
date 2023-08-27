#if NET6_0_OR_GREATER
namespace System.Text;

using System.Text.Unicode;

public static partial class StringierExtensions {
	/// <summary>
	/// Gets the <see cref="Glyph"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the glyph.</param>
	/// <param name="index">The starting position in input at which to create the glyph.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Glyph GetGlyphAt(this String? text, ref Int32 index) => GetGlyphAt(text.AsSpan(), ref index);

	/// <summary>
	/// Gets the <see cref="Glyph"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the glyph.</param>
	/// <param name="index">The starting position in input at which to create the glyph.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Glyph GetGlyphAt(this Char[]? text, ref Int32 index) => GetGlyphAt(text.AsSpan(), ref index);

	/// <summary>
	/// Gets the <see cref="Glyph"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the glyph.</param>
	/// <param name="index">The starting position in input at which to create the glyph.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Glyph GetGlyphAt(this ArraySegment<Char> text, ref Int32 index) => GetGlyphAt(text.AsSpan(), ref index);

	/// <summary>
	/// Gets the <see cref="Glyph"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the glyph.</param>
	/// <param name="index">The starting position in input at which to create the glyph.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Glyph GetGlyphAt(this Memory<Char> text, ref Int32 index) => GetGlyphAt(text.Span, ref index);

	/// <summary>
	/// Gets the <see cref="Glyph"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the glyph.</param>
	/// <param name="index">The starting position in input at which to create the glyph.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Glyph GetGlyphAt(this ReadOnlyMemory<Char> text, ref Int32 index) => GetGlyphAt(text.Span, ref index);

	/// <summary>
	/// Gets the <see cref="Glyph"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the glyph.</param>
	/// <param name="index">The starting position in input at which to create the glyph.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Glyph GetGlyphAt(this Span<Char> text, ref Int32 index) => GetGlyphAt((ReadOnlySpan<Char>)text, ref index);

	/// <summary>
	/// Gets the <see cref="Glyph"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the glyph.</param>
	/// <param name="index">The starting position in input at which to create the glyph.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Glyph GetGlyphAt(this ReadOnlySpan<Char> text, ref Int32 index) {
		Int32 length = TextSegmentationUtility.GetLengthOfFirstExtendedGraphemeCluster(text[index..]);
		Glyph glyph = new Glyph(text.Slice(index, length));
		index += length;
		return glyph;
	}
}
#endif
