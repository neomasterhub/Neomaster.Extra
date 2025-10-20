# 🧩EXTRA

## Extensions

<details>
<summary>
Enum.<b>GetDescription()</b> : string
</summary>

```csharp
enum Test
{
  [Description("e 1")]
  E1,
  E2,
}

Test.E1.GetDescription() // "e 1"
Test.E2.GetDescription() // "E2"
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
