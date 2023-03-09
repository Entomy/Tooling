namespace Defender;

using System.Collections.Generic;

public class GuardTests {
	[Theory]
	[InlineData("", false)]
	[InlineData("hello", true)]
	public void Empty_String(String actual, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.Empty(actual));
	}

	[Theory]
	[InlineData(new Int32[] { }, false)]
	[InlineData(new Int32[] { 1, 2, 3, 4, 5 }, true)]
	public void Empty_Array(Int32[] actual, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.Empty(actual));
	}

	[Theory]
	[InlineData(new Int32[] { }, false)]
	[InlineData(new Int32[] { 1, 2, 3, 4, 5 }, true)]
	public void Empty_ArraySegment(Int32[] actual, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.Empty(new ArraySegment<Int32>(actual)));
	}

	[Theory]
	[InlineData(new Int32[] { }, false)]
	[InlineData(new Int32[] { 1, 2, 3, 4, 5 }, true)]
	public void Empty_Memory(Int32[] actual, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.Empty(actual.AsMemory()));
	}

	[Theory]
	[InlineData(new Int32[] { }, false)]
	[InlineData(new Int32[] { 1, 2, 3, 4, 5 }, true)]
	public void Empty_ReadOnlyMemory(Int32[] actual, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.Empty((ReadOnlyMemory<Int32>)actual.AsMemory()));
	}

	[Theory]
	[InlineData(new Int32[] { }, false)]
	[InlineData(new Int32[] { 1, 2, 3, 4, 5 }, true)]
	public void Empty_Span(Int32[] actual, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.Empty(actual.AsSpan()));
	}

	[Theory]
	[InlineData(new Int32[] { }, false)]
	[InlineData(new Int32[] { 1, 2, 3, 4, 5 }, true)]
	public void Empty_ReadOnlySpan(Int32[] actual, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.Empty((ReadOnlySpan<Int32>)actual.AsSpan()));
	}

	[Theory]
	[InlineData(new Int32[] { }, false)]
	[InlineData(new Int32[] { 1, 2, 3, 4, 5 }, true)]
	public void Empty_Enumerable(Int32[] actual, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.Empty(new List<Int32>(actual)));
	}

	[Theory]
	[InlineData(1, 1, false)]
	[InlineData(1, 2, true)]
	public void Equals_Object(Object actual, Object expected, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.Equals(actual, expected));
	}

	[Theory]
	[InlineData(1, 1, false)]
	[InlineData(1, 2, true)]
	public void Equals_IEquatable(Int32 actual, Int32 expected, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.Equals(actual, expected));
	}

	[Theory]
	[InlineData(false, false)]
	[InlineData(true, true)]
	public void False(Boolean actual, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.False(actual));
	}

	[Theory]
	[InlineData(2, 1, false)]
	[InlineData(1, 1, true)]
	[InlineData(0, 1, true)]
	public void GreaterThan(Int32 actual, Int32 expected, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.GreaterThan(actual, expected));
	}

	[Theory]
	[InlineData(2, 1, false)]
	[InlineData(1, 1, false)]
	[InlineData(0, 1, true)]
	public void GreaterThanOrEqualTo(Int32 actual, Int32 expected, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.GreaterThanOrEqualTo(actual, expected));
	}

	[Theory]
	[InlineData(0, 0, false)]
	[InlineData(0, 1, true)]
	[InlineData('a', 42, false)]
	[InlineData('a', 62, true)]
	public void HashCode<T>(T actual, Int32 expected, Boolean throws) where T : notnull {
		if (throws) Assert.Throws<GuardException>(() => Guard.HashCode(actual, expected));
	}

	[Theory]
	[InlineData(2, 1, true)]
	[InlineData(1, 1, true)]
	[InlineData(0, 1, false)]
	public void LesserThan(Int32 actual, Int32 expected, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.LesserThan(actual, expected));
	}

	[Theory]
	[InlineData(2, 1, true)]
	[InlineData(1, 1, false)]
	[InlineData(0, 1, false)]
	public void LesserThanOrEqualTo(Int32 actual, Int32 expected, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.LesserThanOrEqualTo(actual, expected));
	}

	[Theory]
	[InlineData("", false)]
	[InlineData(null, true)]
	public void NotNull(Object actual, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.NotNull(actual));
	}

	[Theory]
	[InlineData(null, false)]
	[InlineData("", true)]
	public void Null(Object actual, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.Null(actual));
	}

	[Theory]
	[InlineData(true, false)]
	[InlineData(false, true)]
	public void True(Boolean actual, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.True(actual));
	}

	[Theory]
	[InlineData(1, 1, false)]
	[InlineData(1, 'a', true)]
	[InlineData('a', 'a', false)]
	[InlineData('a', 1, true)]
	public void Type<T>(Object actual, T token, Boolean throws) {
		if (throws) Assert.Throws<GuardException>(() => Guard.Type<T>(actual));
	}

	[Theory]
	[InlineData(ConsoleColor.Black, false)]
	[InlineData((ConsoleColor)16, true)]
	public void Valid<T>(T actual, Boolean throws) where T : struct, Enum {
		if (throws) Assert.Throws<GuardException>(() => Guard.Valid(actual));
	}
}
