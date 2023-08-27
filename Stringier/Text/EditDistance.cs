namespace System.Text;

/// <summary>
/// Provides functions for calculating edit-distance.
/// </summary>
internal static class EditDistance {
	/// <summary>
	/// Calculates the Hamming edit-distance between the <paramref name="first"/> and <paramref name="second"/>.
	/// </summary>
	/// <param name="first">The first text.</param>
	/// <param name="second">The second text.</param>
	/// <returns>The number of edits to get from <paramref name="first"/> to <paramref name="second"/>.</returns>
	/// <remarks>
	/// Hamming edit-distance measures the amount of substitutions between two texts. Because it does not handle insertions or deletions, the two texts are required to be the same length. It also does not handle transpositions, so a transposition will be counted as two substitutions. This is the simplest of all <see cref="EditDistance"/> algorithms, and is fast, but limited.
	/// </remarks>
	internal static Int32 Hamming(ReadOnlySpan<Char> first, ReadOnlySpan<Char> second) => Hamming(first, second, comparisonType: default);

	/// <summary>
	/// Calculates the Hamming edit-distance between the <paramref name="first"/> and <paramref name="second"/>.
	/// </summary>
	/// <param name="first">The first text.</param>
	/// <param name="second">The second text.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns>The number of edits to get from <paramref name="first"/> to <paramref name="second"/>.</returns>
	/// <remarks>
	/// Hamming edit-distance measures the amount of substitutions between two texts. Because it does not handle insertions or deletions, the two texts are required to be the same length. It also does not handle transpositions, so a transposition will be counted as two substitutions. This is the simplest of all <see cref="EditDistance"/> algorithms, and is fast, but limited.
	/// </remarks>
	internal static Int32 Hamming(ReadOnlySpan<Char> first, ReadOnlySpan<Char> second, StringComparison comparisonType) {
		Int32 d = 0;
		switch (comparisonType) {
		case StringComparison.CurrentCultureIgnoreCase:
		case StringComparison.OrdinalIgnoreCase:
			for (Int32 i = 0; i < first.Length; i++) {
				if (Char.ToUpperInvariant(first[i]) != Char.ToUpperInvariant(second[i])) {
					d++;
				}
			}
			break;
		case StringComparison.CurrentCulture:
		case StringComparison.Ordinal:
			for (Int32 i = 0; i < first.Length; i++) {
				if (first[i] != second[i]) {
					d++;
				}
			}
			break;
		default:
			throw new ArgumentException();
		}
		return d;
	}

	/// <summary>
	/// Calculates the Levenshtein edit-distance between the <paramref name="first"/> and <paramref name="second"/>.
	/// </summary>
	/// <param name="first">The first text.</param>
	/// <param name="second">The second text.</param>
	/// <returns>The number of edits to get from <paramref name="first"/> to <paramref name="second"/>.</returns>
	/// <remarks>
	/// Levenshtein edit-distance measures the amount of insertions, deletions, and substitutions, between two texts. Because it does not handle transpositions, a transposition will be counted as two substitutions. It can handle two texts of different lengths.
	/// </remarks>
	internal static Int32 Levenshtein(ReadOnlySpan<Char> first, ReadOnlySpan<Char> second) => Levenshtein(first, second, comparisonType: default);


	/// <summary>
	/// Calculates the Levenshtein edit-distance between the <paramref name="first"/> and <paramref name="second"/>.
	/// </summary>
	/// <param name="first">The first text.</param>
	/// <param name="second">The second text.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns>The number of edits to get from <paramref name="first"/> to <paramref name="second"/>.</returns>
	/// <remarks>
	/// Levenshtein edit-distance measures the amount of insertions, deletions, and substitutions, between two texts. Because it does not handle transpositions, a transposition will be counted as two substitutions. It can handle two texts of different lengths.
	/// </remarks>
	[SuppressMessage("Performance", "CA1814:Prefer jagged arrays over multidimensional", Justification = "The entire matrix is used, so a multidimensional array is the correct thing to use.")]
	internal static Int32 Levenshtein(ReadOnlySpan<Char> first, ReadOnlySpan<Char> second, StringComparison comparisonType) {
		Int32 n = first.Length;
		Int32 m = second.Length;

		if (n == 0) {
			return m;
		} else if (m == 0) {
			return n;
		} else {
			Int32[,] d = new Int32[n + 1, m + 1];
			for (Int32 i = 0; i <= n; d[i, 0] = i++) { /* Prework */ }
			for (Int32 j = 0; j <= m; d[0, j] = j++) { /* Prework */ }

			Int32 c;
			for (Int32 i = 1; i <= n; i++) {
				for (Int32 j = 1; j <= m; j++) {
					c = second[j - 1].Equals(first[i - 1], comparisonType) ? 0 : 1;
					d[i, j] = Math.Min(
						Math.Min(
							d[i - 1, j] + 1,
							d[i, j - 1] + 1),
						d[i - 1, j - 1] + c);
				}
			}
			return d[n, m];
		}
	}
}
