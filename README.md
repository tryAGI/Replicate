# Replicate

[![Nuget package](https://img.shields.io/nuget/vpre/tryAGI.Replicate)](https://www.nuget.org/packages/tryAGI.Replicate/)
[![dotnet](https://github.com/tryAGI/Replicate/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Replicate/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Replicate)](https://github.com/tryAGI/Replicate/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

Generated C# SDK based on Replicate OpenAPI specification using NSwag.  
Includes [tokenizer](https://github.com/tryAGI/Tiktoken) and some helper methods.

### Usage
```csharp
using Replicate;

using var client = new HttpClient();
var api = new ReplicateApi(apiKey, client);
var response = await api.GenerateTextAsync(
    RecommendedModelIds.Gpt2,
    new GenerateTextRequest
    {
        Inputs = "Hello",
        Parameters = new GenerateTextRequestParameters
        {
            Max_new_tokens = 250,
            Return_full_text = false,
        },
        Options = new GenerateTextRequestOptions
        {
            Use_cache = true,
            Wait_for_model = false,
        },
    });
```

## Support

Priority place for bugs: https://github.com/tryAGI/Replicate/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Replicate/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  