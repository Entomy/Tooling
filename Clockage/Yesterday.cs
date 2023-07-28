namespace System;

public static partial class ClockageExtensions {
	/// <summary>
	/// Gets the day before the <paramref name="dateTime"/>, at the same time.
	/// </summary>
	/// <param name="dateTime">This <see cref="DateTime"/>.</param>
	/// <returns>The day before the <paramref name="dateTime"/>, at the same time.</returns>
	public static DateTime Yesterday(this DateTime dateTime) => dateTime.AddDays(-1);

#if NET6_0_OR_GREATER
	/// <summary>
	/// Gets the day before the <paramref name="date"/>.
	/// </summary>
	/// <param name="date">This <see cref="DateOnly"/>.</param>
	/// <returns>The day before the <paramref name="date"/>.</returns>
	public static DateOnly Yesterday(this DateOnly date) => date.AddDays(-1);
#endif
}
