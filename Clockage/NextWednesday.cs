namespace System;

using ExhaustiveMatching;

public static partial class ClockageExtensions {
	/// <summary>
	/// Gets the next <see cref="DayOfWeek.Wednesday"/> after this <paramref name="dateTime"/>.
	/// </summary>
	/// <param name="dateTime">This <see cref="DateTime"/>.</param>
	/// <returns>The next <see cref="DayOfWeek.Wednesday"/>.</returns>
	public static DateTime NextWednesday(this DateTime dateTime) => dateTime.DayOfWeek switch {
		DayOfWeek.Monday => dateTime.AddDays(2),
		DayOfWeek.Tuesday => dateTime.AddDays(1),
		DayOfWeek.Wednesday => dateTime.AddDays(7),
		DayOfWeek.Thursday => dateTime.AddDays(6),
		DayOfWeek.Friday => dateTime.AddDays(5),
		DayOfWeek.Saturday => dateTime.AddDays(4),
		DayOfWeek.Sunday => dateTime.AddDays(3),
		_ => throw ExhaustiveMatch.Failed(dateTime),
	};

#if NET6_0_OR_GREATER
	/// <summary>
	/// Gets the next <see cref="DayOfWeek.Wednesday"/> after this <paramref name="date"/>.
	/// </summary>
	/// <param name="date">This <see cref="DateOnly"/>.</param>
	/// <returns>The next <see cref="DayOfWeek.Wednesday"/>.</returns>
	public static DateOnly NextWednesday(this DateOnly date) => date.DayOfWeek switch {
		DayOfWeek.Monday => date.AddDays(2),
		DayOfWeek.Tuesday => date.AddDays(6),
		DayOfWeek.Wednesday => date.AddDays(7),
		DayOfWeek.Thursday => date.AddDays(6),
		DayOfWeek.Friday => date.AddDays(5),
		DayOfWeek.Saturday => date.AddDays(4),
		DayOfWeek.Sunday => date.AddDays(3),
		_ => throw ExhaustiveMatch.Failed(date),
	};
#endif
}
