#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// Cancel a prediction
        /// </summary>
        /// <param name="predictionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PredictionsCancelAsync(
            string predictionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}