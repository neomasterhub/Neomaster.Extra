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
string.<b>ToBytes()</b> : string
</summary>

```csharp
"".ToBytes() // []
"A".ToBytes() // [65]
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
