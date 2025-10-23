Enum.GetDescription():string
```csharp
enum MyEnum
{
  [Description("e 1")]
  E1,
  E2,
}

MyEnum.E1.GetDescription() // "e 1"
MyEnum.E2.GetDescription() // "E2"
```

IEnumerable&lt;TItem&gt;.IsNullOrEmpty&lt;TItem&gt;():bool
```csharp
(null as byte[]).IsNullOrEmpty() // true
[].IsNullOrEmpty() // true
[1].IsNullOrEmpty() // false
```

IEnumerable&lt;byte&gt;.ConcatAsChars():string
```csharp
[].ConcatAsChars() // ""
[65].ConcatAsChars() // "A"
```

IEnumerable&lt;byte&gt;.ConcatAsUtf8Chars():string
```csharp
[].ConcatAsUtf8Chars() // ""
[208, 175].ConcatAsUtf8Chars() // "Я"
```

IEnumerable&lt;TItem&gt;.ConcatToString&lt;TItem&gt;():string
```csharp
[].ConcatToString() // ""
['1'].ConcatToString() // "1"
['1', '2'].ConcatToString() // "12"
```

IEnumerable&lt;TItem&gt;.JoinToString&lt;TItem&gt;(char separator):string
```csharp
[].JoinToString('.') // ""
['1'].JoinToString('.') // "1"
['1', '2'].JoinToString('.') // "1.2"
```

IEnumerable&lt;TItem&gt;.JoinToString&lt;TItem&gt;(string separator):string
```csharp
[].JoinToString("..") // ""
['1'].JoinToString("..") // "1"
['1', '2'].JoinToString("..") // "1..2"
```

IEnumerable&lt;TItem&gt;.SplitBySize&lt;TItem&gt;():IEnumerable&lt;List&lt;TItem&gt;&gt;
```csharp
[].SplitBySize(-1) // ArgumentOutOfRangeException
[].SplitBySize(0) // ArgumentOutOfRangeException
[].SplitBySize(2) // []
[1].SplitBySize(2) // [[1]]
[1, 2].SplitBySize(2) // [[1, 2]]
[1, 2, 3].SplitBySize(2) // [[1, 2], [3]]
```

string.Truncate(int length):string
```csharp
"".Truncate(1) // ""
"a".Truncate(1) // "a"
"ab".Truncate(1) // "a"
```

string.ToBytes():string
```csharp
"".ToBytes() // []
"A".ToBytes() // [65]
```

string.ToUtf8Bytes():string
```csharp
"".ToUtf8Bytes() // []
"Я".ToUtf8Bytes() // [208, 175]
```
