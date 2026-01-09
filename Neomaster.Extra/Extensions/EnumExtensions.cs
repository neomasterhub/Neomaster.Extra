using System.Collections.Concurrent;
using System.ComponentModel;
using System.Reflection;

namespace Neomaster.Extra;

public static class EnumExtensions
{
  public static readonly ConcurrentDictionary<Type, Dictionary<Enum, string>> EnumDescriptionCache = [];

  /// <summary>
  /// Returns <see cref="DescriptionAttribute">[Description]</see> value or string view and cache result.
  /// </summary>
  /// <param name="e">Enum element.</param>
  /// <returns><see cref="DescriptionAttribute">[Description]</see> value or string view.</returns>
  public static string GetDescription(this Enum e)
  {
    var type = e.GetType();

    var map = EnumDescriptionCache.GetOrAdd(type, t =>
    {
      var dict = new Dictionary<Enum, string>();
      foreach (var key in Enum.GetValues(t))
      {
        dict[(Enum)key] = t.GetField(key.ToString())?
          .GetCustomAttribute<DescriptionAttribute>()?.Description
          ?? key.ToString();
      }

      return dict;
    });

    var desc = map[e];

    return desc;
  }
}
