namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Char ToLowerInvariant(this Char text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Rune ToLowerInvariant(this Rune text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static String? ToLowerInvariant(this String? text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Char[]? ToLowerInvariant(this Char[]? text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<Char> ToLowerInvariant(this Memory<Char> text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<Char> ToLowerInvariant(this ReadOnlyMemory<Char> text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<Char> ToLowerInvariant(this Span<Char> text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<Char> ToLowerInvariant(this ReadOnlySpan<Char> text) => ToLower(text, culture: null);
}
