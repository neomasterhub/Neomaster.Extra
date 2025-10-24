using System.Security.Cryptography;
using System.Text;

namespace Neomaster.Extra.UnitTests;

public class StringExtensionsUnitTests
{
  private const string _urlUnsafeBase64Src = "ÿÿы😊";

  public StringExtensionsUnitTests()
  {
    var urlUnsafeBase64 = _urlUnsafeBase64Src.ToBase64();
    Assert.All(
      ExtraConsts.UrlUnsafeChars,
      uc => Assert.Contains(uc, urlUnsafeBase64));
  }

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

  [Fact]
  public void IsBase64_ShouldCheckBase64()
  {
    var bytes = new byte[100];
    RandomNumberGenerator.Fill(bytes);
    var base64 = Convert.ToBase64String(bytes);

    var actual = base64.IsBase64();

    Assert.True(actual);
  }

  [Theory]
  [InlineData(null)]
  [InlineData("")]
  [InlineData(" ")]
  [InlineData("x")]
  public void IsBase64_ShouldCheckNotBase64(string input)
  {
    var actual = input.IsBase64();

    Assert.False(actual);
  }

  [Fact]
  public void ToBase64()
  {
    var bytes = new byte[100];
    RandomNumberGenerator.Fill(bytes);
    var input = bytes.ConcatAsUtf8Chars();

    var actual = input.ToBase64();

    Assert.True(actual.IsBase64());
  }

  [Fact]
  public void FromBase64()
  {
    var bytes = new byte[100];
    RandomNumberGenerator.Fill(bytes);
    var expected = bytes.ConcatAsUtf8Chars();
    var base64 = expected.ToBase64();

    var actual = base64.FromBase64();

    Assert.Equal(expected, actual);
  }

  [Fact]
  public void ToUrlSafeBase64()
  {
    var actual = _urlUnsafeBase64Src.ToUrlSafeBase64();

    Assert.All(
      ExtraConsts.UrlUnsafeChars,
      uc => Assert.DoesNotContain(uc, actual));
  }

  [Fact]
  public void FromUrlSafeBase64()
  {
    var urlSafeBase64 = _urlUnsafeBase64Src.ToUrlSafeBase64();

    var actual = urlSafeBase64.FromUrlSafeBase64();

    Assert.Equal(_urlUnsafeBase64Src, actual);
  }
}
