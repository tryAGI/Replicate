#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// Get a model<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/models/replicate/hello-world<br/>
        /// ```<br/>
        /// The response will be a model object in the following format:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "url": "https://replicate.com/replicate/hello-world",<br/>
        ///   "owner": "replicate",<br/>
        ///   "name": "hello-world",<br/>
        ///   "description": "A tiny model that says hello",<br/>
        ///   "visibility": "public",<br/>
        ///   "github_url": "https://github.com/replicate/cog-examples",<br/>
        ///   "paper_url": null,<br/>
        ///   "license_url": null,<br/>
        ///   "run_count": 5681081,<br/>
        ///   "cover_image_url": "...",<br/>
        ///   "default_example": {...},<br/>
        ///   "latest_version": {...},<br/>
        /// }<br/>
        /// ```<br/>
        /// The model object includes the [input and output schema](https://replicate.com/docs/reference/openapi#model-schemas) for the latest version of the model.<br/>
        /// Here's an example showing how to fetch the model with cURL and display its input schema with [jq](https://stedolan.github.io/jq/):<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///     -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///     https://api.replicate.com/v1/models/replicate/hello-world \<br/>
        ///     | jq ".latest_version.openapi_schema.components.schemas.Input"<br/>
        /// ```<br/>
        /// This will return the following JSON object:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "title": "Input",<br/>
        ///   "required": [<br/>
        ///     "text"<br/>
        ///   ],<br/>
        ///   "properties": {<br/>
        ///     "text": {<br/>
        ///       "type": "string",<br/>
        ///       "title": "Text",<br/>
        ///       "x-order": 0,<br/>
        ///       "description": "Text to prefix with 'hello '"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ``` <br/>
        /// The `cover_image_url` string is an HTTPS URL for an image file. This can be:<br/>
        /// - An image uploaded by the model author.<br/>
        /// - The output file of the example prediction, if the model author has not set a cover image.<br/>
        /// - The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file.<br/>
        /// - A generic fallback image.<br/>
        /// The `default_example` object is a [prediction](#predictions.get) created with this model.<br/>
        /// The `latest_version` object is the model's most recently pushed [version](#models.versions.get).
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.SchemasModelResponse> ModelsGetAsync(
            string modelOwner,
            string modelName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}