# uSnippetPack
Simple c# and js snippets pack that provides checks for strings and collections. This pack inspired by [Snippetica](https://github.com/JosefPihrt/Snippetica). I do recommend use uSnippetPack with Snippetica

uSnippetPack is available for [vs code](https://marketplace.visualstudio.com/items?itemName=za9cser.usnippetpackvscode) and [Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=za9cser.usnippetpack2022)

# Available snippets

## C#

### String check snippets

| Shortcut | Generated Code                                   |
| -------- | ------------------------------------------------ |
| ifsnw    | `if (string.IsNullOrWhiteSpace(str))`            |
| ifsnwb   | `if (string.IsNullOrWhiteSpace(str)) {  }`       |
| ifxsnw   | `if (!string.IsNullOrWhiteSpace(str))`           |
| ifxsnwb  | `if (!string.IsNullOrWhiteSpace(str)) {  }`      |
| csnw     | `string.IsNullOrWhiteSpace(str) ? true : false`  |
| cxsnw    | `!string.IsNullOrWhiteSpace(str) ? true : false` |


### Collection check snippets using Linq methods
| Shortcut | Generated Code                                     |
| -------- | -------------------------------------------------- |
| ifany    | `if (collection.Any())`                            |
| ifanyc   | `if (collection.Any(i => <condition>))`            |
| ifanyb   | `if (collection.Any()) {}`                         |
| ifanycb  | `if (collection.Any(i => <condition>)) { }`        |
| ifxany   | `if (!collection.Any())`                           |
| ifxanyc  | `if (!collection.Any(i => <condition>))`           |
| ifxanyb  | `if (!collection.Any()) {}`                        |
| ifxanycb | `if (!collection.Any(i => <condition>)) { }`       |
| ifall    | `if (collection.All(i => <condition>))`            |
| ifallb   | `if (collection.All(i => <condition>)) { }`        |
| ifxall   | `if (!collection.All(i => <condition>))`           |
| ifxallb  | `if (!collection.All(i => <condition>)) { }`       |
| cany     | `collection.Any() ? true : false`                  |
| canyc    | `collection.Any(i => <condition>) ? true : false`  |
| cxany    | `!collection.Any() ? true : false`                 |
| cxanyc   | `!collection.Any(i => <condition>) ? true : false` |
| call     | `collection.All(i => <condition>) ? true : false`  |
| cxall    | `!collection.All(i => <condition>) ? true : false` |

### Collection check snippets by Length and Count properties with null check

| Shortcut | Generated Code                                   |
| -------- | ------------------------------------------------ |
| ifcgz    | `if (collection?.Count > 0)`                     |
| ifcgzb   | `if (collection?.Count > 0) { }`                 |
| ifcez    | `if (collection?.Count is null or 0)`            |
| ifcezb   | `if (collection?.Count is null or 0) { }`        |
| iflgz    | `if (collection?.Length > 0)`                    |
| iflgzb   | `if (collection?.Length > 0) { }`                |
| iflez    | `if (collection?.Length is null or 0)`           |
| iflezb   | `if (collection?.Length is null or 0) { }`       |
| ccgz     | `collection?.Count > 0 ? true : false`           |
| ccez     | `collection?.Count is null or 0 ? true : false`  |
| clgz     | `collection?.Length > 0 ? true : false`          |
| clez     | `collection?.Length is null or 0 ? true : false` |

## Javascript
There are snippets for bootstrap classes `justify-content`, `align-items`, `align-self`  
| Shortcut | Generated Code            |
| -------- | ------------------------- |
| jcs      | `justify-content-start`   |
| jcc      | `justify-content-center`  |
| jce      | `justify-content-end`     |
| jcb      | `justify-content-between` |
| jca      | `justify-content-around`  |
| ais      | `align-items-start`       |
| aic      | `align-items-center`      |
| aie      | `align-items-end`         |
| aisch    | `align-items-stretch`     |
| ass      | `align-self-start`        |
| asc      | `align-self-center`       |
| ase      | `align-self-end`          |
| assch    | `align-self-stretch`      |
