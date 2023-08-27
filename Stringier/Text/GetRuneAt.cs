namespace System.Text;

using System.Text.Encodings;

public static partial class StringierExtensions {
	/// <summary>
	/// Gets the <see cref="Rune"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the rune.</param>
	/// <param name="index">The starting position in input at which to create the rune.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Rune GetRuneAt(this String? text, ref Int32 index) => GetRuneAt(text.AsSpan(), ref index);

	/// <summary>
	/// Gets the <see cref="Rune"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the rune.</param>
	/// <param name="index">The starting position in input at which to create the rune.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Rune GetRuneAt(this Char[]? text, ref Int32 index) => GetRuneAt(text.AsSpan(), ref index);

	/// <summary>
	/// Gets the <see cref="Rune"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the rune.</param>
	/// <param name="index">The starting position in input at which to create the rune.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Rune GetRuneAt(this ArraySegment<Char> text, ref Int32 index) => GetRuneAt(text.AsSpan(), ref index);

	/// <summary>
	/// Gets the <see cref="Rune"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the rune.</param>
	/// <param name="index">The starting position in input at which to create the rune.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Rune GetRuneAt(this Memory<Char> text, ref Int32 index) => GetRuneAt(text.Span, ref index);

	/// <summary>
	/// Gets the <see cref="Rune"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the rune.</param>
	/// <param name="index">The starting position in input at which to create the rune.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Rune GetRuneAt(this ReadOnlyMemory<Char> text, ref Int32 index) => GetRuneAt(text.Span, ref index);

	/// <summary>
	/// Gets the <see cref="Rune"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the rune.</param>
	/// <param name="index">The starting position in input at which to create the rune.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Rune GetRuneAt(this Span<Char> text, ref Int32 index) => GetRuneAt((ReadOnlySpan<Char>)text, ref index);

	/// <summary>
	/// Gets the <see cref="Rune"/> which begins at index <paramref name="index"/> in
	/// string <paramref name="text"/>.
	/// </summary>
	/// <param name="text">The string from which to create the rune.</param>
	/// <param name="index">The starting position in input at which to create the rune.</param>
	/// <remarks>
	/// Throws if <paramref name="text"/> is <see langword="null"/>, if <paramref name="index"/> is out of range, or
	/// if <paramref name="index"/> does not reference the start of a valid scalar value within <paramref name="text"/>.
	/// </remarks>
	public static Rune GetRuneAt(this ReadOnlySpan<Char> text, ref Int32 index) {
		Char high = text[index++];
		if (UTF16.IsHighSurrogate(high)) {
			Char low = text[index++];
			return new Rune(high, low);
		} else {
			return new Rune(high);
		}
	}
}
