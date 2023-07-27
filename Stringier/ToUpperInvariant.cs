namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Char ToUpperInvariant(this Char text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Rune ToUpperInvariant(this Rune text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static String? ToUpperInvariant(this String? text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Char[]? ToUpperInvariant(this Char[]? text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<Char> ToUpperInvariant(this Memory<Char> text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<Char> ToUpperInvariant(this ReadOnlyMemory<Char> text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<Char> ToUpperInvariant(this Span<Char> text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase using the casing rules of the invariant culture.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<Char> ToUpperInvariant(this ReadOnlySpan<Char> text) => ToUpper(text, culture: null);
}
