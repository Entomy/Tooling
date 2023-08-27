#if NET6_0_OR_GREATER
namespace System.Text;

using System.Text.Unicode;

/// <summary>
/// Enumerates the grapheme clusters of a text.
/// </summary>
/// <remarks>
/// <para>The current implementation is compliant per Rev. 35. (https://www.unicode.org/reports/tr29/tr29-35.html)</para>
/// </remarks>
public ref struct GlyphEnumerator {
	private readonly ReadOnlySpan<Char> Text;

	private Int32 Offset;
	private Int32 Length;

	internal GlyphEnumerator(ReadOnlySpan<Char> text) {
		Text = text;
		Offset = Text.Length;
		Length = -Text.Length;
	}

	/// <summary>
	/// Advances the enumerator to the next text element of the string.
	/// </summary>
	/// <returns></returns>
	public Boolean MoveNext() {
		Offset += Length; // advance
		Length = 0; // prevent future calls to MoveNext() or get_Current from succeeding if we've hit end of data

		if (Offset >= Text.Length) {
			return false; // reached the end of the data
		}

		Length = TextSegmentationUtility.GetLengthOfFirstExtendedGraphemeCluster(Text.Slice(Offset));
		return true;
	}

	/// <summary>
	/// Gets the current text element in the string.
	/// </summary>
	/// <returns>A new string containing the current text element in the string being read.</returns>
	/// <exception cref="InvalidOperationException">The enumerator is positioned before the first text element of the string or after the last text element.</exception>
	public Glyph Current => new Glyph(Text.Slice(Offset, Length));

	/// <summary>
	/// Sets the enumerator to its initial position, which is before the first text element in the string.
	/// </summary>
	public void Reset() {
		Offset = Text.Length;
		Length = -Text.Length;
	}
}
#endif
