namespace System.Collections.Generic;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Postpends the <paramref name="item"/> onto this <paramref name="collection"/>.
	/// </summary>
	/// <param name="collection">The collection to postpend elements onto.</param>
	/// <param name="item">The element to postpend.</param>
	/// <remarks>
	/// This maps directly to <see cref="ICollection{T}.Add(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Postpend<T>(this IList<T> collection, T item) {
		if (collection is not null) {
			collection.Add(item);
		} else {
			throw new ArgumentNullException(nameof(collection));
		}
	}

	/// <summary>
	/// Postpends the <paramref name="item"/> onto this <paramref name="collection"/>.
	/// </summary>
	/// <param name="collection">The collection to postpend elements onto.</param>
	/// <param name="item">The element to postpend.</param>
	/// <remarks>
	/// This maps directly to <see cref="LinkedList{T}.AddLast(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Postpend<T>(this LinkedList<T> collection, T item) {
		if (collection is not null) {
			collection.AddLast(item);
		} else {
			throw new ArgumentNullException(nameof(collection));
		}
	}
}
