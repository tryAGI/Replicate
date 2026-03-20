# Files Create With Content Type



This example assumes `using Replicate;` is in scope and `apiKey` contains your Replicate API key.

```csharp
using var api = GetAuthorizedClient();

var content = System.Text.Encoding.UTF8.GetBytes("{\"key\": \"value\"}");
var fileName = "test-file.json";

var created = await api.FilesCreateAsync(
    content: content,
    contentname: fileName,
    filename: fileName,
    type: "application/json");

try
{
}
finally
{
    await api.FilesDeleteAsync(created.Id);
}
```