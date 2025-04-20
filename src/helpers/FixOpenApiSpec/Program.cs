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
                    Id = "schemas_prediction_response",
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