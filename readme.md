# 🧩EXTRA

## Extensions
<details>
<summary>
Enum.<b>GetDescription()</b> : string
</summary>

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
</details>

<details>
<summary>
IEnumerable&lt;byte&gt;.<b>ConcatAsChars()</b> : string
</summary>

```csharp
[].ConcatAsChars() // ""
[65].ConcatAsChars() // "A"
```
</details>

<details>
<summary>
IEnumerable&lt;byte&gt;.<b>ConcatAsUtf8Chars()</b> : string
</summary>

```csharp
[].ConcatAsUtf8Chars() // ""
[208, 175].ConcatAsUtf8Chars() // "Я"
```
</details>

<details>
<summary>
IEnumerable&lt;TItem&gt;.<b>ConcatToString&lt;TItem&gt;()</b> : string
</summary>

```csharp
[].ConcatToString() // ""
['1'].ConcatToString() // "1"
['1', '2'].ConcatToString() // "12"
```
</details>

<details>
<summary>
IEnumerable&lt;TItem&gt;.<b>IsNullOrEmpty&lt;TItem&gt;()</b> : bool
</summary>

```csharp
(null as byte[]).IsNullOrEmpty() // true
[].IsNullOrEmpty() // true
[1].IsNullOrEmpty() // false
```
</details>

<details>
<summary>
IEnumerable&lt;TItem&gt;.<b>JoinToString&lt;TItem&gt;(char separator)</b> : string
</summary>

```csharp
[].JoinToString('.') // ""
['1'].JoinToString('.') // "1"
['1', '2'].JoinToString('.') // "1.2"
```
</details>

<details>
<summary>
IEnumerable&lt;TItem&gt;.<b>JoinToString&lt;TItem&gt;(string separator)</b> : string
</summary>

```csharp
[].JoinToString("..") // ""
['1'].JoinToString("..") // "1"
['1', '2'].JoinToString("..") // "1..2"
```
</details>

<details>
<summary>
IEnumerable&lt;TItem&gt;.<b>SplitBySize&lt;TItem&gt;()</b> : IEnumerable&lt;List&lt;TItem&gt;&gt;
</summary>

```csharp
[].SplitBySize(-1) // ArgumentOutOfRangeException
[].SplitBySize(0) // ArgumentOutOfRangeException
[].SplitBySize(2) // []
[1].SplitBySize(2) // [[1]]
[1, 2].SplitBySize(2) // [[1, 2]]
[1, 2, 3].SplitBySize(2) // [[1, 2], [3]]
```
</details>

<details>
<summary>
string.<b>DeserializeAsJson&lt;TObj&gt;(JsonSerializerOptions options = null)</b> : string
</summary>

```csharp
"""
{
  "email": "1",
  "color": "green"
}
"""
.DeserializeAsJson<TestUser>() // new TestUser { Email = "1", Color = ConsoleColor.Green }
```
</details>

<details>
<summary>
string.<b>FromBase64()</b> : string
</summary>

```csharp
"MQ==".FromBase64() // "1"
```
</details>

<details>
<summary>
string.<b>FromUrlSafeBase64()</b> : string
</summary>

```csharp
"w7_Dv9GL8J-Yig".FromUrlSafeBase64() // "ÿÿы😊"
```
</details>

<details>
<summary>
string.<b>IsBase64()</b> : bool
</summary>

```csharp
"1".IsBase64() // false
"MQ==".IsBase64() // true
```
</details>

<details>
<summary>
string.<b>IsNullOrEmpty()</b> : bool
</summary>

```csharp
(null as string).IsNullOrEmpty() // true
"".IsNullOrEmpty() // true
" ".IsNullOrEmpty() // false
"a".IsNullOrEmpty() // false
```
</details>

<details>
<summary>
string.<b>IsNullOrWhiteSpace()</b> : bool
</summary>

```csharp
(null as string).IsNullOrWhiteSpace() // true
"".IsNullOrWhiteSpace() // true
" ".IsNullOrWhiteSpace() // true
"\t".IsNullOrWhiteSpace() // true
"a".IsNullOrWhiteSpace() // false
```
</details>

<details>
<summary>
string.<b>IsWhiteSpace()</b> : bool
</summary>

```csharp
"".IsWhiteSpace() // true
" ".IsWhiteSpace() // true
"\t".IsWhiteSpace() // true
"a".IsWhiteSpace() // false
(null as string).IsWhiteSpace() // false
```
</details>

<details>
<summary>
string.<b>RemoveByRegex()</b> : string
</summary>

```csharp
"x1y".RemoveByRegex(@"\d") // "xy"
```
</details>

<details>
<summary>
string.<b>ReplaceByRegex()</b> : string
</summary>

```csharp
"x1y".ReplaceByRegex(@"\d", "2") // "x2y"
```
</details>

<details>
<summary>
string.<b>ReverseBytes()</b> : string
</summary>

```csharp
"Вася".ReverseBytes() // "ясаВ"
"🏠🌧❤️".ReverseBytes() // "️❤\udf27🏠\ud83c"
```
</details>

<details>
<summary>
string.<b>ReverseGraphemes()</b> : string
</summary>

```csharp
"Вася".ReverseBytes() // "ясаВ"
"🏠🌧❤️".ReverseBytes() // "️❤️🌧🏠"
```
</details>

<details>
<summary>
string.<b>ToBase64()</b> : string
</summary>

```csharp
"1".ToBase64() // "MQ=="
```
</details>

<details>
<summary>
string.<b>ToBytes()</b> : string
</summary>

```csharp
"".ToBytes() // []
"A".ToBytes() // [65]
```
</details>

<details>
<summary>
string.<b>ToUrlSafeBase64()</b> : string
</summary>

```csharp
"ÿÿы😊".ToBase64() // "w7/Dv9GL8J+Yig=="
"ÿÿы😊".ToUrlSafeBase64() // "w7_Dv9GL8J-Yig"
```
</details>

<details>
<summary>
string.<b>ToUtf8Bytes()</b> : string
</summary>

```csharp
"".ToUtf8Bytes() // []
"Я".ToUtf8Bytes() // [208, 175]
```
</details>

<details>
<summary>
string.<b>Truncate(int length)</b> : string
</summary>

```csharp
"".Truncate(1) // ""
"a".Truncate(1) // "a"
"ab".Truncate(1) // "a"
```
</details>

<details>
<summary>
TObj.<b>ToJson&lt;TObj&gt;(JsonSerializerOptions options = null)</b> : string
</summary>

```csharp
new { A = ConsoleColor.Red }.ToJson() // {"a":"red"}
```
</details>

<details>
<summary>
TObj.<b>ToJsonPretty&lt;TObj&gt;()</b> : string
</summary>

```csharp
new { A = ConsoleColor.Red }.ToJsonPretty()
// {
//   "a":"red"
// }
```
</details>
