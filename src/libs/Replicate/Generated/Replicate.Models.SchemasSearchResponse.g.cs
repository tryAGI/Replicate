
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemasSearchResponse
    {
        /// <summary>
        /// Array of collections that match the search query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Replicate.SchemasSearchCollectionResponse> Collections { get; set; }

        /// <summary>
        /// Array of models that match the search query, each containing model data and extra metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Replicate.SchemasSearchResponseModel> Models { get; set; }

        /// <summary>
        /// Array of Replicate documentation pages that match the search query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Replicate.SchemasPageResponse> Pages { get; set; }

        /// <summary>
        /// The search term that was evaluated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasSearchResponse" /> class.
        /// </summary>
        /// <param name="collections">
        /// Array of collections that match the search query
        /// </param>
        /// <param name="models">
        /// Array of models that match the search query, each containing model data and extra metadata
        /// </param>
        /// <param name="pages">
        /// Array of Replicate documentation pages that match the search query
        /// </param>
        /// <param name="query">
        /// The search term that was evaluated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasSearchResponse(
            global::System.Collections.Generic.IList<global::Replicate.SchemasSearchCollectionResponse> collections,
            global::System.Collections.Generic.IList<global::Replicate.SchemasSearchResponseModel> models,
            global::System.Collections.Generic.IList<global::Replicate.SchemasPageResponse> pages,
            string query)
        {
            this.Collections = collections ?? throw new global::System.ArgumentNullException(nameof(collections));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasSearchResponse" /> class.
        /// </summary>
        public SchemasSearchResponse()
        {
        }
    }
}