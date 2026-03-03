
#nullable enable

namespace Replicate
{
    /// <summary>
    /// Metadata provided by user when the file was created<br/>
    /// Example: {"customer_reference_id":123}
    /// </summary>
    public sealed partial class SchemasFileResponseMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}