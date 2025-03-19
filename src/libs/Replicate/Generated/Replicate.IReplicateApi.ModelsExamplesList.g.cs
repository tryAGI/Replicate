#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// List examples for a model<br/>
        /// List [example predictions](https://replicate.com/docs/topics/models/publish-a-model#what-are-examples) made using the model.<br/>
        /// These are predictions that were saved by the model author as illustrative examples of the model's capabilities.<br/>
        /// If you want all the examples for a model, use this operation.<br/>
        /// If you just want the model's default example, you can use the [`models.get`](#models.get) operation instead, which includes a `default_example` object.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/models/replicate/hello-world/examples<br/>
        /// ```<br/>
        /// The response will be a pagination object containing a list of example predictions:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "next": "https://api.replicate.com/v1/models/replicate/hello-world/examples?cursor=...",<br/>
        ///   "previous": "https://api.replicate.com/v1/models/replicate/hello-world/examples?cursor=...",<br/>
        ///   "results": [...]<br/>
        /// }<br/>
        /// ```<br/>
        /// Each item in the `results` list is a [prediction object](#predictions.get).
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task ModelsExamplesListAsync(
            string modelOwner,
            string modelName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}