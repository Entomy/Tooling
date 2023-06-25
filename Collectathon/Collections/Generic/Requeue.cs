namespace System.Collections.Generic;

public static partial class CollectathonExtensions {
	/// <summary>
	/// Requeues the next element.
	/// </summary>
	/// <typeparam name="T">The type of the elements.</typeparam>
	/// <param name="queue">This queue.</param>
	public static void Requeue<T>(this Queue<T>? queue) => queue?.Enqueue(queue.Dequeue());
}
