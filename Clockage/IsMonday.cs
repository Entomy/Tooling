namespace System;

public static partial class ClockageExtensions {
	/// <summary>
	/// Determines if this <paramref name="day"/> is a monday.
	/// </summary>
	/// <param name="day">The <see cref="DayOfWeek"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="day"/> is a monday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsMonday(this DayOfWeek day) => day == DayOfWeek.Monday;

	/// <summary>
	/// Determines if this <paramref name="dateTime"/> is a monday.
	/// </summary>
	/// <param name="dateTime">The <see cref="DateTime"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="dateTime"/> is a monday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsMonday(this DateTime dateTime) => dateTime.DayOfWeek == DayOfWeek.Monday;

#if NET6_0_OR_GREATER
	/// <summary>
	/// Determines if this <paramref name="date"/> is a monday.
	/// </summary>
	/// <param name="date">The <see cref="DateOnly"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="date"/> is a monday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsMonday(this DateOnly date) => date.DayOfWeek == DayOfWeek.Monday;
#endif
}
