
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemasModelResponse
    {
        /// <summary>
        /// A URL for the model's cover image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// The model's default example prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_example")]
        public object? DefaultExample { get; set; }

        /// <summary>
        /// A description of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A URL for the model's source code on GitHub
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_url")]
        public string? GithubUrl { get; set; }

        /// <summary>
        /// The model's latest version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version")]
        public object? LatestVersion { get; set; }

        /// <summary>
        /// A URL for the model's license
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_url")]
        public string? LicenseUrl { get; set; }

        /// <summary>
        /// The name of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The name of the user or organization that owns the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// A URL for the model's paper
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paper_url")]
        public string? PaperUrl { get; set; }

        /// <summary>
        /// The number of times the model has been run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_count")]
        public int? RunCount { get; set; }

        /// <summary>
        /// The URL of the model on Replicate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Whether the model is public or private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Replicate.JsonConverters.SchemasModelResponseVisibilityJsonConverter))]
        public global::Replicate.SchemasModelResponseVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasModelResponse" /> class.
        /// </summary>
        /// <param name="coverImageUrl">
        /// A URL for the model's cover image
        /// </param>
        /// <param name="defaultExample">
        /// The model's default example prediction
        /// </param>
        /// <param name="description">
        /// A description of the model
        /// </param>
        /// <param name="githubUrl">
        /// A URL for the model's source code on GitHub
        /// </param>
        /// <param name="latestVersion">
        /// The model's latest version
        /// </param>
        /// <param name="licenseUrl">
        /// A URL for the model's license
        /// </param>
        /// <param name="name">
        /// The name of the model
        /// </param>
        /// <param name="owner">
        /// The name of the user or organization that owns the model
        /// </param>
        /// <param name="paperUrl">
        /// A URL for the model's paper
        /// </param>
        /// <param name="runCount">
        /// The number of times the model has been run
        /// </param>
        /// <param name="url">
        /// The URL of the model on Replicate
        /// </param>
        /// <param name="visibility">
        /// Whether the model is public or private
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasModelResponse(
            string? coverImageUrl,
            object? defaultExample,
            string? description,
            string? githubUrl,
            object? latestVersion,
            string? licenseUrl,
            string? name,
            string? owner,
            string? paperUrl,
            int? runCount,
            string? url,
            global::Replicate.SchemasModelResponseVisibility? visibility)
        {
            this.CoverImageUrl = coverImageUrl;
            this.DefaultExample = defaultExample;
            this.Description = description;
            this.GithubUrl = githubUrl;
            this.LatestVersion = latestVersion;
            this.LicenseUrl = licenseUrl;
            this.Name = name;
            this.Owner = owner;
            this.PaperUrl = paperUrl;
            this.RunCount = runCount;
            this.Url = url;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasModelResponse" /> class.
        /// </summary>
        public SchemasModelResponse()
        {
        }
    }
}