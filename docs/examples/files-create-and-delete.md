# Files Create And Delete



This example assumes `using Replicate;` is in scope and `apiKey` contains your Replicate API key.

```csharp
using var api = GetAuthorizedClient();

var content = System.Text.Encoding.UTF8.GetBytes("Hello, Replicate!");
var fileName = "test-file.txt";

var created = await api.FilesCreateAsync(
    content: content,
    contentname: fileName,
    filename: fileName);

try
{

    var fetched = await api.FilesGetAsync(created.Id);
}
finally
{
    await api.FilesDeleteAsync(created.Id);
}
```