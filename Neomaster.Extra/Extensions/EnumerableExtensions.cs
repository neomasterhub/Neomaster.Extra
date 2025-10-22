using System.Text;

namespace Neomaster.Extra;

public static class EnumerableExtensions
{
  public static bool IsNullOrEmpty<TItem>(this IEnumerable<TItem> items)
  {
    return items == null || !items.Any();
  }

  public static string ConcatAsChars(this IEnumerable<byte> bytes)
  {
    return string.Concat(bytes.Select(b => (char)b));
  }

  public static string ConcatAsUtf8Chars(this IEnumerable<byte> bytes)
  {
    return Encoding.UTF8.GetString(bytes.ToArray());
  }

  public static IEnumerable<List<TItem>> SplitBySize<TItem>(this IEnumerable<TItem> items, int size)
  {
    if (size <= 0)
    {
      throw new ArgumentOutOfRangeException(nameof(size), "Size must be greater than 0");
    }

    using var enumerator = items.GetEnumerator();

    while (enumerator.MoveNext())
    {
      var chunk = new List<TItem> { enumerator.Current };

      for (var i = 1; i < size && enumerator.MoveNext(); i++)
      {
        chunk.Add(enumerator.Current);
      }

      yield return chunk;
    }
  }
}
