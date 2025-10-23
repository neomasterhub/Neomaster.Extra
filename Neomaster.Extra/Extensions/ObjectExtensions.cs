using System.Text.Json;

namespace Neomaster.Extra;

public static class ObjectExtensions
{
  public static string ToJson<TObj>(this TObj obj, JsonSerializerOptions options = null)
  {
    return JsonSerializer.Serialize(obj, options ?? ExtraConsts.JsonSerializerOptionsList.Default);
  }

  public static string ToJsonPretty<TObj>(this TObj obj)
  {
    return JsonSerializer.Serialize(obj, ExtraConsts.JsonSerializerOptionsList.DefaultPretty);
  }
}
