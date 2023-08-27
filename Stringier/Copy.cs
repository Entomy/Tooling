namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Copies the <paramref name="source"/> into a new <see cref="String"/>.
	/// </summary>
	/// <param name="source">The <see cref="String"/> to copy.</param>
	/// <returns>A new <see cref="String"/> with the same size and contents as the <paramref name="source"/>.</returns>
	[return: NotNullIfNotNull("source")]
	public static String? Copy(this String? source) {
		if (source is not null) {
			return new String(source);
		} else {
			return source;
		}
	}
}
