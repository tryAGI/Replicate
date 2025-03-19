#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// Get a model's README<br/>
        /// Get the README content for a model.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/models/replicate/hello-world/readme<br/>
        /// ```<br/>
        /// The response will be the README content as plain text in Markdown format:<br/>
        /// ```<br/>
        /// # Hello World Model<br/>
        /// This is an example model that...<br/>
        /// ```
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ModelsReadmeGetAsync(
            string modelOwner,
            string modelName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}