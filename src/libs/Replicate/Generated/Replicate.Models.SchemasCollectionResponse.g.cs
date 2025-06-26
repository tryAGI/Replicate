
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemasCollectionResponse
    {
        /// <summary>
        /// A description of the collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The models in this collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Replicate.SchemasModelResponse> Models { get; set; }

        /// <summary>
        /// The name of the collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The slug of the collection (lowercase with dashes)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasCollectionResponse" /> class.
        /// </summary>
        /// <param name="description">
        /// A description of the collection
        /// </param>
        /// <param name="models">
        /// The models in this collection
        /// </param>
        /// <param name="name">
        /// The name of the collection
        /// </param>
        /// <param name="slug">
        /// The slug of the collection (lowercase with dashes)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasCollectionResponse(
            string description,
            global::System.Collections.Generic.IList<global::Replicate.SchemasModelResponse> models,
            string name,
            string slug)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasCollectionResponse" /> class.
        /// </summary>
        public SchemasCollectionResponse()
        {
        }
    }
}