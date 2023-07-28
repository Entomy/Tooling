namespace System;

public static partial class ClockageExtensions {
	/// <summary>
	/// Determines if this <paramref name="day"/> is a weekday.
	/// </summary>
	/// <param name="day">The <see cref="DayOfWeek"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="day"/> is a weekday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsWeekday(this DayOfWeek day) => day switch {
		DayOfWeek.Monday => true,
		DayOfWeek.Tuesday => true,
		DayOfWeek.Wednesday => true,
		DayOfWeek.Thursday => true,
		DayOfWeek.Friday => true,
		_ => false,
	};

	/// <summary>
	/// Determines if this <paramref name="dateTime"/> is a weekday.
	/// </summary>
	/// <param name="dateTime">The <see cref="DateTime"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="dateTime"/> is a weekday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsWeekday(this DateTime dateTime) => dateTime.DayOfWeek.IsWeekday();

#if NET6_0_OR_GREATER
	/// <summary>
	/// Determines if this <paramref name="date"/> is a weekday.
	/// </summary>
	/// <param name="date">The <see cref="DateOnly"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="date"/> is a weekday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsWeekday(this DateOnly date) => date.DayOfWeek.IsWeekday();
#endif
}
