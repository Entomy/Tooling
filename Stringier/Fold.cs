namespace System;

public static partial class StringierExtensions {
	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static Char Fold(this String? collection, Func<Char, Char, Char> func, Char identity) => CollectathonExtensions.Fold(collection.AsSpan(), func, identity);

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Char Fold(this String? collection, delegate*<Char, Char, Char> func, Char identity) => CollectathonExtensions.Fold(collection.AsSpan(), func, identity);

	#region Fold(Text, Func<Rune, Rune, Rune>, Rune)
	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static Rune Fold(this String? collection, Func<Rune, Rune, Rune> func, Rune identity) => Fold(collection.AsSpan(), func, identity);

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static Rune Fold(this Char[]? collection, Func<Rune, Rune, Rune> func, Rune identity) => Fold(collection.AsSpan(), func, identity);

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static Rune Fold(this ArraySegment<Char> collection, Func<Rune, Rune, Rune> func, Rune identity) => Fold(collection.AsSpan(), func, identity);

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static Rune Fold(this Memory<Char> collection, Func<Rune, Rune, Rune> func, Rune identity) => Fold(collection.Span, func, identity);

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static Rune Fold(this ReadOnlyMemory<Char> collection, Func<Rune, Rune, Rune> func, Rune identity) => Fold(collection.Span, func, identity);

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[ExcludeFromCodeCoverage]
	public static Rune Foldo(this Span<Char> collection, Func<Rune, Rune, Rune> func, Rune identity) => Fold((ReadOnlySpan<Char>)collection, func, identity);

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	public static Rune Fold(this ReadOnlySpan<Char> collection, Func<Rune, Rune, Rune> func, Rune identity) {
		Rune result = identity;
		if (func is not null) {
			foreach (Rune item in collection.EnumerateRunes()) {
				result = func(result, item);
			}
		}
		return result;
	}
	#endregion

	#region Fold(Text, delegate*<Rune, Rune, Rune>, Rune)
	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Rune Fold(this String? collection, delegate*<Rune, Rune, Rune> func, Rune identity) => Fold(collection, func, identity);

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Rune Fold(this Char[]? collection, delegate*<Rune, Rune, Rune> func, Rune identity) => Fold(collection.AsSpan(), func, identity);

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Rune Fold(this ArraySegment<Char> collection, delegate*<Rune, Rune, Rune> func, Rune identity) => Fold(collection.AsSpan(), func, identity);

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Rune Fold(this Memory<Char> collection, delegate*<Rune, Rune, Rune> func, Rune identity) => Fold(collection.Span, func, identity);

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Rune Fold(this ReadOnlyMemory<Char> collection, delegate*<Rune, Rune, Rune> func, Rune identity) => Fold(collection.Span, func, identity);

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Rune Fold(this Span<Char> collection, delegate*<Rune, Rune, Rune> func, Rune identity) => Fold((ReadOnlySpan<Char>)collection, func, identity);

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[CLSCompliant(false)]
	public static unsafe Rune Fold(this ReadOnlySpan<Char> collection, delegate*<Rune, Rune, Rune> func, Rune identity) {
		Rune result = identity;
		foreach (Rune item in collection.EnumerateRunes()) {
			result = func(result, item);
		}
		return result;
	}
	#endregion
}
