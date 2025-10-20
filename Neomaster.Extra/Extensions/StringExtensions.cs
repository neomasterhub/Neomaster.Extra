#pragma warning disable SA1611, SA1615
namespace Neomaster.Extra;

public static class StringExtensions
{
  /// <summary>
  /// Truncates text to given length.
  /// </summary>
  public static string Truncate(this string text, int length)
  {
    return text.Length > length ? text[..length] : text;
  }
}
