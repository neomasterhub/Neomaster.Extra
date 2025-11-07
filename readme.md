<div align="center">

  [![License](https://img.shields.io/badge/🧾License-MIT-green?style=flat)](https://opensource.org/licenses/MIT)
  [![Telegram Channel](https://img.shields.io/badge/Telegram-Neomaster-2CA5E0?style=flat&logo=telegram)](https://t.me/neomaster_dev)
  [![.NET Version](https://img.shields.io/badge/.NET_Standard-2.1-blueviolet?style=flat&logo=dotnet)](#)  
  [![NuGet](https://img.shields.io/nuget/v/Neomaster.Extra.svg?label=NuGet&logo=nuget&logoColor=white&labelColor=gray&color=blue)](https://www.nuget.org/packages/Neomaster.Extra)

</div>

# ⚙️EXTRA
## Extensions
### Enum

<details>
<summary><code>string <b>GetDescription</b>()</code></summary>

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

### IEnumerable&lt;byte&gt;

<details>
<summary><code>string <b>ConcatAsChars</b>()</code></summary>

```csharp
[].ConcatAsChars() // ""
[65].ConcatAsChars() // "A"
```
</details>

<details>
<summary><code>string <b>ConcatAsUtf8Chars</b>()</code></summary>

```csharp
[].ConcatAsUtf8Chars() // ""
[208, 175].ConcatAsUtf8Chars() // "Я"
```
</details>

### IEnumerable&lt;TItem&gt;

<details>
<summary><code>string <b>ConcatToString&lt;TItem&gt;</b>()</code></summary>

```csharp
[].ConcatToString() // ""
['1'].ConcatToString() // "1"
['1', '2'].ConcatToString() // "12"
```
</details>

<details>
<summary><code>bool <b>IsNullOrEmpty&lt;TItem&gt;</b>()</code></summary>

```csharp
(null as byte[]).IsNullOrEmpty() // true
[].IsNullOrEmpty() // true
[1].IsNullOrEmpty() // false
```
</details>

<details>
<summary><code>string <b>JoinToString&lt;TItem&gt;</b>(char separator)</code></summary>

```csharp
[].JoinToString('.') // ""
['1'].JoinToString('.') // "1"
['1', '2'].JoinToString('.') // "1.2"
```
</details>

<details>
<summary><code>string <b>JoinToString&lt;TItem&gt;</b>(string separator)</code></summary>

```csharp
[].JoinToString("..") // ""
['1'].JoinToString("..") // "1"
['1', '2'].JoinToString("..") // "1..2"
```
</details>

<details>
<summary><code>IEnumerable&lt;List&lt;TItem&gt;&gt; <b>SplitBySize&lt;TItem&gt;</b>()</code></summary>

```csharp
[].SplitBySize(-1) // ArgumentOutOfRangeException
[].SplitBySize(0) // ArgumentOutOfRangeException
[].SplitBySize(2) // []
[1].SplitBySize(2) // [[1]]
[1, 2].SplitBySize(2) // [[1, 2]]
[1, 2, 3].SplitBySize(2) // [[1, 2], [3]]
```
</details>

### object

<details>
<summary><code>string <b>ToJson&lt;TObj&gt;</b>(JsonSerializerOptions options = null)</code></summary>

```csharp
new { A = ConsoleColor.Red }.ToJson() // {"a":"red"}
```
</details>

<details>
<summary><code>string <b>ToJsonPretty&lt;TObj&gt;</b>()</code></summary>

```csharp
new { A = ConsoleColor.Red }.ToJsonPretty()
// {
//   "a":"red"
// }
```
</details>

### string

<details>
<summary><code>string <b>DeserializeAsJson&lt;TObj&gt;</b>(JsonSerializerOptions options = null)</code></summary>

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
<summary><code>string <b>FromBase64</b>()</code></summary>

```csharp
"MQ==".FromBase64() // "1"
```
</details>

<details>
<summary><code>string <b>FromUrlSafeBase64</b>()</code></summary>

```csharp
"w7_Dv9GL8J-Yig".FromUrlSafeBase64() // "ÿÿы😊"
```
</details>

<details>
<summary><code>bool <b>IsBase64</b>()</code></summary>

```csharp
"1".IsBase64() // false
"MQ==".IsBase64() // true
```
</details>

<details>
<summary><code>bool <b>IsNullOrEmpty</b>()</code></summary>

```csharp
(null as string).IsNullOrEmpty() // true
"".IsNullOrEmpty() // true
" ".IsNullOrEmpty() // false
"a".IsNullOrEmpty() // false
```
</details>

<details>
<summary><code>bool <b>IsNullOrWhiteSpace</b>()</code></summary>

```csharp
(null as string).IsNullOrWhiteSpace() // true
"".IsNullOrWhiteSpace() // true
" ".IsNullOrWhiteSpace() // true
"\t".IsNullOrWhiteSpace() // true
"a".IsNullOrWhiteSpace() // false
```
</details>

<details>
<summary><code>bool <b>IsWhiteSpace</b>()</code></summary>

```csharp
"".IsWhiteSpace() // true
" ".IsWhiteSpace() // true
"\t".IsWhiteSpace() // true
"a".IsWhiteSpace() // false
(null as string).IsWhiteSpace() // false
```
</details>

<details>
<summary><code>string <b>RemoveByRegex</b>()</code></summary>

```csharp
"x1y".RemoveByRegex(@"\d") // "xy"
```
</details>

<details>
<summary><code>string <b>ReplaceByRegex</b>()</code></summary>

```csharp
"x1y".ReplaceByRegex(@"\d", "2") // "x2y"
```
</details>

<details>
<summary><code>string <b>ReverseBytes</b>()</code></summary>

```csharp
"Вася".ReverseBytes() // "ясаВ"
"🏠🌧❤️".ReverseBytes() // "️❤\udf27🏠\ud83c"
```
</details>

<details>
<summary><code>string <b>ReverseGraphemes</b>()</code></summary>

```csharp
"Вася".ReverseBytes() // "ясаВ"
"🏠🌧❤️".ReverseBytes() // "️❤️🌧🏠"
```
</details>

<details>
<summary><code>string <b>ToBase64</b>()</code></summary>

```csharp
"1".ToBase64() // "MQ=="
```
</details>

<details>
<summary><code>string <b>ToBytes</b>()</code></summary>

```csharp
"".ToBytes() // []
"A".ToBytes() // [65]
```
</details>

<details>
<summary><code>string <b>ToUrlSafeBase64</b>()</code></summary>

```csharp
"ÿÿы😊".ToBase64() // "w7/Dv9GL8J+Yig=="
"ÿÿы😊".ToUrlSafeBase64() // "w7_Dv9GL8J-Yig"
```
</details>

<details>
<summary><code>string <b>ToUtf8Bytes</b>()</code></summary>

```csharp
"".ToUtf8Bytes() // []
"Я".ToUtf8Bytes() // [208, 175]
```
</details>

<details>
<summary><code>string <b>Truncate</b>(int length)</code></summary>

```csharp
"".Truncate(1) // ""
"a".Truncate(1) // "a"
"ab".Truncate(1) // "a"
```
</details>
