namespace System;

/// <summary>
/// Supports a simple iteration over a <see cref="Range"/>.
/// </summary>
public ref struct RangeEnumerator {
	private readonly Int32 end;

	private readonly Boolean isForeward;

	private readonly Int32 start;

	/// <summary>
	/// Initializes a new <see cref="RangeEnumerator"/>.
	/// </summary>
	/// <param name="range">The <see cref="Range"/> to enumerate.</param>
	internal RangeEnumerator(Range range) {
		end = range.End.Value;
		start = range.Start.Value;
		isForeward = range.Start.Value <= range.End.Value;
		Current = isForeward ? start - 1 : start + 1;
	}

	/// <summary>
	/// Gets the element in the <see cref="Range"/> at the current position of the enumerator.
	/// </summary>
	public Int32 Current { get; private set; }

	/// <summary>
	/// Advances the enumerator to the next element of the <see cref="Range"/>.
	/// </summary>
	/// <returns><see langword="true"/> if the enumerator was successfully advanced to the next element; <see langword="false"/> if the enumerator has passed the end of the <see cref="Range"/>.</returns>
	public Boolean MoveNext() {
		if (isForeward) {
			Current++;
			return Current < end;
		} else {
			Current--;
			return Current > end;
		}
	}

	/// <summary>
	/// Sets the enumerator to its initial position, which is before the first element in the <see cref="Range"/>.
	/// </summary>
	public void Reset() => Current = isForeward ? start - 1 : start + 1;
}
