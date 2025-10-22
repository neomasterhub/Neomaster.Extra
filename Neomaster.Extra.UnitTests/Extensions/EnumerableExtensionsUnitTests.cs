using System.Text;

namespace Neomaster.Extra.UnitTests;

public class EnumerableExtensionsUnitTests
{
  [Fact]
  public void IsNullOrEmpty_ShouldCheckNull()
  {
    byte[] src = null;

    var actual = src.IsNullOrEmpty();

    Assert.True(actual);
  }

  [Fact]
  public void IsNullOrEmpty_ShouldCheckEmpty()
  {
    byte[] src = [];

    var actual = src.IsNullOrEmpty();

    Assert.True(actual);
  }

  [Fact]
  public void IsNullOrEmpty_ShouldCheckNotEmpty()
  {
    byte[] src = [1];

    var actual = src.IsNullOrEmpty();

    Assert.False(actual);
  }

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
