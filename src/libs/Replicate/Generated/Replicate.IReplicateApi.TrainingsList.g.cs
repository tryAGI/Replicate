#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// List trainings<br/>
        /// Get a paginated list of all trainings created by the user or organization associated with the provided API token.<br/>
        /// This will include trainings created from the API and the website. It will return 100 records per page.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/trainings<br/>
        /// ```<br/>
        /// The response will be a paginated JSON array of training objects, sorted with the most recent training first:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "next": null,<br/>
        ///   "previous": null,<br/>
        ///   "results": [<br/>
        ///     {<br/>
        ///       "completed_at": "2023-09-08T16:41:19.826523Z",<br/>
        ///       "created_at": "2023-09-08T16:32:57.018467Z",<br/>
        ///       "error": null,<br/>
        ///       "id": "zz4ibbonubfz7carwiefibzgga",<br/>
        ///       "input": {<br/>
        ///         "input_images": "https://example.com/my-input-images.zip"<br/>
        ///       },<br/>
        ///       "metrics": {<br/>
        ///         "predict_time": 502.713876<br/>
        ///       },<br/>
        ///       "output": {<br/>
        ///         "version": "...",<br/>
        ///         "weights": "..."<br/>
        ///       },<br/>
        ///       "started_at": "2023-09-08T16:32:57.112647Z",<br/>
        ///       "source": "api",<br/>
        ///       "status": "succeeded",<br/>
        ///       "urls": {<br/>
        ///         "web": "https://replicate.com/p/zz4ibbonubfz7carwiefibzgga",<br/>
        ///         "get": "https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga",<br/>
        ///         "cancel": "https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel"<br/>
        ///       },<br/>
        ///       "model": "stability-ai/sdxl",<br/>
        ///       "version": "da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf",<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// `id` will be the unique ID of the training.<br/>
        /// `source` will indicate how the training was created. Possible values are `web` or `api`.<br/>
        /// `status` will be the status of the training. Refer to [get a single training](#trainings.get) for possible values.<br/>
        /// `urls` will be a convenience object that can be used to construct new API requests for the given training.<br/>
        /// `version` will be the unique ID of model version used to create the training.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Replicate.TrainingsListResponse> TrainingsListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}