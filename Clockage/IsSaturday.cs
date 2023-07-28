﻿namespace System;

public static partial class ClockageExtensions {
	/// <summary>
	/// Determines if this <paramref name="day"/> is a saturday.
	/// </summary>
	/// <param name="day">The <see cref="DayOfWeek"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="day"/> is a saturday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsSaturday(this DayOfWeek day) => day == DayOfWeek.Saturday;

	/// <summary>
	/// Determines if this <paramref name="dateTime"/> is a saturday.
	/// </summary>
	/// <param name="dateTime">The <see cref="DateTime"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="dateTime"/> is a saturday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsSaturday(this DateTime dateTime) => dateTime.DayOfWeek == DayOfWeek.Saturday;

#if NET6_0_OR_GREATER
	/// <summary>
	/// Determines if this <paramref name="date"/> is a saturday.
	/// </summary>
	/// <param name="date">The <see cref="DateOnly"/> to check.</param>
	/// <returns><see langword="true"/> if <paramref name="date"/> is a saturday; otherwise, <see langword="false"/>.</returns>
	public static Boolean IsSaturday(this DateOnly date) => date.DayOfWeek == DayOfWeek.Saturday;
#endif
}
