namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Creates a new span over the target.
	/// </summary>
	/// <param name="source">The source to take a span of.</param>
	/// <returns>A <see cref="ReadOnlySpan{T}"/> representing the <paramref name="source"/> data.</returns>
	internal static unsafe ReadOnlySpan<Char> AsSpan(this Char source) => new ReadOnlySpan<Char>(&source, 1);

	/// <summary>
	/// Creates a new span over the target.
	/// </summary>
	/// <param name="source">The source to take a span of.</param>
	/// <returns>A <see cref="ReadOnlySpan{T}"/> representing the <paramref name="source"/> data.</returns>
	internal static ReadOnlySpan<Char> AsSpan(this Rune source) {
		Span<Char> buffer = new Char[source.Utf16SequenceLength];
		_ = source.EncodeToUtf16(buffer);
		return buffer;
	}
}
