namespace System;

public static partial class ClockageExtensions {
	/// <summary>
	/// Determines if this <paramref name="day"/> is a wednesday.
	/// </summary>
	/// <param name="day">The <see cref="DayOfWeek"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="day"/> is a wednesday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsWednesday(this DayOfWeek day) => day == DayOfWeek.Wednesday;

	/// <summary>
	/// Determines if this <paramref name="dateTime"/> is a wednesday.
	/// </summary>
	/// <param name="dateTime">The <see cref="DateTime"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="dateTime"/> is a wednesday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsWednesday(this DateTime dateTime) => dateTime.DayOfWeek == DayOfWeek.Wednesday;

#if NET6_0_OR_GREATER
	/// <summary>
	/// Determines if this <paramref name="date"/> is a wednesday.
	/// </summary>
	/// <param name="date">The <see cref="DateOnly"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="date"/> is a wednesday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsWednesday(this DateOnly date) => date.DayOfWeek == DayOfWeek.Wednesday;
#endif
}
