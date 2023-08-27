#if NET6_0_OR_GREATER
namespace System.Text;

using System.Text.Unicode;

/// <summary>
/// Represents a UNICODE Grapheme Cluster.
/// </summary>
/// <remarks>
/// <para>This is mostly analogous to <see cref="Char"/> and <see cref="Rune"/>, by design. Doing this allows for an orthogonal design that is easy to pick up. Critically however, this is a <see langword="ref"/> <see langword="struct"/>. In practice this shouldn't matter, as the situations where this is used is for text processing, not data structuring or storage or network streaming.</para>
/// <para>This also shares similarities to <see cref="GlyphEnumerator"/> and <see cref="System.Globalization.StringInfo.GetTextElementEnumerator(String, Int32)"/> in their purpose. However, this offers stronger typing, more utility, and ultimately, higher performance as the entire system works with reference slicing, not new <see cref="String"/> all over the place.</para>
/// <para>The current implementation is compliant per Rev. 35. (https://www.unicode.org/reports/tr29/tr29-35.html)</para>
/// </remarks>
public readonly ref struct Glyph {
	/// <summary>
	/// The actual grapheme slice.
	/// </summary>
	private readonly ReadOnlySpan<Char> Grapheme;

	/// <summary>
	/// Initializes a new <see cref="Glyph"/>.
	/// </summary>
	/// <param name="char">The <see cref="Char"/> to convert.</param>
	public Glyph(Char @char) => Grapheme = new Char[] { @char };

	/// <summary>
	/// Initializes a new <see cref="Glyph"/>.
	/// </summary>
	/// <param name="rune">The <see cref="Rune"/> to convert.</param>
	public Glyph(Rune rune) {
		Span<Char> buffer = new Char[rune.Utf16SequenceLength];
		_ = rune.EncodeToUtf16(buffer);
		Grapheme = buffer;
	}

	/// <summary>
	/// Initializes a new <see cref="Glyph"/>.
	/// </summary>
	/// <param name="grapheme">The actual grapheme slice.</param>
	internal Glyph(ReadOnlySpan<Char> grapheme) => Grapheme = grapheme;

	/// <summary>
	/// Converts this <paramref name="char"/> to a <see cref="Glyph"/>.
	/// </summary>
	/// <param name="char">The <see cref="Char"/> to convert.</param>
	public static implicit operator Glyph(Char @char) => new Glyph(@char);

	/// <summary>
	/// Converts this <paramref name="rune"/> to a <see cref="Glyph"/>.
	/// </summary>
	/// <param name="rune">The <see cref="Rune"/> to convert.</param>
	public static implicit operator Glyph(Rune rune) => new Glyph(rune);

	/// <summary>
	/// Gets a value that indicates whether the scalar value associated with this <see cref="Glyph"/> is within the ASCII encoding range.
	/// </summary>
	public Boolean IsAscii {
		get {
			foreach (Char g in Grapheme) {
				if (Char.IsAscii(g)) {
					return false;
				}
			}
			return true;
		}
	}

	/// <summary>
	/// Gets the length in code units (<see cref="Char"/>) of the UTF-16 sequence required to represent this grapheme cluster.
	/// </summary>
	public Int32 Utf16SequenceLength => Grapheme.Length;

	/// <summary>
	/// Gets the length in code units of the UTF-8 sequence required to represent this grapheme cluster.
	/// </summary>
	public Int32 Utf8SequenceLength {
		get {
			Int32 length = 0;
			foreach (Rune rune in Grapheme.EnumerateRunes()) {
				length += rune.Utf8SequenceLength;
			}
			return length;
		}
	}

	#region CompareTo
	/// <summary>
	/// Compares the current instance to the specified <see cref="Glyph"/> instance.
	/// </summary>
	/// <param name="other">The <see cref="Glyph"/> to compare to.</param>
	/// <returns>
	/// A signed integer that indicates the relative order of span and other:
	/// <list type="bullet">
	/// <item>If less than 0, span precedes than other.</item>
	/// <item>If 0, span equals other.</item>
	/// <item>If greater than 0, span follows other.</item>
	/// </list>
	/// </returns>
	public Int32 CompareTo(Glyph other) => Grapheme.CompareTo(other.Grapheme, default);

	/// <summary>
	/// Compares the current instance to the specified <see cref="Glyph"/> instance.
	/// </summary>
	/// <param name="other">The <see cref="Glyph"/> to compare to.</param>
	/// <param name="comparisonType">An enumeration value that determines how this <see cref="Glyph"/> and the <paramref name="other"/> are compared.</param>
	/// <returns>
	/// A signed integer that indicates the relative order of span and other:
	/// <list type="bullet">
	/// <item>If less than 0, span precedes than other.</item>
	/// <item>If 0, span equals other.</item>
	/// <item>If greater than 0, span follows other.</item>
	/// </list>
	/// </returns>
	public Int32 CompareTo(Glyph other, StringComparison comparisonType) => Grapheme.CompareTo(other.Grapheme, comparisonType);
	#endregion

	#region Equals
	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns><see langword="true"/> if <paramref name="obj"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public override Boolean Equals([NotNullWhen(true)] Object? obj) {
		switch (obj) {
		case Char @char:
			return Equals(@char);
		case Rune rune:
			return Equals(rune);
		case String @string:
			return Equals(@string);
		case Char[] array:
			return Equals(array);
		case Memory<Char> memory:
			return Equals(memory);
		case ReadOnlyMemory<Char> memory:
			return Equals(memory);
		default:
			return false;
		}
	}

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="Glyph"/> to compare with the current instance.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(Glyph other) => Grapheme.Equals(other.Grapheme, default);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="Glyph"/> to compare with the current instance.</param>
	/// <param name="comparisonType">An enumeration value that determines how this <see cref="Glyph"/> and the <paramref name="other"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(Glyph other, StringComparison comparisonType) => Grapheme.Equals(other.Grapheme, comparisonType);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="Char"/> to compare with the current instance.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(Char other) => Grapheme.Equals(other, default);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="Char"/> to compare with the current instance.</param>
	/// <param name="comparisonType">An enumeration value that determines how this <see cref="Glyph"/> and the <paramref name="other"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(Char other, StringComparison comparisonType) => Grapheme.Equals(other, comparisonType);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="Rune"/> to compare with the current instance.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(Rune other) => Grapheme.Equals(other, default);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="Rune"/> to compare with the current instance.</param>
	/// <param name="comparisonType">An enumeration value that determines how this <see cref="Glyph"/> and the <paramref name="other"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(Rune other, StringComparison comparisonType) => Grapheme.Equals(other, comparisonType);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="String"/> to compare with the current instance.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(String? other) => Grapheme.Equals(other, default);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="String"/> to compare with the current instance.</param>
	/// <param name="comparisonType">An enumeration value that determines how this <see cref="Glyph"/> and the <paramref name="other"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(String? other, StringComparison comparisonType) => Grapheme.Equals(other, comparisonType);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="Array"/> to compare with the current instance.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(Char[]? other) => Grapheme.Equals(other, default);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="Array"/> to compare with the current instance.</param>
	/// <param name="comparisonType">An enumeration value that determines how this <see cref="Glyph"/> and the <paramref name="other"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(Char[]? other, StringComparison comparisonType) => Grapheme.Equals(other, comparisonType);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="Memory{T}"/> to compare with the current instance.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(Memory<Char> other) => Grapheme.Equals(other, default);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="Memory{T}"/> to compare with the current instance.</param>
	/// <param name="comparisonType">An enumeration value that determines how this <see cref="Glyph"/> and the <paramref name="other"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(Memory<Char> other, StringComparison comparisonType) => Grapheme.Equals(other, comparisonType);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="ReadOnlyMemory{T}"/> to compare with the current instance.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(ReadOnlyMemory<Char> other) => Grapheme.Equals(other, default);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="ReadOnlyMemory{T}"/> to compare with the current instance.</param>
	/// <param name="comparisonType">An enumeration value that determines how this <see cref="Glyph"/> and the <paramref name="other"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(ReadOnlyMemory<Char> other, StringComparison comparisonType) => Grapheme.Equals(other, comparisonType);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="Span{T}"/> to compare with the current instance.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(Span<Char> other) => Grapheme.Equals(other, default);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="Span{T}"/> to compare with the current instance.</param>
	/// <param name="comparisonType">An enumeration value that determines how this <see cref="Glyph"/> and the <paramref name="other"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(Span<Char> other, StringComparison comparisonType) => Grapheme.Equals(other, comparisonType);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="ReadOnlySpan{T}"/> to compare with the current instance.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(ReadOnlySpan<Char> other) => Grapheme.Equals(other, default);

	/// <summary>
	/// Returns a value that indicates whether the current instance and a specified object are equal.
	/// </summary>
	/// <param name="other">The <see cref="ReadOnlySpan{T}"/> to compare with the current instance.</param>
	/// <param name="comparisonType">An enumeration value that determines how this <see cref="Glyph"/> and the <paramref name="other"/> are compared.</param>
	/// <returns><see langword="true"/> if <paramref name="other"/> is equal to the current instance; otherwise, <see langword="false"/>.</returns>
	public Boolean Equals(ReadOnlySpan<Char> other, StringComparison comparisonType) => Grapheme.Equals(other, comparisonType);
	#endregion

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
	public static Glyph GetGlyphAt(ReadOnlySpan<Char> text, Int32 index) {
		Int32 length = TextSegmentationUtility.GetLengthOfFirstExtendedGraphemeCluster(text[index..]);
		return new Glyph(text.Slice(index, length));
	}

	/// <inheritdoc/>
	public override Int32 GetHashCode() => throw new NotSupportedException();

	/// <inheritdoc/>
	public override String ToString() => Grapheme.ToString();
}
#endif
