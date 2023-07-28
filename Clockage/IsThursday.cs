namespace System;

public static partial class ClockageExtensions {
	/// <summary>
	/// Determines if this <paramref name="day"/> is a thursday.
	/// </summary>
	/// <param name="day">The <see cref="DayOfWeek"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="day"/> is a thursday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsThursday(this DayOfWeek day) => day == DayOfWeek.Thursday;

	/// <summary>
	/// Determines if this <paramref name="dateTime"/> is a thursday.
	/// </summary>
	/// <param name="dateTime">The <see cref="DateTime"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="dateTime"/> is a thursday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsThursday(this DateTime dateTime) => dateTime.DayOfWeek == DayOfWeek.Thursday;

#if NET6_0_OR_GREATER
	/// <summary>
	/// Determines if this <paramref name="date"/> is a thursday.
	/// </summary>
	/// <param name="date">The <see cref="DateOnly"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="date"/> is a thursday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsThursday(this DateOnly date) => date.DayOfWeek == DayOfWeek.Thursday;
#endif
}
