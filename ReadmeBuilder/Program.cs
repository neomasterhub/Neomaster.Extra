using System.Text;

const string codeBra = "```csharp";
const string codeCket = "```";
const string boldBra = "<b>";
const string boldCket = "</b>";
const string solDir = @"..\..\..\..";
var readmeTemplatePath = Path.Combine(solDir, "readme.template.md");
var readmeTemplateText = File.ReadAllText(readmeTemplatePath);
var readmePath = Path.Combine(solDir, "readme.md");
var demosExtensionsPath = Path.Combine(solDir, "demos.extensions.md");
var demosExtensionsSB = new StringBuilder();
var readmeExtensionsSB = new StringBuilder();

var demosExtensions = File
  .ReadAllText(demosExtensionsPath)
  .Split(codeCket + Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
  .Select(x =>
  {
    var pair = x.Split(codeBra, StringSplitOptions.RemoveEmptyEntries);

    return new
    {
      Header = pair[0].Trim(),
      Code = pair[1].Trim(),
    };
  });

var groupedDemosExtensions = demosExtensions
  .Select(x =>
  {
    var headerParts = x.Header.Split(':', StringSplitOptions.TrimEntries);
    var typeMethod = headerParts[0].Split('.', 2);
    var type = typeMethod[0];

    if (type == "TObj")
    {
      type = "object";
    }

    return new
    {
      Type = type,
      ReturnType = headerParts[1],
      Method = typeMethod[1],
      x.Code,
    };
  })
  .OrderBy(x => x.Type)
  .GroupBy(x => x.Type, (k, v) => new
  {
    Type = k,
    Demos = v.OrderBy(x => x.Method),
  });

foreach (var x in demosExtensions.OrderBy(x => x.Header))
{
  demosExtensionsSB
    .AppendLine()
    .AppendLine(x.Header)
    .AppendLine(codeBra)
    .AppendLine(x.Code)
    .AppendLine(codeCket);
}

foreach (var group in groupedDemosExtensions)
{
  readmeExtensionsSB.AppendLine($"\n### {group.Type}");

  foreach (var x in group.Demos)
  {
    readmeExtensionsSB
      .AppendLine()
      .AppendLine("<details>")
      .Append("<summary><code>")
      .Append($"{x.ReturnType} {boldBra}{x.Method}".Replace("(", $"{boldCket}("))
      .AppendLine("</code></summary>")
      .AppendLine()
      .AppendLine(codeBra)
      .AppendLine(x.Code)
      .AppendLine(codeCket)
      .AppendLine("</details>");
  }
}

var readmeText = readmeTemplateText
  .Replace("{extensions}", readmeExtensionsSB.ToString().Trim());

File.WriteAllText(demosExtensionsPath, demosExtensionsSB.ToString());
File.WriteAllText(readmePath, readmeText);
