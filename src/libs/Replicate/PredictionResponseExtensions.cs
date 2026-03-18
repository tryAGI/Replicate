namespace Replicate;

/// <summary>
/// 
/// </summary>
public static class PredictionResponseExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="response"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static bool IsCompleted(this SchemasPredictionResponse response)
    {
        response = response ?? throw new ArgumentNullException(nameof(response));
        
        return response.Status is 
            SchemasPredictionResponseStatus.Succeeded or
            SchemasPredictionResponseStatus.Canceled or
            SchemasPredictionResponseStatus.Failed;
    }
    
    /// <summary>
    /// Polls until the prediction reaches a terminal state (succeeded, canceled, or failed).
    /// </summary>
    /// <param name="response"></param>
    /// <param name="api"></param>
    /// <param name="pollingInterval">
    /// The interval between status checks. Defaults to 1 second.
    /// </param>
    /// <param name="onProgress">
    /// Optional callback invoked after each status check with the current prediction status.
    /// </param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static async Task<SchemasPredictionResponse> WaitUntilSuccessfulAsync(
        this SchemasPredictionResponse response,
        ReplicateClient api,
        TimeSpan? pollingInterval = null,
        Action<SchemasPredictionResponse>? onProgress = null,
        CancellationToken cancellationToken = default)
    {
        response = response ?? throw new ArgumentNullException(nameof(response));
        api = api ?? throw new ArgumentNullException(nameof(api));
        var id = response.Id ?? throw new ArgumentException(nameof(response.Id));
        var delay = pollingInterval ?? TimeSpan.FromSeconds(1);

        while (!response.IsCompleted())
        {
            await Task.Delay(delay, cancellationToken).ConfigureAwait(false);

            response = await api.PredictionsGetAsync(id, cancellationToken).ConfigureAwait(false);

            onProgress?.Invoke(response);
        }

        return response;
    }
}