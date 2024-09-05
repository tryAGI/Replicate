# Replicate

[![Nuget package](https://img.shields.io/nuget/vpre/tryAGI.Replicate)](https://www.nuget.org/packages/tryAGI.Replicate/)
[![dotnet](https://github.com/tryAGI/Replicate/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Replicate/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Replicate)](https://github.com/tryAGI/Replicate/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Replicate OpenAPI specification](https://api.replicate.com/openapi.json) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

## Documentation
Examples and documentation can be found here: https://tryagi.github.io/Replicate/

### Usage
```csharp
using Replicate;

using var api = new ReplicateApi(apiKey);
var response = await api.ModelsPredictionsCreateAsync(
    input: new PredictionRequestInput
    {
        AdditionalProperties = new Dictionary<string, object>
        {
            ["seed"] = Random.Shared.Next(0, 1000000),
            ["steps"] = 25,
            ["prompt"] = "a female, european, young adult, fit body, wavy acid orange hair, wearing open swimsuit, sea in the background.",
            ["guidance"] = 3.5,
            ["interval"] = 3,
            ["aspect_ratio"] = "16:9",
            ["safety_tolerance"] = 5,
        },
    },
    modelOwner: "black-forest-labs",
    modelName: "flux-pro");
        
var endResponse = await response.WaitUntilSuccessfulAsync(api);

Console.WriteLine($@"Seed: {endResponse.Input?.Seed}.
Image available at:\n{endResponse.Output}");
```
![output](assets/output.webp)

## Support

Priority place for bugs: https://github.com/tryAGI/Replicate/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Replicate/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).