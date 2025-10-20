namespace Neomaster.Extra.UnitTests;

public class StringExtensionsUnitTests
{
  [Theory]
  [InlineData("", "")]
  [InlineData("a", "a")]
  [InlineData("ab", "a")]
  public void Truncate_ShouldTruncateToSingleChar(string input, string expected)
  {
    var actual = input.Truncate(1);
    Assert.Equal(expected, actual);
  }
}
