namespace Neomaster.Extra;

public static class StringExtensions
{
  public static string Truncate(this string text, int length)
  {
    return text.Length > length ? text[..length] : text;
  }
}
