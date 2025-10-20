using System.Text;

namespace Neomaster.Extra.UnitTests;

public class EnumerableExtensionsUnitTests
{
  [Theory]
  [InlineData("")]
  [InlineData("lorem")]
  public void ConcatAsChars(string expected)
  {
    var bytes = expected.ToCharArray().Select(c => (byte)c);

    var actual = bytes.ConcatAsChars();

    Assert.Equal(expected, actual);
  }

  [Theory]
  [InlineData("")]
  [InlineData("lorem")]
  [InlineData("эюя")]
  public void ConcatAsUtf8Chars(string expected)
  {
    var bytes = Encoding.UTF8.GetBytes(expected);

    var actual = bytes.ConcatAsUtf8Chars();

    Assert.Equal(expected, actual);
  }
}
