
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsListResponseResultCurrentRelease
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::Replicate.DeploymentsListResponseResultCurrentReleaseConfiguration? Configuration { get; set; }

        /// <summary>
        /// The time the release was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::Replicate.DeploymentsListResponseResultCurrentReleaseCreatedBy? CreatedBy { get; set; }

        /// <summary>
        /// The model identifier string in the format of `{model_owner}/{model_name}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The release number. This is an auto-incrementing integer that starts at 1, and is set automatically when a deployment is created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int Number { get; set; }

        /// <summary>
        /// The ID of the model version used in the release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}