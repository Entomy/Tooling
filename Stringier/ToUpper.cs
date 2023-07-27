namespace System;

using System.Globalization;

public static partial class StringierExtensions {
	#region ToUpper(Text)
	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Char ToUpper(this Char text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Rune ToUpper(this Rune text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static String? ToUpper(this String? text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Char[]? ToUpper(this Char[]? text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Memory<Char> ToUpper(this Memory<Char> text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlyMemory<Char> ToUpper(this ReadOnlyMemory<Char> text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Span<Char> ToUpper(this Span<Char> text) => ToUpper(text, culture: null);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static ReadOnlySpan<Char> ToUpper(this ReadOnlySpan<Char> text) => ToUpper(text, culture: null);
	#endregion

	#region ToUpper(Text, CultureInfo?)
	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Char ToUpper(this Char text, CultureInfo? culture) => Char.ToUpper(text, culture ?? CultureInfo.CurrentCulture);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	[ExcludeFromCodeCoverage]
	public static Rune ToUpper(this Rune text, CultureInfo? culture) => Rune.ToUpper(text, culture ?? CultureInfo.CurrentCulture);

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	public static String? ToUpper(this String? text, CultureInfo? culture) {
		if (text is not null) {
			Char[] result = new Char[text.Length];
			_ = MemoryExtensions.ToUpper(text, result, culture);
			return new String(result);
		} else {
			return null;
		}
	}

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	public static Char[]? ToUpper(this Char[]? text, CultureInfo? culture) {
		if (text is not null) {
			Char[] result = new Char[text.Length];
			_ = MemoryExtensions.ToUpper(text.AsSpan(), result.AsSpan(), culture);
			return result;
		} else {
			return null;
		}
	}

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	public static Memory<Char> ToUpper(this Memory<Char> text, CultureInfo? culture) {
		Memory<Char> result = new Char[text.Length];
		_ = MemoryExtensions.ToUpper(text.Span, result.Span, culture);
		return result;
	}

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	public static ReadOnlyMemory<Char> ToUpper(this ReadOnlyMemory<Char> text, CultureInfo? culture) {
		Memory<Char> result = new Char[text.Length];
		_ = MemoryExtensions.ToUpper(text.Span, result.Span, culture);
		return result;
	}

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	public static Span<Char> ToUpper(this Span<Char> text, CultureInfo? culture) {
		Span<Char> result = new Char[text.Length];
		_ = MemoryExtensions.ToUpper(text, result, culture);
		return result;
	}

	/// <summary>
	/// Returns a copy of this <paramref name="text"/> converted to uppercase, using the casing rules of the specified <paramref name="culture"/>.
	/// </summary>
	/// <param name="text">The text to convert.</param>
	/// <param name="culture">An object that supplies culture-specific casing rules. If culture is <see langword="null"/>, the current culture is used.</param>
	/// <returns>The uppercase equivalent of the current text.</returns>
	public static ReadOnlySpan<Char> ToUpper(this ReadOnlySpan<Char> text, CultureInfo? culture) {
		Span<Char> result = new Char[text.Length];
		_ = MemoryExtensions.ToUpper(text, result, culture);
		return result;
	}
	#endregion
}
