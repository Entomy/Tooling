namespace System;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Reverses the sequence of the elements in the entire array.
	/// </summary>
	/// <typeparam name="T">The type of elements in the array.</typeparam>
	/// <param name="source">The array to reverse.</param>
	[ExcludeFromCodeCoverage]
	public static void Reverse<T>(this T[]? source) {
		if (source is not null) {
			Array.Reverse(source);
		}
	}

	/// <summary>
	/// Reverses the sequence of the elements in the entire memory region.
	/// </summary>
	/// <typeparam name="T">The type of elements in the memory region.</typeparam>
	/// <param name="source">The memory region to reverse.</param>
	[ExcludeFromCodeCoverage]
	public static void Reverse<T>(this ArraySegment<T> source) => source.AsSpan().Reverse();

	/// <summary>
	/// Reverses the sequence of the elements in the entire memory region.
	/// </summary>
	/// <typeparam name="T">The type of elements in the memory region.</typeparam>
	/// <param name="source">The memory region to reverse.</param>
	[ExcludeFromCodeCoverage]
	public static void Reverse<T>(this Memory<T> source) => source.Span.Reverse();
}
