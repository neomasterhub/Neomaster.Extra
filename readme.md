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
