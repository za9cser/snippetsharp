using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using USnippetPack.SnippetsConvertor;

Console.WriteLine("Start Convertion");

var path = "../../../../USnippetPack.VS2022/uSnippetPack.CSharp";
var fileNames = Directory.GetFiles(path);
var snippets = new Dictionary<string, VSCodeSnippet>(fileNames.Length);
var regex = new Regex(@"\$\w+\$", RegexOptions.Multiline);
foreach (var file in fileNames)
{
    var vsSnippetString = File.ReadAllText(file);
    var vsSnippet = XDocument.Parse(vsSnippetString);

    var title = vsSnippet.Descendants().FirstOrDefault(x => x.Name.LocalName == "Title")?.Value;
    var shortcut = vsSnippet.Descendants().FirstOrDefault(x => x.Name.LocalName == "Shortcut")?.Value;
    var description = vsSnippet.Descendants().FirstOrDefault(x => x.Name.LocalName == "Description")?.Value.Trim();
    var code = vsSnippet.DescendantNodes().OfType<XCData>().FirstOrDefault()?.Value;

    Console.WriteLine(title);
    Console.WriteLine(description);
    Console.WriteLine(shortcut);
    Console.WriteLine(code);

    var parts = code.Split("\n");
    var literalCount = 0;
    for (int i = 0; i < parts.Length; i++)
    {
        var part = parts[i];
        var match = regex.Matches(part);

        foreach (Group group in match)
        {
            var newPart = group.Value;
            newPart = $"${{{++literalCount}:{group.Value[1..^1]}}}";
            part = part.Replace(group.Value, newPart);
        }

        parts[i] = part;
    }

    foreach (var part in parts)
    {
        Console.WriteLine(part);
    }

    Console.WriteLine("==============================\n\n");

    var snippet = new VSCodeSnippet(shortcut, description, parts);
    snippets.Add(title, snippet);
}

var outputString = JsonConvert.SerializeObject(snippets, Formatting.Indented);
Console.WriteLine(outputString);

using (var _ = File.Create("csharp.code-snippets"))
{
}

File.WriteAllText("csharp.code-snippets", outputString);

Console.ReadKey();