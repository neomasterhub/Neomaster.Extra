# 🧩EXTRA

## Extensions

<details>
<summary>
<b>
Enum.GetDescription()
</b>
- Returns [Description] value or string view and cache result.
</summary>

```csharp
enum TestEnum
{
  [Description("Test 1")]
  Test1,
  Test2,
}

Test1.GetDescription() // "Test 1"
Test2.GetDescription() // "Test2"
```

</details>

<details>
<summary>
<b>
string.Truncate(int length)
</b>
- Truncates text to given length.
</summary>

```csharp
"".Truncate(1) // ""
"a".Truncate(1) // "a"
"ab".Truncate(1) // "a"
```

</details>
