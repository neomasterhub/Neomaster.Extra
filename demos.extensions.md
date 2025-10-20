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
[64].ConcatAsChars() // "A"
```

IEnumerable&lt;byte&gt;.ConcatAsUtf8Chars():string
```csharp
[208, 175].ConcatAsUtf8Chars() // "Я"
```

string.Truncate(int length):string
```csharp
"".Truncate(1) // ""
"a".Truncate(1) // "a"
"ab".Truncate(1) // "a"
```
