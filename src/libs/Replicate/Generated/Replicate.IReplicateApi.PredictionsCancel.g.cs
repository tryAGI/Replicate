#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// Cancel a prediction<br/>
        /// Cancel a prediction that is currently running.<br/>
        /// Example cURL request that creates a prediction and then cancels it:<br/>
        /// ```console<br/>
        /// # First, create a prediction<br/>
        /// PREDICTION_ID=$(curl -s -X POST \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   -H "Content-Type: application/json" \<br/>
        ///   -d '{<br/>
        ///     "input": {<br/>
        ///       "prompt": "a video that may take a while to generate"<br/>
        ///     }<br/>
        ///   }' \<br/>
        ///   https://api.replicate.com/v1/models/minimax/video-01/predictions | jq -r '.id')<br/>
        /// # Echo the prediction ID<br/>
        /// echo "Created prediction with ID: $PREDICTION_ID"<br/>
        /// # Cancel the prediction<br/>
        /// curl -s -X POST \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/predictions/$PREDICTION_ID/cancel<br/>
        /// ```
        /// </summary>
        /// <param name="predictionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.SchemasPredictionResponse> PredictionsCancelAsync(
            string predictionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}