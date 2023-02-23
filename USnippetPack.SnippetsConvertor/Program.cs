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
    Console.WriteLine("==============================\n\n");
}

Console.ReadKey();