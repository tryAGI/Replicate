#nullable enable

namespace Replicate
{
    public partial interface IReplicateClient
    {
        /// <summary>
        /// Cancel a training
        /// </summary>
        /// <param name="trainingId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.SchemasTrainingResponse> TrainingsCancelAsync(
            string trainingId,
            global::Replicate.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}