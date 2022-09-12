namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Returns an enumerator that iterates through the <paramref name="range"/>.
	/// </summary>
	/// <param name="range">The <see cref="Range"/> specifying the integers to enumerate.</param>
	/// <returns>An enumerator that can be used to iterate through the <paramref name="range"/>.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RangeEnumerator GetEnumerator(this Range range) => new RangeEnumerator(range);
}
