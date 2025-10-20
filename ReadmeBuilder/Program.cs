using System.Text;

const string codeBra = "```csharp";
const string codeCket = "```";
const string boldBra = "<b>";
const string boldCket = "</b>";
const string solDir = @"..\..\..\..";
var readmeTemplatePath = Path.Combine(solDir, "readme.template.md");
var readmeTemplateText = File.ReadAllText(readmeTemplatePath);
var readmePath = Path.Combine(solDir, "readme.md");
var demosExtensionsSB = new StringBuilder();

foreach (var x in File
  .ReadAllText(Path.Combine(solDir, "demos.extensions.md"))
  .Split(codeCket + Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
  .Select(x =>
  {
    var pair = x.Split(codeBra);

    return new
    {
      Header = pair[0].Trim(),
      Code = pair[1].Trim(),
    };
  })
  .OrderBy(x => x.Header))
{
  demosExtensionsSB
    .AppendLine()
    .AppendLine("<details>")
    .AppendLine("<summary>")
    .AppendLine(x.Header
      .Trim()
      .Replace(".", $".{boldBra}")
      .Replace(":", $"{boldCket} : "))
    .AppendLine("</summary>")
    .AppendLine()
    .AppendLine(codeBra)
    .AppendLine(x.Code)
    .AppendLine(codeCket)
    .AppendLine("</details>");
}

var readmeText = readmeTemplateText
  .Replace("{extensions}", demosExtensionsSB.ToString().Trim());

File.WriteAllText(readmePath, readmeText);
