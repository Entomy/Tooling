namespace System.Collections.Generic;

public static partial class CollectathonExtensions {
	#region Add(Collection, T)
	/// <summary>
	/// Adds the <paramref name="item"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="item">The element to add.</param>
	/// <remarks>
	/// This maps directly to <see cref="LinkedList{T}.AddLast(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this LinkedList<T> collection, T item) => collection?.AddLast(item);

	/// <summary>
	/// Adds the <paramref name="item"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="item">The element to add.</param>
	/// <remarks>
	/// This maps directly to <see cref="Queue{T}.Enqueue(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Queue<T> collection, T item) => collection?.Enqueue(item);

	/// <summary>
	/// Adds the <paramref name="item"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="item">The element to add.</param>
	/// <remarks>
	/// This maps directly to <see cref="Stack{T}.Push(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Stack<T> collection, T item) => collection?.Push(item);
	#endregion

	#region Add(Collection, T[])
	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="LinkedList{T}.AddLast(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this LinkedList<T> collection, params T[]? items) => Add(collection, items.AsSpan());

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Queue{T}.Enqueue(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Queue<T> collection, params T[]? items) => Add(collection, items.AsSpan());

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Stack{T}.Push(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Stack<T> collection, params T[]? items) => Add(collection, items.AsSpan());

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	public static void Add<T>(this ICollection<T> collection, params T[]? items) => Add(collection, items.AsSpan());
	#endregion

	#region Add(Collection, ArraySegment<T>)
	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="LinkedList{T}.AddLast(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this LinkedList<T> collection, ArraySegment<T> items) => Add(collection, items.AsSpan());

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Queue{T}.Enqueue(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Queue<T> collection, ArraySegment<T> items) => Add(collection, items.AsSpan());

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Stack{T}.Push(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Stack<T> collection, ArraySegment<T> items) => Add(collection, items.AsSpan());

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	public static void Add<T>(this ICollection<T> collection, ArraySegment<T> items) => Add(collection, items.AsSpan());
	#endregion

	#region Add(Collection, Memory<T>)
	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="LinkedList{T}.AddLast(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this LinkedList<T> collection, Memory<T> items) => Add(collection, items.Span);

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Queue{T}.Enqueue(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Queue<T> collection, Memory<T> items) => Add(collection, items.Span);

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Stack{T}.Push(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Stack<T> collection, Memory<T> items) => Add(collection, items.Span);

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	public static void Add<T>(this ICollection<T> collection, Memory<T> items) => Add(collection, items.Span);
	#endregion

	#region Add(Collection, ReadOnlyMemory<T>)
	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="LinkedList{T}.AddLast(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this LinkedList<T> collection, ReadOnlyMemory<T> items) => Add(collection, items.Span);

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Queue{T}.Enqueue(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Queue<T> collection, ReadOnlyMemory<T> items) => Add(collection, items.Span);

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Stack{T}.Push(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Stack<T> collection, ReadOnlyMemory<T> items) => Add(collection, items.Span);

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	public static void Add<T>(this ICollection<T> collection, ReadOnlyMemory<T> items) => Add(collection, items.Span);
	#endregion

	#region Add(Collection, Span<T>)
	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="LinkedList{T}.AddLast(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this LinkedList<T> collection, Span<T> items) => Add(collection, (ReadOnlySpan<T>)items);

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Queue{T}.Enqueue(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Queue<T> collection, Span<T> items) => Add(collection, (ReadOnlySpan<T>)items);

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Stack{T}.Push(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Stack<T> collection, Span<T> items) => Add(collection, (ReadOnlySpan<T>)items);

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	public static void Add<T>(this ICollection<T> collection, Span<T> items) => Add(collection, (ReadOnlySpan<T>)items);
	#endregion

	#region Add(Collection, ReadOnlySpan<T>)
	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="LinkedList{T}.AddLast(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this LinkedList<T> collection, ReadOnlySpan<T> items) {
		if (collection is not null) {
			foreach (T item in items) {
				collection.Add(item);
			}
		}
	}

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Queue{T}.Enqueue(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Queue<T> collection, ReadOnlySpan<T> items) {
		if (collection is not null) {
			foreach (T item in items) {
				collection.Enqueue(item);
			}
		}
	}

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Stack{T}.Push(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Stack<T> collection, ReadOnlySpan<T> items) {
		if (collection is not null) {
			foreach (T item in items) {
				collection.Push(item);
			}
		}
	}

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	public static void Add<T>(this ICollection<T> collection, ReadOnlySpan<T> items) {
		if (collection is not null) {
			foreach (T item in items) {
				collection.Add(item);
			}
		}
	}
	#endregion

	#region Add(Collection, IEnumerable<T>)
	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="LinkedList{T}.AddLast(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this LinkedList<T> collection, IEnumerable<T>? items) {
		if (collection is not null && items is not null) {
			foreach (T item in items) {
				collection.Add(item);
			}
		}
	}

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Queue{T}.Enqueue(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Queue<T> collection, IEnumerable<T>? items) {
		if (collection is not null && items is not null) {
			foreach (T item in items) {
				collection.Enqueue(item);
			}
		}
	}

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	/// <remarks>
	/// This maps to <see cref="Stack{T}.Push(T)"/>.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Add<T>(this Stack<T> collection, IEnumerable<T>? items) {
		if (collection is not null && items is not null) {
			foreach (T item in items) {
				collection.Push(item);
			}
		}
	}

	/// <summary>
	/// Adds the <paramref name="items"/> to the <paramref name="collection"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="collection">The collection to add the element to.</param>
	/// <param name="items">The elements to add.</param>
	public static void Add<T>(this ICollection<T> collection, IEnumerable<T>? items) {
		if (collection is not null && items is not null) {
			foreach (T item in items) {
				collection.Add(item);
			}
		}
	}
	#endregion
}
