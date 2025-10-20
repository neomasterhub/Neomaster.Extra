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
