namespace System.Collections.Generic;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	public static T Fold<T>([DisallowNull, NotNull] this IEnumerable<T> collection, Func<T, T, T> func, T identity) {
		T? result = identity;
		if (func is not null) {
			foreach (T item in collection) {
				result = func(result, item);
			}
		}
		return result;
	}

	/// <summary>
	/// Folds the collection into a single element as described by <paramref name="func"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The function describing the folding operation. This is a magma.</param>
	/// <param name="identity">The identity value for <paramref name="func"/>.</param>
	/// <returns>A single element after folding the entire collection.</returns>
	/// <remarks>
	/// <para><paramref name="func"/> is a magma, so associativity like left-fold and right-fold are completely irrelevant.</para>
	/// <para><paramref name="identity"/> is required as a start point for the fold. It needs to be the identity of the <paramref name="func"/> to function properly. For example, the identity of addition is <c>0</c>, and the identity of multiplication is <c>1</c>. Without an appropriate identity, the results will be wrong.</para>
	/// </remarks>
	[CLSCompliant(false)]
	public static unsafe T Fold<T>([DisallowNull, NotNull] this IEnumerable<T> collection, delegate*<T, T, T> func, T identity) {
		T? result = identity;
		foreach (T item in collection) {
			result = func(result, item);
		}
		return result;
	}
}
