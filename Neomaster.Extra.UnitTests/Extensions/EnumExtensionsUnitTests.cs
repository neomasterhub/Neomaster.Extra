using System.ComponentModel;
using Xunit.Extensions.Ordering;

namespace Neomaster.Extra;

public class EnumExtensionsUnitTests
{
  public enum TestEnum
  {
    [Description("Test 1")]
    Test1 = 1,
    Test2 = 2,
  }

  [Fact]
  [Order(-1)]
  public void GetDescription_ShouldCacheResult()
  {
    var enumType = typeof(TestEnum);
    var enumElements = Enum.GetValues(enumType).Cast<TestEnum>().ToArray();

    Assert.Empty(EnumExtensions.EnumDescriptionCache);

    TestEnum.Test1.GetDescription();
    var enumCache = EnumExtensions.EnumDescriptionCache[enumType];

    Assert.Single(EnumExtensions.EnumDescriptionCache);
    Assert.NotEmpty(enumCache);
    Assert.All(enumCache, (a, i) => Assert.Equal(enumElements[i], a.Key));
  }

  [Theory]
  [InlineData(TestEnum.Test1, "Test 1")]
  [InlineData(TestEnum.Test2, "Test2")]
  public void GetDescription_ShouldReturnDescriptionOrStringView(TestEnum e, string expected)
  {
    var actual = e.GetDescription();

    Assert.Equal(expected, actual);
  }
}
