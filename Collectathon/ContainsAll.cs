namespace System;

public static partial class CollectathonExtensions {
	#region ContainsAny(T[], Collection)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]	
	public static Boolean ContainsAny<T>(this T[]? collection, T[]? elements) where T : IEquatable<T> => ContainsAny(collection.AsSpan(), elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this T[]? collection, ArraySegment<T> elements) where T : IEquatable<T> => ContainsAny(collection.AsSpan(), elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this T[]? collection, Memory<T> elements) where T : IEquatable<T> => ContainsAny(collection.AsSpan(), elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this T[]? collection, ReadOnlyMemory<T> elements) where T : IEquatable<T> => ContainsAny(collection.AsSpan(), elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this T[]? collection, Span<T> elements) where T : IEquatable<T> => ContainsAny(collection.AsSpan(), (ReadOnlySpan<T>)elements);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this T[]? collection, ReadOnlySpan<T> elements) where T : IEquatable<T> => ContainsAny(collection.AsSpan(), elements);
	#endregion

	#region ContainsAny(Memory<T>, Collection)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this Memory<T> collection, T[]? elements) where T : IEquatable<T> => ContainsAny(collection.Span, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this Memory<T> collection, ArraySegment<T> elements) where T : IEquatable<T> => ContainsAny(collection.Span, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this Memory<T> collection, Memory<T> elements) where T : IEquatable<T> => ContainsAny(collection.Span, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this Memory<T> collection, ReadOnlyMemory<T> elements) where T : IEquatable<T> => ContainsAny(collection.Span, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this Memory<T> collection, Span<T> elements) where T : IEquatable<T> => ContainsAny(collection.Span, (ReadOnlySpan<T>)elements);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this Memory<T> collection, ReadOnlySpan<T> elements) where T : IEquatable<T> => ContainsAny(collection.Span, elements);
	#endregion

	#region ContainsAny(ReadOnlyMemory<T>, Collection)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this ReadOnlyMemory<T> collection, T[]? elements) where T : IEquatable<T> => ContainsAny(collection.Span, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this ReadOnlyMemory<T> collection, ArraySegment<T> elements) where T : IEquatable<T> => ContainsAny(collection.Span, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this ReadOnlyMemory<T> collection, Memory<T> elements) where T : IEquatable<T> => ContainsAny(collection.Span, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this ReadOnlyMemory<T> collection, ReadOnlyMemory<T> elements) where T : IEquatable<T> => ContainsAny(collection.Span, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this ReadOnlyMemory<T> collection, Span<T> elements) where T : IEquatable<T> => ContainsAny(collection.Span, (ReadOnlySpan<T>)elements);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this ReadOnlyMemory<T> collection, ReadOnlySpan<T> elements) where T : IEquatable<T> => ContainsAny(collection.Span, elements);
	#endregion

	#region ContainsAny(Span<T>, Collection)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this Span<T> collection, T[]? elements) where T : IEquatable<T> => ContainsAny((ReadOnlySpan<T>)collection, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this Span<T> collection, ArraySegment<T> elements) where T : IEquatable<T> => ContainsAny((ReadOnlySpan<T>)collection, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this Span<T> collection, Memory<T> elements) where T : IEquatable<T> => ContainsAny((ReadOnlySpan<T>)collection, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this Span<T> collection, ReadOnlyMemory<T> elements) where T : IEquatable<T> => ContainsAny((ReadOnlySpan<T>)collection, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this Span<T> collection, Span<T> elements) where T : IEquatable<T> => ContainsAny((ReadOnlySpan<T>)collection, (ReadOnlySpan<T>)elements);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this Span<T> collection, ReadOnlySpan<T> elements) where T : IEquatable<T> => ContainsAny((ReadOnlySpan<T>)collection, elements);
	#endregion

	#region ContainsAny(ReadOnlySpan<T>, Collection)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this ReadOnlySpan<T> collection, T[]? elements) where T : IEquatable<T> => ContainsAny(collection, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this ReadOnlySpan<T> collection, ArraySegment<T> elements) where T : IEquatable<T> => ContainsAny(collection, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this ReadOnlySpan<T> collection, Memory<T> elements) where T : IEquatable<T> => ContainsAny(collection, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this ReadOnlySpan<T> collection, ReadOnlyMemory<T> elements) where T : IEquatable<T> => ContainsAny(collection, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAny<T>(this ReadOnlySpan<T> collection, Span<T> elements) where T : IEquatable<T> => ContainsAny(collection, (ReadOnlySpan<T>)elements);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains any of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if any of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	public static Boolean ContainsAny<T>(this ReadOnlySpan<T> collection, ReadOnlySpan<T> elements) where T : IEquatable<T> {
		foreach (T element in elements) {
			if (collection.Contains(element)) {
				return true;
			}
		}
		return false;
	}
	#endregion
}
