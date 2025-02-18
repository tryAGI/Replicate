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
    /// 
    /// </summary>
    /// <param name="response"></param>
    /// <param name="api"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static async Task<PredictionResponse?> WaitUntilSuccessfulAsync(
        this SchemasPredictionResponse response,
        ReplicateApi api,
        CancellationToken cancellationToken = default)
    {
        response = response ?? throw new ArgumentNullException(nameof(response));
        api = api ?? throw new ArgumentNullException(nameof(api));
        var id = response.Id ?? throw new ArgumentException(nameof(response.Id));
        
        PredictionResponse? predictionResponse = null;
        while (!response.IsCompleted())
        {
            await Task.Delay(1000, cancellationToken).ConfigureAwait(false);
            
            predictionResponse = await api.PredictionsGetAsync(id, cancellationToken).ConfigureAwait(false);
        }
        
        return predictionResponse;
    }
}