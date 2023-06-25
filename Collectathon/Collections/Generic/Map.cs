namespace System.Collections.Generic;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Applies the <paramref name="func"/> to each element of the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The <see cref="Func{T, TResult}"/> to apply to each element.</param>
	public static void Map<T>([DisallowNull, NotNull] this IList<T> collection, Func<T, T> func) {
		if (func is not null) {
			for (Int32 i = 0; i < collection.Count; i++) {
				collection[i] = func(collection[i]);
			}
		}
	}

	/// <summary>
	/// Applies the <paramref name="func"/> to each element of the collection.
	/// </summary>
	/// <param name="collection">This collection.</param>
	/// <param name="func">The <see cref="Func{T, TResult}"/> to apply to each element.</param>
	[CLSCompliant(false)]
	public static unsafe void Map<T>([DisallowNull, NotNull] this IList<T> collection, delegate*<T, T> func) {
		for (Int32 i = 0; i < collection.Count; i++) {
			collection[i] = func(collection[i]);

		}
	}
}
