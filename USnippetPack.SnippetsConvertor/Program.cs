// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json.Linq;
using System.Xml.Linq;

Console.WriteLine("Start Convertion");

var path = "../../../../USnippetPack.VS2022/uSnippetPack.CSharp";
var fileNames = Directory.GetFiles(path);
var vscodeSnippetObject = new JObject();
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
    var dollarCount = 0;
    var literalCount = 0;
    for (int i = 0; i < parts.Length; i++)
    {
        var part = parts[i];
        while (true)
        {
            var dollarIndex = part.IndexOf('$');
            if (dollarIndex < 0) break;

            if (dollarCount % 2 == 0)
            {
                part = part.Remove(dollarIndex, 1);
                part = part.Insert(dollarIndex, $"{{{++literalCount}:");
            }
            else
            {
                part = part[..dollarIndex] + "}" + part[(dollarIndex + 1)..];
            }

            dollarCount++;
        }

        parts[i] = part;
    }

    foreach (var part in parts)
    {
        Console.WriteLine(part);
    }

    Console.WriteLine("==============================\n\n");
}

Console.ReadKey();