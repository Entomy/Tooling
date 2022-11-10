namespace System.Numerics;

using System.Diagnostics.CodeAnalysis;

public class PercentTests {
	[Theory]
	[InlineData(0.0, 0.0, 0.0)]
	[InlineData(1.0, 1.0, 2.0)]
	public void Add_Percent(Double left, Double right, Double expected) => Assert.Equal(new Percent<Double>(expected), new Percent<Double>(left) + new Percent<Double>(right));

	[Theory]
	[InlineData(0.0, 50.0, 0.0)]
	[InlineData(10.0, 50.0, 15.0)]
	public void Add_Value(Double value, Double percentage, Double expected) => Assert.Equal(expected, value + new Percent<Double>(percentage));

	[Fact]
	public void AdditiveIdentity() => Assert.Equal(Percent<Int32>.AdditiveIdentity, new Percent<Int32>(0));

	[Fact]
	public void Constructor() => new Percent<Int32>();

	[Theory]
	[InlineData(0.0, 0.0, Double.NaN)]
	[InlineData(1.0, 1.0, 1.0)]
	public void Divide(Double left, Double right, Double expected) => Assert.Equal(new Percent<Double>(expected), new Percent<Double>(left) / new Percent<Double>(right));

	[Fact]
	[SuppressMessage("Usage", "xUnit1024:Test methods cannot have overloads", Justification = "The test isn't overloaded, this just tests a method all classes have.")]
	public void Equals() {
		Assert.Equal(new Percent<Int32>(0), new Percent<Int32>(0));
		Assert.True(new Percent<Int32>(0).Equals(new Percent<Int32>(0)));
		Assert.True(new Percent<Int32>(0).Equals((Object)new Percent<Int32>(0)));
		Assert.False(new Percent<Int32>(0).Equals('a'));
		Assert.True(new Percent<Int32>(0) == new Percent<Int32>(0));
		Assert.True(new Percent<Int32>(0) != new Percent<Int32>(1));
	}

	[Theory]
	[InlineData(0)]
	[InlineData(100)]
	[SuppressMessage("Usage", "xUnit1024:Test methods cannot have overloads", Justification = "The test isn't overloaded, this just tests a method all classes have.")]
	public void GetHashCode(Int32 value) => Assert.Equal(value, new Percent<Int32>(value).GetHashCode());

	[Theory]
	[InlineData(-1)]
	[InlineData(0)]
	[InlineData(1)]
	public void Minus(Int32 value) => Assert.Equal(new Percent<Int32>(-value), -new Percent<Int32>(value));

	[Fact]
	public void MultiplicativeIdentity() => Assert.Equal(Percent<Int32>.MultiplicativeIdentity, new Percent<Int32>(1));

	[Theory]
	[InlineData(0.0, 0.0, 0.0)]
	[InlineData(1.0, 1.0, 1.0)]
	public void Multiply(Double left, Double right, Double expected) => Assert.Equal(new Percent<Double>(expected), new Percent<Double>(left) * new Percent<Double>(right));

	[Theory]
	[InlineData(50.0, 100.0, 50.0)]
	[InlineData(50.0, 75.0, 37.5)]
	[InlineData(50.0, 50.0, 25.0)]
	public void Of(Double percentage, Double value, Double expected) => Assert.Equal(expected, new Percent<Double>(percentage).Of(value));

	[Theory]
	[InlineData(-1)]
	[InlineData(0)]
	[InlineData(1)]
	public void Plus(Int32 value) => Assert.Equal(new Percent<Int32>(value), +new Percent<Int32>(value));

	[Theory]
	[InlineData(0.0, 0.0, 0.0)]
	[InlineData(1.0, 1.0, 0.0)]
	public void Subtract_Percent(Double left, Double right, Double expected) => Assert.Equal(new Percent<Double>(expected), new Percent<Double>(left) - new Percent<Double>(right));

	[Theory]
	[InlineData(0.0, 50.0, 0.0)]
	[InlineData(10.0, 50.0, 5.0)]
	public void Subtract_Value(Double value, Double percentage, Double expected) => Assert.Equal(expected, value - new Percent<Double>(percentage));

	[Theory]
	[InlineData(0)]
	[InlineData(50)]
	[InlineData(100)]
	[SuppressMessage("Usage", "xUnit1024:Test methods cannot have overloads", Justification = "The test isn't overloaded, this just tests a method all classes have.")]
	public void ToString(Int32 value) => Assert.Equal($"{value}%", new Percent<Int32>(value).ToString());
}
