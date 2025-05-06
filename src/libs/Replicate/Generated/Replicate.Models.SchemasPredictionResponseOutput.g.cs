
#nullable enable

namespace Replicate
{
    /// <summary>
    /// The prediction output, which can be any JSON-serializable value, depending on the model
    /// </summary>
    public sealed partial class SchemasPredictionResponseOutput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}