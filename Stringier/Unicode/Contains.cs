namespace System.Unicode;

using System.Runtime.CompilerServices;

public static partial class StringierExtensions {
	/// <summary>
	/// Determines whether this <paramref name="properties"/> contains the specified <paramref name="properties"/>.
	/// </summary>
	/// <param name="properties">This <see cref="ContributoryProperties"/>.</param>
	/// <param name="value">The <see cref="Char"/> to attempt to find.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is contained in this <paramref name="properties"/>; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean Contains(this ContributoryProperties properties, Char value) => UnicodeInfo.GetCharInfo(value).ContributoryProperties.HasFlag(properties);

	/// <summary>
	/// Determines whether this <paramref name="properties"/> contains the specified <paramref name="properties"/>.
	/// </summary>
	/// <param name="properties">This <see cref="ContributoryProperties"/>.</param>
	/// <param name="value">The <see cref="Char"/> to attempt to find.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is contained in this <paramref name="properties"/>; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Boolean Contains(this ContributoryProperties properties, Rune value) => UnicodeInfo.GetCharInfo(value.Value).ContributoryProperties.HasFlag(properties);
}
