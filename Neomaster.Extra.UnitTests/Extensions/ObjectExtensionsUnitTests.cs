namespace Neomaster.Extra.UnitTests;

public class ObjectExtensionsUnitTests
{
  [Fact]
  public void ToJson()
  {
    var src = new { A = 1 };
    const string expected = "{\"a\":1}";

    var actual = src.ToJson();

    Assert.Equal(expected, actual);
  }

  [Fact]
  public void ToJsonPretty()
  {
    var src = new
    {
      A = 1,
      B = '2',
      C = "3",
      D = ConsoleColor.Red,
    };
    const string expected =
      """
      {
        "a": 1,
        "b": "2",
        "c": "3",
        "d": "red"
      }
      """;

    var actual = src.ToJsonPretty();

    Assert.Equal(expected, actual);
  }
}
