namespace System;

public partial class NumbersomeExtensionsTests {
	[Theory]
	[InlineData(0.0, 1.0)]
	[InlineData(0.5, 0.47890469450625262)]
	[InlineData(1.0, -0.17520119364380138)]
	public void Cvsh(Double value, Double expected) => Assert.Equal(expected, value.Cvsh());
}
