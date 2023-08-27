namespace System.Globalization;

using System.Runtime.CompilerServices;

public static partial class StringierExtensions {
	/// <summary>
	/// Determines whether this <paramref name="category"/> contains the specified <paramref name="category"/>.
	/// </summary>
	/// <param name="category">This <see cref="UnicodeCategory"/>.</param>
	/// <param name="value">The <see cref="Char"/> to attempt to find.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is contained in this <paramref name="category"/>; otherwise, <see langword="false"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean Contains(this UnicodeCategory category, Char value) => Char.GetUnicodeCategory(value) == category;

	/// <summary>
	/// Determines whether this <paramref name="category"/> contains the specified <paramref name="category"/>.
	/// </summary>
	/// <param name="category">This <see cref="UnicodeCategory"/>.</param>
	/// <param name="value">The <see cref="Char"/> to attempt to find.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is contained in this <paramref name="category"/>; otherwise, <see langword="false"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean Contains(this UnicodeCategory category, Rune value) => UnicodeInfo.GetCategory(value.Value) == category;
}
