using System.Text;

namespace Neomaster.Extra.UnitTests;

public class IEnumerableExtensionsUnitTests
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

  [Fact]
  public void ConcatToString()
  {
    var src = new char[] { '1', '2' };

    var actual = src.ConcatToString();

    Assert.Equal("12", actual);
  }

  [Fact]
  public void JoinToString_ShouldJoin_CharSeparator()
  {
    var src = new char[] { '1', '2' };

    var actual = src.JoinToString('.');

    Assert.Equal("1.2", actual);
  }

  [Fact]
  public void JoinToString_ShouldJoin_StringSeparator()
  {
    var src = new char[] { '1', '2' };

    var actual = src.JoinToString("..");

    Assert.Equal("1..2", actual);
  }

  [Theory]
  [InlineData(0)]
  [InlineData(-1)]
  public void SplitBySize_ShouldThrow_InvalidSize(int size)
  {
    Assert.Throws<ArgumentOutOfRangeException>(() => new byte[1].SplitBySize(size).ToArray());
  }

  [Fact]
  public void SplitBySize_ShouldSplit_ValidSize()
  {
    byte[][] src =
      [
        [],
        [1],
        [1, 2],
        [1, 2, 3],
      ];
    IEnumerable<List<byte>>[] expected =
      [
        [],
        [[1]],
        [[1, 2]],
        [[1, 2], [3]],
      ];

    var actual = src.Select(x => x.SplitBySize(2));

    Assert.True(actual.Any());
    Assert.All(actual, (a, i) => Assert.Equal(expected[i], a));
  }
}
