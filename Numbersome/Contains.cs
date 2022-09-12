namespace System;

public static partial class NumbersomeExtensions {
	/// <summary>
	/// Determines whether this <paramref name="range"/> contains the specified <paramref name="value"/>.
	/// </summary>
	/// <param name="range">This <see cref="Range"/>.</param>
	/// <param name="value">The <see cref="Int32"/> value to attempt to find.</param>
	/// <returns><see langword="true"/> if <paramref name="value"/> is contained in this <paramref name="range"/>; otherwise, <see langword="false"/>.</returns>
	public static Boolean Contains(this Range range, Int32 value) {
		(Int32 start, Int32 length) = range.GetOffsetAndLength(Int32.MaxValue);
		Int32 end = start + length;
		return start <= value && value <= end;
	}
}
