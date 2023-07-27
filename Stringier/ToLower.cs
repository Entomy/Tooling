namespace System;

using System.Globalization;

public static partial class StringierExtensions {
	#region ToLower(Text)
	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Char ToLower(this Char text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Rune ToLower(this Rune text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static String? ToLower(this String? text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Char[]? ToLower(this Char[]? text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static ArraySegment<Char> ToLower(this ArraySegment<Char> text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<Char> ToLower(this Memory<Char> text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<Char> ToLower(this ReadOnlyMemory<Char> text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<Char> ToLower(this Span<Char> text) => ToLower(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<Char> ToLower(this ReadOnlySpan<Char> text) => ToLower(text, culture: null);
	#endregion

	#region ToLower(Text, CultureInfo?)
	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	public static Char ToLower(this Char text, CultureInfo? culture) => Char.ToLower(text, culture ?? CultureInfo.CurrentCulture);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	public static Rune ToLower(this Rune text, CultureInfo? culture) => Rune.ToLower(text, culture ?? CultureInfo.CurrentCulture);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	public static String? ToLower(this String? text, CultureInfo? culture) {
		if (text is not null) {
			Char[] result = new Char[text.Length];
			_ = MemoryExtensions.ToLower(text, result, culture);
			return new String(result);
		} else {
			return null;
		}
	}

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	public static Char[]? ToLower(this Char[]? text, CultureInfo? culture) {
		if (text is not null) {
			Char[] result = new Char[text.Length];
			_ = MemoryExtensions.ToLower(text.AsSpan(), result.AsSpan(), culture);
			return result;
		} else {
			return null;
		}
	}

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	public static ArraySegment<Char> ToLower(this ArraySegment<Char> text, CultureInfo? culture) {
		ArraySegment<Char> result = new Char[text.Count];
		_ = MemoryExtensions.ToLower(text.AsSpan(), result.AsSpan(), culture);
		return result;
	}

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	public static Memory<Char> ToLower(this Memory<Char> text, CultureInfo? culture) {
		Memory<Char> result = new Char[text.Length];
		_ = MemoryExtensions.ToLower(text.Span, result.Span, culture);
		return result;
	}

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	public static ReadOnlyMemory<Char> ToLower(this ReadOnlyMemory<Char> text, CultureInfo? culture) {
		Memory<Char> result = new Char[text.Length];
		_ = MemoryExtensions.ToLower(text.Span, result.Span, culture);
		return result;
	}

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	public static Span<Char> ToLower(this Span<Char> text, CultureInfo? culture) {
		Span<Char> result = new Char[text.Length];
		_ = MemoryExtensions.ToLower(text, result, culture);
		return result;
	}

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to lowercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The lowercase equivalent of the current text.</returns>
	public static ReadOnlySpan<Char> ToLower(this ReadOnlySpan<Char> text, CultureInfo? culture) {
		Span<Char> result = new Char[text.Length];
		_ = MemoryExtensions.ToLower(text, result, culture);
		return result;
	}
	#endregion
}
