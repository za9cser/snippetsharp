# uSnippetPack
Simple snippets pack that provides checks for strings and collections. This pack inspired by [Snippetica](https://github.com/JosefPihrt/Snippetica). I do recommend use uSnippetPack with Snippetica

# Available snippets

|Shotcut| Generated Code|
|--------|------------------|
|ifsnw| `if (string.IsNullOrWhiteSpace(str))`|
|ifsnwb| `if (string.IsNullOrWhiteSpace(str)) {  }`|
|ifsnnw| `if (!string.IsNullOrWhiteSpace(str))`|
|ifsnnwb| `if (!string.IsNullOrWhiteSpace(str)) {  }`|
|ifcgz| `if (collection?.Count > 0)`|
|ifcgzb| `if (collection?.Count > 0) { }`|
|ifcez| `if (collection?.Count is null or 0)`|
|ifcezb| `if (collection?.Count is null or 0) { }`|
|iflgz| `if (collection?.Length> 0)`|
|iflgzb| `if (collection?.Length > 0) { }`|
|iflez| `if (collection?.Length is null or 0)`|
|iflezb| `if (collection?.Length is null or 0) { }`|
|csnw| `string.IsNullOrWhiteSpace(str) ? true : false`|
|csnnw| `!string.IsNullOrWhiteSpace(str) ? true : false`|
|ccgz| `collection?.Count > 0 ? true : false`|
|ccez| `collection?.Count is null or 0 ? true : false`|
|clgz| `collection?.Length > 0 ? true : false`|
|clez| `collection?.Length is null or 0 ? true : false`|
