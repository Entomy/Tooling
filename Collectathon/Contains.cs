namespace System;

public static partial class CollectathonExtensions {
	#region Contains(Collection, T)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains the specified <paramref name="element"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to attempt to find.</param>
	/// <returns><see langword="true"/> if <paramref name="element"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean Contains<T>(this T[]? collection, T element) where T : IEquatable<T> => MemoryExtensions.Contains(collection.AsSpan(), element);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains the specified <paramref name="element"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to attempt to find.</param>
	/// <returns><see langword="true"/> if <paramref name="element"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean Contains<T>(this ArraySegment<T> collection, T element) where T : IEquatable<T> => MemoryExtensions.Contains(collection.AsSpan(), element);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains the specified <paramref name="element"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to attempt to find.</param>
	/// <returns><see langword="true"/> if <paramref name="element"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean Contains<T>(this Memory<T> collection, T element) where T : IEquatable<T> => MemoryExtensions.Contains(collection.Span, element);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains the specified <paramref name="element"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="element">The element to attempt to find.</param>
	/// <returns><see langword="true"/> if <paramref name="element"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean Contains<T>(this ReadOnlyMemory<T> collection, T element) where T : IEquatable<T> => MemoryExtensions.Contains(collection.Span, element);
	#endregion

	#region Contains(Collection, Predicate<T>)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean Contains<T>(this T[]? collection, Predicate<T>? predicate) where T : IEquatable<T> => Contains(collection.AsSpan(), predicate);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean Contains<T>(this ArraySegment<T> collection, Predicate<T>? predicate) where T : IEquatable<T> => Contains(collection.AsSpan(), predicate);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean Contains<T>(this Memory<T> collection, Predicate<T>? predicate) where T : IEquatable<T> => Contains(collection.Span, predicate);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean Contains<T>(this ReadOnlyMemory<T> collection, Predicate<T>? predicate) where T : IEquatable<T> => Contains(collection.Span, predicate);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean Contains<T>(this Span<T> collection, Predicate<T>? predicate) where T : IEquatable<T> => Contains((ReadOnlySpan<T>)collection, predicate);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	public static Boolean Contains<T>(this ReadOnlySpan<T> collection, Predicate<T>? predicate) where T : IEquatable<T> {
		foreach (T item in collection) {
			if (predicate?.Invoke(item) ?? item is null) {
				return true;
			}
		}
		return false;
	}
	#endregion

	#region Contains(Collection, delegate*<T, Boolean>)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Boolean Contains<T>(this T[]? collection, delegate*<T, Boolean> predicate) where T : IEquatable<T> => Contains(collection.AsSpan(), predicate);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Boolean Contains<T>(this ArraySegment<T> collection, delegate*<T, Boolean> predicate) where T : IEquatable<T> => Contains(collection.AsSpan(), predicate);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Boolean Contains<T>(this Memory<T> collection, delegate*<T, Boolean> predicate) where T : IEquatable<T> => Contains(collection.Span, predicate);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Boolean Contains<T>(this ReadOnlyMemory<T> collection, delegate*<T, Boolean> predicate) where T : IEquatable<T> => Contains(collection.Span, predicate);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	[ExcludeFromCodeCoverage]
	public static unsafe Boolean Contains<T>(this Span<T> collection, delegate*<T, Boolean> predicate) where T : IEquatable<T> => Contains((ReadOnlySpan<T>)collection, predicate);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains an element described by the <paramref name="predicate"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="predicate">The predicate describing the element to attempt to find.</param>
	/// <returns><see langword="true"/> if an element described by the <paramref name="predicate"/> is contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	public static unsafe Boolean Contains<T>(this ReadOnlySpan<T> collection, delegate*<T, Boolean> predicate) where T : IEquatable<T> {
		foreach (T item in collection) {
			if (predicate(item)) {
				return true;
			}
		}
		return false;
	}
	#endregion
}
