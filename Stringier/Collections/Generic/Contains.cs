namespace System.Collections.Generic;

using System.Globalization;

public static partial class StringierExtensions {
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains the specified <paramref name="category"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="category">The <see cref="UnicodeCategory"/> to attempt to find.</param>
	/// <returns><see langword="true"/> if <paramref name="category"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	public static Boolean Contains(this IEnumerable<Char>? collection, UnicodeCategory category) {
		if (collection is not null) {
			foreach (Char item in collection) {
				if (Char.GetUnicodeCategory(item) == category) {
					return true;
				}
			}
		}
		return false;
	}

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains the specified <paramref name="properties"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="properties">The <see cref="ContributoryProperties"/> to attempt to find.</param>
	/// <returns><see langword="true"/> if <paramref name="properties"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	public static Boolean Contains(this IEnumerable<Char>? collection, ContributoryProperties properties) {
		if (collection is not null) {
			foreach (Char item in collection) {
				if (UnicodeInfo.GetCharInfo(item).ContributoryProperties.HasFlag(properties)) {
					return true;
				}
			}
		}
		return false;
	}
}
