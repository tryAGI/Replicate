using System.Diagnostics.CodeAnalysis;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text
        .Replace("\"openapi\":\"3.1.0\"", "\"openapi\":\"3.0.1\"")
    ;

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);

openApiDocument.Components.Schemas["prediction_response"] = FromJson(
    /* language=json */
    """
    {
      "completed_at": "2024-08-24T11:52:04.150854Z",
      "created_at": "2024-08-24T11:51:46.577000Z",
      "data_removed": false,
      "error": null,
      "id": "0ppyrp3aj5rge0chggxb4szz48",
      "input": {
        "seed": 321972,
        "steps": 25,
        "prompt": "a female, slavian, young adult, fit body, wavy acid orange hair, wearing open swimsuit, sea in the background.",
        "guidance": 3.5,
        "interval": 3,
        "aspect_ratio": "16:9",
        "safety_tolerance": 5
      },
      "logs": "Using seed: 321972\nRunning prediction... \nGenerating image...",
      "metrics": {
        "image_count": 1,
        "predict_time": 17.565933287,
        "total_time": 17.573854
      },
      "output": "https://replicate.delivery/czjl/UVvZ7pAzOk7zLlZhKB2nUx9veCCVSDk4VlfwJ7KxaDmkt3VTA/output.webp",
      "started_at": "2024-08-24T11:51:46.584921Z",
      "status": "succeeded",
      "urls": {
        "get": "https://api.replicate.com/v1/predictions/0ppyrp3aj5rge0chggxb4szz48",
        "cancel": "https://api.replicate.com/v1/predictions/0ppyrp3aj5rge0chggxb4szz48/cancel"
      },
      "version": "d848511ad960c3a099e2a5b04f783ebf8e8a44c625b8fa7d8f03b72ebee1c954"
    }
    """);
openApiDocument.Paths["/models/{model_owner}/{model_name}/predictions"]
    .Operations[OperationType.Post].Responses["200"] = new OpenApiResponse
{
    Description = "Successful",
    Content = new Dictionary<string, OpenApiMediaType>
    {
        ["application/json"] = new()
        {
            Schema = new OpenApiSchema
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.Schema,
                    Id = "prediction_response",
                },
            },
        },
    },
};
openApiDocument.Paths["/predictions/{prediction_id}"]
    .Operations[OperationType.Get].Responses["200"] = new OpenApiResponse
{
    Description = "Successful",
    Content = new Dictionary<string, OpenApiMediaType>
    {
        ["application/json"] = new()
        {
            Schema = new OpenApiSchema
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.Schema,
                    Id = "prediction_response",
                },
            },
        },
    },
};

text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(text, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }

    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, text);

static OpenApiSchema FromJson([StringSyntax(StringSyntaxAttribute.Json)] string json)
{
    var schema = new OpenApiSchema();

    var element = System.Text.Json.JsonDocument.Parse(json).RootElement;
    schema.Type = element.ValueKind switch
    {
        System.Text.Json.JsonValueKind.Array => "array",
        System.Text.Json.JsonValueKind.False => "boolean",
        System.Text.Json.JsonValueKind.True => "boolean",
        System.Text.Json.JsonValueKind.Number => "number",
        System.Text.Json.JsonValueKind.String => "string",
        System.Text.Json.JsonValueKind.Object => "object",
        System.Text.Json.JsonValueKind.Null => "null",
        _ => throw new NotSupportedException(),
    };
    schema.Format = element.ValueKind switch
    {
        System.Text.Json.JsonValueKind.Number => element.TryGetInt64(out var _) ? "int64" : "number",
        System.Text.Json.JsonValueKind.String => "string",
        _ => null,
    };
    schema.Properties = new Dictionary<string, OpenApiSchema>();
    if (element.ValueKind == System.Text.Json.JsonValueKind.Object)
    {
        foreach (var property in element.EnumerateObject())
        {
            schema.Properties[property.Name] = FromJson(property.Value.GetRawText());
        }
    }
    
    return schema;
}