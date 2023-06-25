namespace System.Collections.Generic;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Prepends the <paramref name="item"/> onto this <paramref name="collection"/>.
	/// </summary>
	/// <param name="collection">The collection to prepend elements onto.</param>
	/// <param name="item">The element to prepend.</param>
	/// <remarks>
	/// This maps directly to <see cref="IList{T}.Insert(Int32, T)"/> at an index of <c>0</c>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Prepend<T>(this IList<T> collection, T item) {
		if (collection is not null) {
			collection.Insert(0, item);
		} else {
			throw new ArgumentNullException(nameof(collection));
		}
	}

	/// <summary>
	/// Prepends the <paramref name="item"/> onto this <paramref name="collection"/>.
	/// </summary>
	/// <param name="collection">The collection to prepend elements onto.</param>
	/// <param name="item">The element to prepend.</param>
	/// <remarks>
	/// This maps directly to <see cref="LinkedList{T}.AddFirst(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Prepend<T>(this LinkedList<T> collection, T item) {
		if (collection is not null) {
			collection.AddFirst(item);
		} else {
			throw new ArgumentNullException(nameof(collection));
		}
	}
}
