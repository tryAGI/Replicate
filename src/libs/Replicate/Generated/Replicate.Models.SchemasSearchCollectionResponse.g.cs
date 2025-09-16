
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemasSearchCollectionResponse
    {
        /// <summary>
        /// A description of the collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Array of model names in the collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

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
        /// Initializes a new instance of the <see cref="SchemasSearchCollectionResponse" /> class.
        /// </summary>
        /// <param name="description">
        /// A description of the collection
        /// </param>
        /// <param name="models">
        /// Array of model names in the collection
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
        public SchemasSearchCollectionResponse(
            string description,
            string name,
            string slug,
            global::System.Collections.Generic.IList<string>? models)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasSearchCollectionResponse" /> class.
        /// </summary>
        public SchemasSearchCollectionResponse()
        {
        }
    }
}