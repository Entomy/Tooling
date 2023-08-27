namespace System.Collections.Specialized;

using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Represents the locations of lines within a source file.
/// </summary>
public sealed class LineList : IList<Range> {
	/// <summary>
	/// The backing collection of this <see cref="LineList"/>.
	/// </summary>
	private readonly List<Range> Backing;

	/// <summary>
	/// Initializes a new <see cref="LineList"/>.
	/// </summary>
	public LineList() => Backing = new();

	/// <inheritdoc/>
	public Int32 Count => Backing.Count;

	/// <inheritdoc/>
	Boolean ICollection<Range>.IsReadOnly { get; }

	/// <inheritdoc/>
	public Range this[Int32 index] => Backing[index];

	/// <inheritdoc/>
	Range IList<Range>.this[Int32 index] {
		get => this[index];
		set => Backing[index] = value;
	}

	/// <inheritdoc/>
	void ICollection<Range>.Add(Range item) => Backing.Add(item);

	/// <inheritdoc/>
	void ICollection<Range>.Clear() => Backing.Clear();

	/// <inheritdoc/>
	Boolean ICollection<Range>.Contains(Range item) => Backing.Contains(item);

	/// <inheritdoc/>
	void ICollection<Range>.CopyTo(Range[] array, Int32 arrayIndex) => Backing.CopyTo(array, arrayIndex);

	/// <inheritdoc/>
	public IEnumerator<Range> GetEnumerator() => Backing.GetEnumerator();

	/// <inheritdoc/>
	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	/// <inheritdoc/>
	Int32 IList<Range>.IndexOf(Range item) => Backing.IndexOf(item);

	/// <inheritdoc/>
	void IList<Range>.Insert(Int32 index, Range item) => Backing.Insert(index, item);

	/// <inheritdoc/>
	Boolean ICollection<Range>.Remove(Range item) => Backing.Remove(item);

	/// <inheritdoc/>
	void IList<Range>.RemoveAt(Int32 index) => Backing.RemoveAt(index);
}
