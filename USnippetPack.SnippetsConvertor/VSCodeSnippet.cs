using Newtonsoft.Json;

namespace USnippetPack.SnippetsConvertor;

public class VSCodeSnippet
{
    [JsonProperty("scope")]
    public string Scope { get; set; } = "csharp";

    [JsonProperty("prefix")]
    public string? Prefix { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("body")]
    public string[]? Body { get; set; }

    public VSCodeSnippet(string? prefix, string? description, string[]? body)
    {
        Prefix = prefix;
        Description = description;
        Body = body;
    }

    public VSCodeSnippet()
    {
    }
}