using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;

var path = args[0];
var jsonOrYaml = await File.ReadAllTextAsync(path);

var format = jsonOrYaml.TrimStart().StartsWith("{", StringComparison.Ordinal) ? "json" : "yaml";
var readerSettings = new OpenApiReaderSettings();
var (openApiDocument, diagnostics) = OpenApiDocument.Parse(jsonOrYaml, format, readerSettings);

if (diagnostics is null)
{
    Console.WriteLine("Failed to parse the OpenAPI document.");
    Environment.Exit(1);
    return;
}

if (openApiDocument is null)
{
    PrintErrors(diagnostics);
    Environment.Exit(1);
    return;
}

SetJsonResponse("/models/{model_owner}/{model_name}/predictions", HttpMethod.Post, "200", "Successful", "schemas_prediction_response");
SetJsonResponse("/predictions/{prediction_id}", HttpMethod.Get, "200", "Successful", "schemas_prediction_response");

SetJsonResponse("/models", HttpMethod.Post, "201", "Success", "schemas_model_response");

SetJsonResponse("/deployments", HttpMethod.Post, "200", "Success", "schemas_deployment_response");

SetJsonResponse("/deployments/{deployment_owner}/{deployment_name}", HttpMethod.Patch, "200", "Success", "schemas_deployment_response");

SetJsonResponse("/models/{model_owner}/{model_name}/versions/{version_id}/trainings", HttpMethod.Post, "201", "Success", "schemas_training_response");

jsonOrYaml = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_0, CancellationToken.None);
(_, diagnostics) = OpenApiDocument.Parse(jsonOrYaml, "yaml", readerSettings);

if (diagnostics is not null && diagnostics.Errors.Count > 0)
{
    PrintErrors(diagnostics);
    // Return Exit code 1
    Environment.Exit(1);
    return;
}

await File.WriteAllTextAsync(path, jsonOrYaml);

void SetJsonResponse(string route, HttpMethod method, string statusCode, string description, string schemaId)
{
    if (openApiDocument.Paths is null ||
        !openApiDocument.Paths.TryGetValue(route, out var pathItem) ||
        pathItem.Operations is null ||
        !pathItem.Operations.TryGetValue(method, out var operation) ||
        operation.Responses is null)
    {
        throw new InvalidOperationException($"Expected '{method.Method} {route}' in the OpenAPI document.");
    }

    operation.Responses[statusCode] = CreateJsonResponse(openApiDocument, description, schemaId);
}

static OpenApiResponse CreateJsonResponse(OpenApiDocument openApiDocument, string description, string schemaId)
{
    return new OpenApiResponse
    {
        Description = description,
        Content = new Dictionary<string, IOpenApiMediaType>
        {
            ["application/json"] = new OpenApiMediaType
            {
                Schema = new OpenApiSchemaReference(schemaId, openApiDocument, externalResource: null),
            },
        },
    };
}

static void PrintErrors(OpenApiDiagnostic diagnostics)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
}
