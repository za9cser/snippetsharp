// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json.Linq;
using System.Xml.Linq;

Console.WriteLine("Start Convertion");

var path = "../USnippetPack.VS2022/uSnippetPack.CSharp";
var fileNames = Directory.GetFiles(path);
var vscodeSnippetObject = new JObject();
foreach (var file in fileNames)
{
    var vsSnippetString = File.ReadAllText(file);
    var vsSnippet = XDocument.Load(vsSnippetString);

    var title = vsSnippet.Descendants("Title").FirstOrDefault()?.Value;
    var shortcut = vsSnippet.Descendants("Shortcut").FirstOrDefault()?.Value;
    var description = vsSnippet.Descendants("Description").FirstOrDefault()?.Value.Trim();
    var code = vsSnippet.DescendantNodes().OfType<XCData>().FirstOrDefault()?.Value;

    Console.WriteLine(title);
    Console.WriteLine(description);
    Console.WriteLine(shortcut);
    Console.WriteLine(code);
    Console.WriteLine("==============================\n\n");
}