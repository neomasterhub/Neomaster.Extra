using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Neomaster.Extra;

public static class StringExtensions
{
  public static bool IsWhiteSpace(this string text)
  {
    return text?.All(char.IsWhiteSpace) == true;
  }

  public static bool IsNullOrEmpty(this string text)
  {
    return string.IsNullOrEmpty(text);
  }

  public static bool IsNullOrWhiteSpace(this string text)
  {
    return string.IsNullOrWhiteSpace(text);
  }

  public static string Truncate(this string text, int length)
  {
    return text.Length > length ? text[..length] : text;
  }

  public static byte[] ToBytes(this string text)
  {
    return text.Select(c => (byte)c).ToArray();
  }

  public static byte[] ToUtf8Bytes(this string text)
  {
    return Encoding.UTF8.GetBytes(text);
  }

  public static TObj DeserializeAsJson<TObj>(this string json, JsonSerializerOptions options = null)
  {
    return JsonSerializer.Deserialize<TObj>(json, options ?? ExtraConsts.JsonSerializerOptionsList.Default);
  }

  public static string ToBase64(this string text)
  {
    return Convert.ToBase64String(text.ToUtf8Bytes());
  }

  public static string FromBase64(this string base64)
  {
    return Convert.FromBase64String(base64).ConcatAsUtf8Chars();
  }

  public static bool IsBase64(this string text)
  {
    return !text.IsNullOrWhiteSpace()
      && text.Length % 4 == 0
      && Convert.TryFromBase64String(text, new byte[text.Length], out var _);
  }

  public static string ToUrlSafeBase64(this string text)
  {
    return text
      .ToBase64()
      .Replace('+', '-')
      .Replace('/', '_')
      .TrimEnd('=');
  }

  public static string FromUrlSafeBase64(this string urlSafeBase64)
  {
    return urlSafeBase64
      .PadRight(urlSafeBase64.Length + (urlSafeBase64.Length % 4), '=')
      .Replace('-', '+')
      .Replace('_', '/')
      .FromBase64();
  }

  public static string ReplaceByRegex(
    this string text,
    string pattern,
    string replacement,
    RegexOptions options = RegexOptions.None)
  {
    return Regex.Replace(text, pattern, replacement, options);
  }

  public static string RemoveByRegex(
    this string text,
    string pattern,
    RegexOptions options = RegexOptions.None)
  {
    return Regex.Replace(text, pattern, string.Empty, options);
  }

  public static string ReverseBytes(this string text)
  {
    var chars = text.ToCharArray();
    Array.Reverse(chars);

    return new string(chars);
  }
}
