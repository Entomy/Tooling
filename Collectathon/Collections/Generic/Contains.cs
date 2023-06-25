namespace System.Collections.Generic;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	public static Boolean Contains<T>(this IEnumerable<T> collection, Predicate<T>? predicate) where T : IEquatable<T> {
		if (collection is not null) {
			foreach (T item in collection) {
				if (predicate?.Invoke(item) ?? item is null) {
					return true;
				}
			}
		}
		return false;
	}

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	public static unsafe Boolean Contains<T>(this IEnumerable<T> collection, delegate*<T, Boolean> predicate) where T : IEquatable<T> {
		if (collection is not null) {
			foreach (T item in collection) {
				if (predicate(item)) {
					return true;
				}
			}
		}
		return false;
	}
}
