#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// Cancel a training
        /// </summary>
        /// <param name="trainingId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.SchemasTrainingResponse> TrainingsCancelAsync(
            string trainingId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}