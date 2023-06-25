namespace System;

public static partial class CollectathonExtensions {
	#region ContainsAll(T[], Collection)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this T[]? collection, T[]? elements) where T : IEquatable<T> => ContainsAll(collection.AsSpan(), elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this T[]? collection, ArraySegment<T> elements) where T : IEquatable<T> => ContainsAll(collection.AsSpan(), elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this T[]? collection, Memory<T> elements) where T : IEquatable<T> => ContainsAll(collection.AsSpan(), elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this T[]? collection, ReadOnlyMemory<T> elements) where T : IEquatable<T> => ContainsAll(collection.AsSpan(), elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this T[]? collection, Span<T> elements) where T : IEquatable<T> => ContainsAll(collection.AsSpan(), (ReadOnlySpan<T>)elements);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this T[]? collection, ReadOnlySpan<T> elements) where T : IEquatable<T> => ContainsAll(collection.AsSpan(), elements);
	#endregion

	#region ContainsAll(ArraySegment<T>, Collection)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ArraySegment<T> collection, T[]? elements) where T : IEquatable<T> => ContainsAll(collection.AsSpan(), elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ArraySegment<T> collection, ArraySegment<T> elements) where T : IEquatable<T> => ContainsAll(collection.AsSpan(), elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ArraySegment<T> collection, Memory<T> elements) where T : IEquatable<T> => ContainsAll(collection.AsSpan(), elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ArraySegment<T> collection, ReadOnlyMemory<T> elements) where T : IEquatable<T> => ContainsAll(collection.AsSpan(), elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ArraySegment<T> collection, Span<T> elements) where T : IEquatable<T> => ContainsAll(collection.AsSpan(), (ReadOnlySpan<T>)elements);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ArraySegment<T> collection, ReadOnlySpan<T> elements) where T : IEquatable<T> => ContainsAll(collection.AsSpan(), elements);
	#endregion

	#region ContainsAll(Memory<T>, Collection)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this Memory<T> collection, T[]? elements) where T : IEquatable<T> => ContainsAll(collection.Span, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this Memory<T> collection, ArraySegment<T> elements) where T : IEquatable<T> => ContainsAll(collection.Span, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this Memory<T> collection, Memory<T> elements) where T : IEquatable<T> => ContainsAll(collection.Span, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this Memory<T> collection, ReadOnlyMemory<T> elements) where T : IEquatable<T> => ContainsAll(collection.Span, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this Memory<T> collection, Span<T> elements) where T : IEquatable<T> => ContainsAll(collection.Span, (ReadOnlySpan<T>)elements);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this Memory<T> collection, ReadOnlySpan<T> elements) where T : IEquatable<T> => ContainsAll(collection.Span, elements);
	#endregion

	#region ContainsAll(ReadOnlyMemory<T>, Collection)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ReadOnlyMemory<T> collection, T[]? elements) where T : IEquatable<T> => ContainsAll(collection.Span, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ReadOnlyMemory<T> collection, ArraySegment<T> elements) where T : IEquatable<T> => ContainsAll(collection.Span, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ReadOnlyMemory<T> collection, Memory<T> elements) where T : IEquatable<T> => ContainsAll(collection.Span, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ReadOnlyMemory<T> collection, ReadOnlyMemory<T> elements) where T : IEquatable<T> => ContainsAll(collection.Span, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ReadOnlyMemory<T> collection, Span<T> elements) where T : IEquatable<T> => ContainsAll(collection.Span, (ReadOnlySpan<T>)elements);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ReadOnlyMemory<T> collection, ReadOnlySpan<T> elements) where T : IEquatable<T> => ContainsAll(collection.Span, elements);
	#endregion

	#region ContainsAll(Span<T>, Collection)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this Span<T> collection, T[]? elements) where T : IEquatable<T> => ContainsAll((ReadOnlySpan<T>)collection, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this Span<T> collection, ArraySegment<T> elements) where T : IEquatable<T> => ContainsAll((ReadOnlySpan<T>)collection, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this Span<T> collection, Memory<T> elements) where T : IEquatable<T> => ContainsAll((ReadOnlySpan<T>)collection, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this Span<T> collection, ReadOnlyMemory<T> elements) where T : IEquatable<T> => ContainsAll((ReadOnlySpan<T>)collection, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this Span<T> collection, Span<T> elements) where T : IEquatable<T> => ContainsAll((ReadOnlySpan<T>)collection, (ReadOnlySpan<T>)elements);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this Span<T> collection, ReadOnlySpan<T> elements) where T : IEquatable<T> => ContainsAll((ReadOnlySpan<T>)collection, elements);
	#endregion

	#region ContainsAll(ReadOnlySpan<T>, Collection)
	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ReadOnlySpan<T> collection, T[]? elements) where T : IEquatable<T> => ContainsAll(collection, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ReadOnlySpan<T> collection, ArraySegment<T> elements) where T : IEquatable<T> => ContainsAll(collection, elements.AsSpan());

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ReadOnlySpan<T> collection, Memory<T> elements) where T : IEquatable<T> => ContainsAll(collection, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ReadOnlySpan<T> collection, ReadOnlyMemory<T> elements) where T : IEquatable<T> => ContainsAll(collection, elements.Span);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	[ExcludeFromCodeCoverage]
	public static Boolean ContainsAll<T>(this ReadOnlySpan<T> collection, Span<T> elements) where T : IEquatable<T> => ContainsAll(collection, (ReadOnlySpan<T>)elements);

	/// <summary>
	/// Determines whether this <paramref name="collection"/> contains all of the specified <paramref name="elements"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the collection.</typeparam>
	/// <param name="collection">This collection.</param>
	/// <param name="elements">The elements to attempt to find.</param>
	/// <returns><see langword="true"/> if all of the <paramref name="elements"/> are contained in this <paramref name="collection"/>; otherwise, <see langword="false"/>.</returns>
	public static Boolean ContainsAll<T>(this ReadOnlySpan<T> collection, ReadOnlySpan<T> elements) where T : IEquatable<T> {
		foreach (T element in elements) {
			if (!collection.Contains(element)) {
				return false;
			}
		}
		return true;
	}
	#endregion
}
