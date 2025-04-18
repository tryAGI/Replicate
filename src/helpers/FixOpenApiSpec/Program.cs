using System.Diagnostics.CodeAnalysis;
using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var jsonOrYaml = await File.ReadAllTextAsync(path);

if (OpenApi31Support.IsOpenApi31(jsonOrYaml))
{
    jsonOrYaml = OpenApi31Support.ConvertToOpenApi30(jsonOrYaml);
}

var openApiDocument = new OpenApiStringReader().Read(jsonOrYaml, out var diagnostics);

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
                    Id = "schemas_prediction_response",
                },
            },
        },
    },
};

openApiDocument.Paths["/models"].Operations[OperationType.Post].Responses["201"] = new OpenApiResponse
{
    Description = "Success",
    Content = new Dictionary<string, OpenApiMediaType>
    {
        ["application/json"] = new()
        {
            Schema = new OpenApiSchema
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.Schema,
                    Id = "schemas_model_response",
                },
            },
        },
    },
};

jsonOrYaml = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(jsonOrYaml, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }

    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, jsonOrYaml);

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
// Add response schema for deployments create/update
openApiDocument.Paths["/deployments"].Operations[OperationType.Post].Responses["200"] = new OpenApiResponse
{
    Description = "Success",
    Content = new Dictionary<string, OpenApiMediaType>
    {
        ["application/json"] = new()
        {
            Schema = new OpenApiSchema
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.Schema, 
                    Id = "schemas_deployment_response",
                },
            },
        },
    },
};

openApiDocument.Paths["/deployments/{deployment_owner}/{deployment_name}"].Operations[OperationType.Patch].Responses["200"] = new OpenApiResponse
{
    Description = "Success",
    Content = new Dictionary<string, OpenApiMediaType>
    {
        ["application/json"] = new()
        {
            Schema = new OpenApiSchema
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.Schema,
                    Id = "schemas_deployment_response",
                },
            },
        },
    },
};

// Add response schema for trainings create
openApiDocument.Paths["/models/{model_owner}/{model_name}/versions/{version_id}/trainings"].Operations[OperationType.Post].Responses["201"] = new OpenApiResponse
{
    Description = "Success",
    Content = new Dictionary<string, OpenApiMediaType>
    {
        ["application/json"] = new()
        {
            Schema = new OpenApiSchema
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.Schema,
                    Id = "schemas_training_response",
                },
            },
        },
    },
};
