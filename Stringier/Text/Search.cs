namespace System.Text;

/// <summary>
/// Provides functions for searching a source text for a pattern.
/// </summary>
internal static class Search {
	/// <summary>
	/// Performs a Rabin-Karp string-search, finding the starting index of the <paramref name="search"/> if found in <paramref name="source"/>.
	/// </summary>
	/// <param name="source">The text to search in.</param>
	/// <param name="search">The text to search for.</param>
	/// <returns>The index at which <paramref name="search"/> was found to start; -1 if not found.</returns>
	/// <remarks>
	/// This searches for <paramref name="search"/> through a rolling-hash, which keeps the search effective while not requiring precomputing tables.
	/// </remarks>
	internal static Int32 RabinKarp(ReadOnlySpan<Char> source, ReadOnlySpan<Char> search) => RabinKarp(source, search, comparisonType: default);

	/// <summary>
	/// Performs a Rabin-Karp string-search, finding the starting index of the <paramref name="second"/> if found in <paramref name="first"/>.
	/// </summary>
	/// <param name="first">The text to search in.</param>
	/// <param name="second">The text to search for.</param>
	/// <param name="comparisonType">An enumeration value that determines how <paramref name="first"/> and <paramref name="second"/> are compared.</param>
	/// <returns>The index at which <paramref name="second"/> was found to start; -1 if not found.</returns>
	/// <remarks>
	/// This searches for <paramref name="second"/> through a rolling-hash, which keeps the search effective while not requiring precomputing tables.
	/// </remarks>
	internal static Int32 RabinKarp(ReadOnlySpan<Char> first, ReadOnlySpan<Char> second, StringComparison comparisonType) {
		Int32 siga = 0;
		Int32 sigb = 0;
		const Int32 Q = 100007;
		const Int32 D = 256;
		for (Int32 i = 0; i < second.Length; i++) {
			siga = ((siga * D) + first[i]) % Q;
			sigb = ((sigb * D) + second[i]) % Q;
		}
		if (siga == sigb) {
			return 0;
		}
		Int32 pow = 1;
		for (Int32 k = 1; k <= second.Length - 1; k++) {
			pow = pow * D % Q;
		}
		for (Int32 j = 1; j <= first.Length - second.Length; j++) {
			siga = (siga + Q - (pow * first[j - 1] % Q)) % Q;
			siga = ((siga * D) + first[j + second.Length - 1]) % Q;
			if (siga == sigb && first.Slice(j, second.Length).Equals(second, comparisonType)) {
				return j;
			}
		}
		return -1;
	}
}
