# Account



This example assumes `using Replicate;` is in scope and `apiKey` contains your Replicate API key.

```csharp
using var api = GetAuthorizedClient();

var response = await api.AccountGetAsync();
```