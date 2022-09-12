namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	public static void CopyTo(this Range source, Int32[]? destination) => CopyTo(source, destination.AsSpan());

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	public static void CopyTo(this Range source, Memory<Int32> destination) => CopyTo(source, destination.Span);

	/// <summary>
	/// Copies the contents of the <paramref name="source"/> into the <paramref name="destination"/>.
	/// </summary>
	/// <param name="source">The source to copy elements from.</param>
	/// <param name="destination">The destination to copy elements into.</param>
	/// <exception cref="ArgumentException">The <paramref name="destination"/> is shorter than the <paramref name="source"/>.</exception>
	/// <remarks>If <paramref name="source"/> and <paramref name="destination"/> overlap, this method behaves as if the original values are in a temporary location before the <paramref name="destination"/> is overwritten.</remarks>
	public static void CopyTo(this Range source, Span<Int32> destination) {
		if (source.Count() > destination.Length) {
			throw new ArgumentException("The destination is shorter than the source.", nameof(destination));
		}
		Int32 d = 0;
		foreach (Int32 s in source) {
			destination[d++] = s;
		}
	}
}
