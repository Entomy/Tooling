namespace System;

using ExhaustiveMatching;

public static partial class ClockageExtensions {
	/// <summary>
	/// Gets the next <see cref="DayOfWeek.Friday"/> after this <paramref name="dateTime"/>.
	/// </summary>
	/// <param name="dateTime">This <see cref="DateTime"/>.</param>
	/// <returns>The next <see cref="DayOfWeek.Friday"/>.</returns>
	public static DateTime NextFriday(this DateTime dateTime) => dateTime.DayOfWeek switch {
		DayOfWeek.Monday => dateTime.AddDays(4),
		DayOfWeek.Tuesday => dateTime.AddDays(3),
		DayOfWeek.Wednesday => dateTime.AddDays(2),
		DayOfWeek.Thursday => dateTime.AddDays(1),
		DayOfWeek.Friday => dateTime.AddDays(7),
		DayOfWeek.Saturday => dateTime.AddDays(6),
		DayOfWeek.Sunday => dateTime.AddDays(5),
		_ => throw ExhaustiveMatch.Failed(dateTime),
	};

#if NET6_0_OR_GREATER
	/// <summary>
	/// Gets the next <see cref="DayOfWeek.Friday"/> after this <paramref name="date"/>.
	/// </summary>
	/// <param name="date">This <see cref="DateOnly"/>.</param>
	/// <returns>The next <see cref="DayOfWeek.Friday"/>.</returns>
	public static DateOnly NextFriday(this DateOnly date) => date.DayOfWeek switch {
		DayOfWeek.Monday => date.AddDays(4),
		DayOfWeek.Tuesday => date.AddDays(3),
		DayOfWeek.Wednesday => date.AddDays(2),
		DayOfWeek.Thursday => date.AddDays(1),
		DayOfWeek.Friday => date.AddDays(7),
		DayOfWeek.Saturday => date.AddDays(6),
		DayOfWeek.Sunday => date.AddDays(5),
		_ => throw ExhaustiveMatch.Failed(date),
	};
#endif
}
