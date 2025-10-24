using System.Text;

namespace Neomaster.Extra.UnitTests;

public class StringExtensionsUnitTests
{
  [Theory]
  [InlineData("", true)]
  [InlineData(" ", true)]
  [InlineData("\t", true)]
  [InlineData("a", false)]
  [InlineData(null, false)]
  public void IsWhiteSpace(string input, bool expected)
  {
    var actual = input.IsWhiteSpace();
    Assert.Equal(expected, actual);
  }

  [Theory]
  [InlineData(null, true)]
  [InlineData("", true)]
  [InlineData(" ", false)]
  [InlineData("a", false)]
  public void IsNullOrEmpty(string input, bool expected)
  {
    var actual = input.IsNullOrEmpty();
    Assert.Equal(expected, actual);
  }

  [Theory]
  [InlineData(null, true)]
  [InlineData("", true)]
  [InlineData(" ", true)]
  [InlineData("\t", true)]
  [InlineData("a", false)]
  public void IsNullOrWhiteSpace(string input, bool expected)
  {
    var actual = input.IsNullOrWhiteSpace();
    Assert.Equal(expected, actual);
  }

  [Theory]
  [InlineData("", "")]
  [InlineData("a", "a")]
  [InlineData("ab", "a")]
  public void Truncate_ShouldTruncateToSingleChar(string input, string expected)
  {
    var actual = input.Truncate(1);
    Assert.Equal(expected, actual);
  }

  [Theory]
  [InlineData("")]
  [InlineData("lorem")]
  public void ToBytes(string src)
  {
    var expected = src.ToCharArray().Select(c => (byte)c);

    var actual = src.ToBytes();

    Assert.Equal(expected, actual);
  }

  [Theory]
  [InlineData("")]
  [InlineData("lorem")]
  [InlineData("эюя")]
  public void ToUtf8Bytes(string src)
  {
    var expected = Encoding.UTF8.GetBytes(src);

    var actual = src.ToUtf8Bytes();

    Assert.Equal(expected, actual);
  }

  [Fact]
  public void DeserializeAsJson()
  {
    var expected = new TestUser { Email = "1", Color = ConsoleColor.Green };
    var json = expected.ToJson();

    var actual = json.DeserializeAsJson<TestUser>();

    Assert.Equal(expected, actual);
  }
}
