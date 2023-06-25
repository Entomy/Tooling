namespace System.Collections.Generic;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Count all occurrences of <paramref name="element"/> in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	public static Int32 Occurrences<T>(this IEnumerable<T>? collection, T element) {
		Int32 count = 0;
		if (collection is not null) {
			foreach (T item in collection) {
				if (Equals(element, item)) {
					count++;
				}
			}
		}
		return count;
	}

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	public static Int32 Occurrences<T>(this IEnumerable<T>? collection, Predicate<T>? predicate) {
		Int32 count = 0;
		if (collection is not null) {
			foreach (T item in collection) {
				if (predicate?.Invoke(item) ?? item is null) {
					count++;
				}
			}
		}
		return count;
	}

	/// <summary>
	/// Count all occurrences of elements that match the provided predicate in the collection.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The <see cref="Predicate{T}"/> describing a match of the elements to count.</param>
	/// <returns>The amount of occurrences found.</returns>
	[CLSCompliant(false)]
	public static unsafe Int32 Occurrences<T>(this IEnumerable<T>? collection, delegate*<T, Boolean> predicate) {
		Int32 count = 0;
		if (collection is not null) {
			foreach (T item in collection) {
				if (predicate(item)) {
					count++;
				}
			}
		}
		return count;
	}
}
