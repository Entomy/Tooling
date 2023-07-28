namespace System;

public static partial class ClockageExtensions {
	/// <summary>
	/// Determines if this <paramref name="day"/> is a sunday.
	/// </summary>
	/// <param name="day">The <see cref="DayOfWeek"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="day"/> is a sunday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsSunday(this DayOfWeek day) => day == DayOfWeek.Sunday;

	/// <summary>
	/// Determines if this <paramref name="dateTime"/> is a sunday.
	/// </summary>
	/// <param name="dateTime">The <see cref="DateTime"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="dateTime"/> is a sunday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsSunday(this DateTime dateTime) => dateTime.DayOfWeek == DayOfWeek.Sunday;

#if NET6_0_OR_GREATER
	/// <summary>
	/// Determines if this <paramref name="date"/> is a sunday.
	/// </summary>
	/// <param name="date">The <see cref="DateOnly"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="date"/> is a sunday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsSunday(this DateOnly date) => date.DayOfWeek == DayOfWeek.Sunday;
#endif
}
