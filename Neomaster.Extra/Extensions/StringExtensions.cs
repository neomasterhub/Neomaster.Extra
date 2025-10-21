using System.Text;

namespace Neomaster.Extra;

public static class StringExtensions
{
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
}
