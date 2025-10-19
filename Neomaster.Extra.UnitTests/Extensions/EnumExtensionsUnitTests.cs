using System.ComponentModel;

namespace Neomaster.Extra;

public class EnumExtensionsUnitTests
{
  public enum TestEnum
  {
    [Description("Test 1")]
    Test1 = 1,
    Test2 = 2,
  }

  [Theory]
  [InlineData(TestEnum.Test1, "Test 1")]
  [InlineData(TestEnum.Test2, "Test2")]
  public void ShouldReturnDescriptionOrStringView(TestEnum e, string expected)
  {
    var actual = e.GetDescription();

    Assert.Equal(expected, actual);
  }
}
