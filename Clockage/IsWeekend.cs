namespace System;

public static partial class ClockageExtensions {
	/// <summary>
	/// Determines if this <paramref name="day"/> is a weekend.
	/// </summary>
	/// <param name="day">The <see cref="DayOfWeek"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="day"/> is a weekend; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsWeekend(this DayOfWeek day) => day switch {
		DayOfWeek.Sunday => true,
		DayOfWeek.Saturday => true,
		_ => false,
	};

	/// <summary>
	/// Determines if this <paramref name="dateTime"/> is a weekend.
	/// </summary>
	/// <param name="dateTime">The <see cref="DateTime"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="dateTime"/> is a weekend; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsWeekend(this DateTime dateTime) => dateTime.DayOfWeek.IsWeekend();

#if NET6_0_OR_GREATER
	/// <summary>
	/// Determines if this <paramref name="date"/> is a weekend.
	/// </summary>
	/// <param name="date">The <see cref="DateOnly"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="date"/> is a weekend; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsWeekend(this DateOnly date) => date.DayOfWeek.IsWeekend();
#endif
}
