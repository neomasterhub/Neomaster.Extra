using System.ComponentModel;
using System.Reflection;

namespace Neomaster.Extra;

public static class EnumExtensions
{
  /// <summary>
  /// Returns <see cref="DescriptionAttribute">[Description]</see> value or string view.
  /// </summary>
  /// <param name="e">Enum element.</param>
  /// <returns><see cref="DescriptionAttribute">[Description]</see> value or string view.</returns>
  public static string GetDescription(this Enum e)
  {
    var d = e
      .GetType()
      .GetField(e.ToString())?
      .GetCustomAttribute<DescriptionAttribute>()?.Description
      ?? e.ToString();

    return d;
  }
}
