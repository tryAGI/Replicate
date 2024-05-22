using System.Text.Json.Serialization;

namespace Replicate;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(OpenApiGeneratorTrimmableSupport))]
internal sealed partial class SourceGenerationContext : JsonSerializerContext;