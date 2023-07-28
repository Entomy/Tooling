namespace System;

using ExhaustiveMatching;

public static partial class ClockageExtensions {
	/// <summary>
	/// Gets the next <see cref="DayOfWeek.Sunday"/> after this <paramref name="dateTime"/>.
	/// </summary>
	/// <param name="dateTime">This <see cref="DateTime"/>.</param>
	/// <returns>The next <see cref="DayOfWeek.Sunday"/>.</returns>
	public static DateTime NextSunday(this DateTime dateTime) => dateTime.DayOfWeek switch {
		DayOfWeek.Monday => dateTime.AddDays(6),
		DayOfWeek.Tuesday => dateTime.AddDays(5),
		DayOfWeek.Wednesday => dateTime.AddDays(4),
		DayOfWeek.Thursday => dateTime.AddDays(3),
		DayOfWeek.Friday => dateTime.AddDays(2),
		DayOfWeek.Saturday => dateTime.AddDays(1),
		DayOfWeek.Sunday => dateTime.AddDays(7),
		_ => throw ExhaustiveMatch.Failed(dateTime),
	};

#if NET6_0_OR_GREATER
	/// <summary>
	/// Gets the next <see cref="DayOfWeek.Sunday"/> after this <paramref name="date"/>.
	/// </summary>
	/// <param name="date">This <see cref="DateOnly"/>.</param>
	/// <returns>The next <see cref="DayOfWeek.Sunday"/>.</returns>
	public static DateOnly NextSunday(this DateOnly date) => date.DayOfWeek switch {
		DayOfWeek.Monday => date.AddDays(6),
		DayOfWeek.Tuesday => date.AddDays(5),
		DayOfWeek.Wednesday => date.AddDays(4),
		DayOfWeek.Thursday => date.AddDays(3),
		DayOfWeek.Friday => date.AddDays(2),
		DayOfWeek.Saturday => date.AddDays(1),
		DayOfWeek.Sunday => date.AddDays(7),
		_ => throw ExhaustiveMatch.Failed(date),
	};
#endif
}
