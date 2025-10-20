using System.Text;

namespace Neomaster.Extra;

public static class EnumerableExtensions
{
  public static string ConcatAsChars(this IEnumerable<byte> bytes)
  {
    return string.Concat(bytes.Select(b => (char)b));
  }

  public static string ConcatAsUtf8Chars(this IEnumerable<byte> bytes)
  {
    return Encoding.UTF8.GetString(bytes.ToArray());
  }
}
