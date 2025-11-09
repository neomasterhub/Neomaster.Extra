
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

IEnumerable&lt;TItem&gt;.IsNullOrEmpty&lt;TItem&gt;():bool
```csharp
(null as byte[]).IsNullOrEmpty() // true
[].IsNullOrEmpty() // true
[1].IsNullOrEmpty() // false
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

string.ConvertCase(JsonNamingPolicy policy):string
```csharp
"RedBox".ConvertCase(JsonNamingPolicy.KebabCaseLower) // red-box
```

string.DeserializeAsJson&lt;TObj&gt;(JsonSerializerOptions options = null):string
```csharp
"""
{
  "email": "1",
  "color": "green"
}
"""
.DeserializeAsJson<TestUser>() // new TestUser { Email = "1", Color = ConsoleColor.Green }
```

string.FromBase64():string
```csharp
"MQ==".FromBase64() // "1"
```

string.FromUrlSafeBase64():string
```csharp
"w7_Dv9GL8J-Yig".FromUrlSafeBase64() // "ÿÿы😊"
```

string.IsBase64():bool
```csharp
"1".IsBase64() // false
"MQ==".IsBase64() // true
```

string.IsNullOrEmpty():bool
```csharp
(null as string).IsNullOrEmpty() // true
"".IsNullOrEmpty() // true
" ".IsNullOrEmpty() // false
"a".IsNullOrEmpty() // false
```

string.IsNullOrWhiteSpace():bool
```csharp
(null as string).IsNullOrWhiteSpace() // true
"".IsNullOrWhiteSpace() // true
" ".IsNullOrWhiteSpace() // true
"\t".IsNullOrWhiteSpace() // true
"a".IsNullOrWhiteSpace() // false
```

string.IsWhiteSpace():bool
```csharp
"".IsWhiteSpace() // true
" ".IsWhiteSpace() // true
"\t".IsWhiteSpace() // true
"a".IsWhiteSpace() // false
(null as string).IsWhiteSpace() // false
```

string.RemoveByRegex():string
```csharp
"x1y".RemoveByRegex(@"\d") // "xy"
```

string.ReplaceByRegex():string
```csharp
"x1y".ReplaceByRegex(@"\d", "2") // "x2y"
```

string.ReverseBytes():string
```csharp
"Вася".ReverseBytes() // "ясаВ"
"🏠🌧❤️".ReverseBytes() // "️❤\udf27🏠\ud83c"
```

string.ReverseGraphemes():string
```csharp
"Вася".ReverseBytes() // "ясаВ"
"🏠🌧❤️".ReverseBytes() // "️❤️🌧🏠"
```

string.ToBase64():string
```csharp
"1".ToBase64() // "MQ=="
```

string.ToBytes():string
```csharp
"".ToBytes() // []
"A".ToBytes() // [65]
```

string.ToUrlSafeBase64():string
```csharp
"ÿÿы😊".ToBase64() // "w7/Dv9GL8J+Yig=="
"ÿÿы😊".ToUrlSafeBase64() // "w7_Dv9GL8J-Yig"
```

string.ToUtf8Bytes():string
```csharp
"".ToUtf8Bytes() // []
"Я".ToUtf8Bytes() // [208, 175]
```

string.Truncate(int length):string
```csharp
"".Truncate(1) // ""
"a".Truncate(1) // "a"
"ab".Truncate(1) // "a"
```

TObj.ToJson&lt;TObj&gt;(JsonSerializerOptions options = null):string
```csharp
new { A = ConsoleColor.Red }.ToJson() // {"a":"red"}
```

TObj.ToJsonPretty&lt;TObj&gt;():string
```csharp
new { A = ConsoleColor.Red }.ToJsonPretty()
// {
//   "a":"red"
// }
```
