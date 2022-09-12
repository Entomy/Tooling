namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Returns the number of values in this <paramref name="range"/>.
	/// </summary>
	/// <param name="range">This <see cref="Range"/>.</param>
	/// <returns>The number of values in the <paramref name="range"/>.</returns>
	public static Int32 Count(this Range range) {
		(_, Int32 length) = range.GetOffsetAndLength(Int32.MaxValue);
		return length;
	}
}
