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
    /// <param name="progress">
    /// Optional <see cref="IProgress{T}"/> instance to report prediction status after each poll.
    /// </param>
    /// <param name="timeout">
    /// Optional timeout for the entire wait operation. Defaults to no timeout.
    /// </param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="TimeoutException"></exception>
    public static async Task<SchemasPredictionResponse> WaitUntilSuccessfulAsync(
        this SchemasPredictionResponse response,
        ReplicateClient api,
        TimeSpan? pollingInterval = null,
        IProgress<SchemasPredictionResponse>? progress = null,
        TimeSpan? timeout = null,
        CancellationToken cancellationToken = default)
    {
        response = response ?? throw new ArgumentNullException(nameof(response));
        api = api ?? throw new ArgumentNullException(nameof(api));
        var id = response.Id ?? throw new ArgumentException(nameof(response.Id));
        var delay = pollingInterval ?? TimeSpan.FromSeconds(1);

        using var cts = timeout.HasValue
            ? CancellationTokenSource.CreateLinkedTokenSource(cancellationToken)
            : null;
        cts?.CancelAfter(timeout!.Value);
        var token = cts?.Token ?? cancellationToken;

        try
        {
            while (!response.IsCompleted())
            {
                await Task.Delay(delay, token).ConfigureAwait(false);

                response = await api.PredictionsGetAsync(id, token).ConfigureAwait(false);

                progress?.Report(response);
            }
        }
        catch (OperationCanceledException) when (timeout.HasValue && !cancellationToken.IsCancellationRequested)
        {
            throw new TimeoutException($"Prediction {id} did not complete within {timeout.Value}.");
        }

        return response;
    }
}