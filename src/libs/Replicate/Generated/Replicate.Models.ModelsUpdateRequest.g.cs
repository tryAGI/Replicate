
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelsUpdateRequest
    {
        /// <summary>
        /// A description of the model.<br/>
        /// Example: Detect hot dogs in images
        /// </summary>
        /// <example>Detect hot dogs in images</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A URL for the model's source code on GitHub.<br/>
        /// Example: https://github.com/alice/hot-dog-detector
        /// </summary>
        /// <example>https://github.com/alice/hot-dog-detector</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_url")]
        public string? GithubUrl { get; set; }

        /// <summary>
        /// A URL for the model's license.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_url")]
        public string? LicenseUrl { get; set; }

        /// <summary>
        /// A URL for the model's paper.<br/>
        /// Example: https://arxiv.org/abs/2504.17639
        /// </summary>
        /// <example>https://arxiv.org/abs/2504.17639</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("paper_url")]
        public string? PaperUrl { get; set; }

        /// <summary>
        /// The README content of the model.<br/>
        /// Example: # Updated README<br/>
        /// New content here
        /// </summary>
        /// <example>
        /// # Updated README<br/>
        /// New content here
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// A URL for the model's weights.<br/>
        /// Example: https://huggingface.co/alice/hot-dog-detector
        /// </summary>
        /// <example>https://huggingface.co/alice/hot-dog-detector</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights_url")]
        public string? WeightsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsUpdateRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// A description of the model.<br/>
        /// Example: Detect hot dogs in images
        /// </param>
        /// <param name="githubUrl">
        /// A URL for the model's source code on GitHub.<br/>
        /// Example: https://github.com/alice/hot-dog-detector
        /// </param>
        /// <param name="licenseUrl">
        /// A URL for the model's license.
        /// </param>
        /// <param name="paperUrl">
        /// A URL for the model's paper.<br/>
        /// Example: https://arxiv.org/abs/2504.17639
        /// </param>
        /// <param name="readme">
        /// The README content of the model.<br/>
        /// Example: # Updated README<br/>
        /// New content here
        /// </param>
        /// <param name="weightsUrl">
        /// A URL for the model's weights.<br/>
        /// Example: https://huggingface.co/alice/hot-dog-detector
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsUpdateRequest(
            string? description,
            string? githubUrl,
            string? licenseUrl,
            string? paperUrl,
            string? readme,
            string? weightsUrl)
        {
            this.Description = description;
            this.GithubUrl = githubUrl;
            this.LicenseUrl = licenseUrl;
            this.PaperUrl = paperUrl;
            this.Readme = readme;
            this.WeightsUrl = weightsUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsUpdateRequest" /> class.
        /// </summary>
        public ModelsUpdateRequest()
        {
        }
    }
}