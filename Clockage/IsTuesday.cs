namespace System;

public static partial class ClockageExtensions {
	/// <summary>
	/// Determines if this <paramref name="day"/> is a tuesday.
	/// </summary>
	/// <param name="day">The <see cref="DayOfWeek"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="day"/> is a tuesday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsTuesday(this DayOfWeek day) => day == DayOfWeek.Tuesday;

	/// <summary>
	/// Determines if this <paramref name="dateTime"/> is a tuesday.
	/// </summary>
	/// <param name="dateTime">The <see cref="DateTime"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="dateTime"/> is a tuesday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsTuesday(this DateTime dateTime) => dateTime.DayOfWeek == DayOfWeek.Tuesday;

#if NET6_0_OR_GREATER
	/// <summary>
	/// Determines if this <paramref name="date"/> is a tuesday.
	/// </summary>
	/// <param name="date">The <see cref="DateOnly"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="date"/> is a tuesday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsTuesday(this DateOnly date) => date.DayOfWeek == DayOfWeek.Tuesday;
#endif
}
