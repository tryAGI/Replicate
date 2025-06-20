
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemasVersionPredictionRequest
    {
        /// <summary>
        /// The model's input as a JSON object. The input schema depends on what model you are running. To see the available inputs, click the "API" tab on the model you are running or [get the model version](#models.versions.get) and look at its `openapi_schema` property. For example, [stability-ai/sdxl](https://replicate.com/stability-ai/sdxl) takes `prompt` as an input.<br/>
        /// Files should be passed as HTTP URLs or data URLs.<br/>
        /// Use an HTTP URL when:<br/>
        /// - you have a large file &gt; 256kb<br/>
        /// - you want to be able to use the file multiple times<br/>
        /// - you want your prediction metadata to be associable with your input files<br/>
        /// Use a data URL when:<br/>
        /// - you have a small file &lt;= 256kb<br/>
        /// - you don't want to upload and host the file somewhere<br/>
        /// - you don't need to use the file again (Replicate will not store it)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// **This field is deprecated.**<br/>
        /// Request a URL to receive streaming output using [server-sent events (SSE)](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events).<br/>
        /// This field is no longer needed as the returned prediction will always have a `stream` entry in its `url` property if the model supports streaming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// The ID of the model version that you want to run. This can be specified in two formats:<br/>
        /// 1. Just the 64-character version ID: `9dcd6d78e7c6560c340d916fe32e9f24aabfa331e5cce95fe31f77fb03121426`<br/>
        /// 2. Full model identifier with version ID in the format `{owner}/{model}:{id}`. For example, `replicate/hello-world:9dcd6d78e7c6560c340d916fe32e9f24aabfa331e5cce95fe31f77fb03121426`<br/>
        /// Example: replicate/hello-world:9dcd6d78e7c6560c340d916fe32e9f24aabfa331e5cce95fe31f77fb03121426
        /// </summary>
        /// <example>replicate/hello-world:9dcd6d78e7c6560c340d916fe32e9f24aabfa331e5cce95fe31f77fb03121426</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// An HTTPS URL for receiving a webhook when the prediction has new output. The webhook will be a POST request where the request body is the same as the response body of the [get prediction](#predictions.get) operation. If there are network problems, we will retry the webhook a few times, so make sure it can be safely called more than once. Replicate will not follow redirects when sending webhook requests to your service, so be sure to specify a URL that will resolve without redirecting.<br/>
        /// Example: https://example.com/my-webhook-handler
        /// </summary>
        /// <example>https://example.com/my-webhook-handler</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// By default, we will send requests to your webhook URL whenever there are new outputs or the prediction has finished. You can change which events trigger webhook requests by specifying `webhook_events_filter` in the prediction request:<br/>
        /// - `start`: immediately on prediction start<br/>
        /// - `output`: each time a prediction generates an output (note that predictions can generate multiple outputs)<br/>
        /// - `logs`: each time log output is generated by a prediction<br/>
        /// - `completed`: when the prediction reaches a terminal state (succeeded/canceled/failed)<br/>
        /// For example, if you only wanted requests to be sent at the start and end of the prediction, you would provide:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "version": "5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa",<br/>
        ///   "input": {<br/>
        ///     "text": "Alice"<br/>
        ///   },<br/>
        ///   "webhook": "https://example.com/my-webhook",<br/>
        ///   "webhook_events_filter": ["start", "completed"]<br/>
        /// }<br/>
        /// ```<br/>
        /// Requests for event types `output` and `logs` will be sent at most once every 500ms. If you request `start` and `completed` webhooks, then they'll always be sent regardless of throttling.<br/>
        /// Example: [start, completed]
        /// </summary>
        /// <example>[start, completed]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_events_filter")]
        public global::System.Collections.Generic.IList<global::Replicate.SchemasVersionPredictionRequestWebhookEventsFilterItem>? WebhookEventsFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasVersionPredictionRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// The model's input as a JSON object. The input schema depends on what model you are running. To see the available inputs, click the "API" tab on the model you are running or [get the model version](#models.versions.get) and look at its `openapi_schema` property. For example, [stability-ai/sdxl](https://replicate.com/stability-ai/sdxl) takes `prompt` as an input.<br/>
        /// Files should be passed as HTTP URLs or data URLs.<br/>
        /// Use an HTTP URL when:<br/>
        /// - you have a large file &gt; 256kb<br/>
        /// - you want to be able to use the file multiple times<br/>
        /// - you want your prediction metadata to be associable with your input files<br/>
        /// Use a data URL when:<br/>
        /// - you have a small file &lt;= 256kb<br/>
        /// - you don't want to upload and host the file somewhere<br/>
        /// - you don't need to use the file again (Replicate will not store it)
        /// </param>
        /// <param name="stream">
        /// **This field is deprecated.**<br/>
        /// Request a URL to receive streaming output using [server-sent events (SSE)](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events).<br/>
        /// This field is no longer needed as the returned prediction will always have a `stream` entry in its `url` property if the model supports streaming.
        /// </param>
        /// <param name="version">
        /// The ID of the model version that you want to run. This can be specified in two formats:<br/>
        /// 1. Just the 64-character version ID: `9dcd6d78e7c6560c340d916fe32e9f24aabfa331e5cce95fe31f77fb03121426`<br/>
        /// 2. Full model identifier with version ID in the format `{owner}/{model}:{id}`. For example, `replicate/hello-world:9dcd6d78e7c6560c340d916fe32e9f24aabfa331e5cce95fe31f77fb03121426`<br/>
        /// Example: replicate/hello-world:9dcd6d78e7c6560c340d916fe32e9f24aabfa331e5cce95fe31f77fb03121426
        /// </param>
        /// <param name="webhook">
        /// An HTTPS URL for receiving a webhook when the prediction has new output. The webhook will be a POST request where the request body is the same as the response body of the [get prediction](#predictions.get) operation. If there are network problems, we will retry the webhook a few times, so make sure it can be safely called more than once. Replicate will not follow redirects when sending webhook requests to your service, so be sure to specify a URL that will resolve without redirecting.<br/>
        /// Example: https://example.com/my-webhook-handler
        /// </param>
        /// <param name="webhookEventsFilter">
        /// By default, we will send requests to your webhook URL whenever there are new outputs or the prediction has finished. You can change which events trigger webhook requests by specifying `webhook_events_filter` in the prediction request:<br/>
        /// - `start`: immediately on prediction start<br/>
        /// - `output`: each time a prediction generates an output (note that predictions can generate multiple outputs)<br/>
        /// - `logs`: each time log output is generated by a prediction<br/>
        /// - `completed`: when the prediction reaches a terminal state (succeeded/canceled/failed)<br/>
        /// For example, if you only wanted requests to be sent at the start and end of the prediction, you would provide:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "version": "5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa",<br/>
        ///   "input": {<br/>
        ///     "text": "Alice"<br/>
        ///   },<br/>
        ///   "webhook": "https://example.com/my-webhook",<br/>
        ///   "webhook_events_filter": ["start", "completed"]<br/>
        /// }<br/>
        /// ```<br/>
        /// Requests for event types `output` and `logs` will be sent at most once every 500ms. If you request `start` and `completed` webhooks, then they'll always be sent regardless of throttling.<br/>
        /// Example: [start, completed]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchemasVersionPredictionRequest(
            object input,
            string version,
            bool? stream,
            string? webhook,
            global::System.Collections.Generic.IList<global::Replicate.SchemasVersionPredictionRequestWebhookEventsFilterItem>? webhookEventsFilter)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Stream = stream;
            this.Webhook = webhook;
            this.WebhookEventsFilter = webhookEventsFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasVersionPredictionRequest" /> class.
        /// </summary>
        public SchemasVersionPredictionRequest()
        {
        }
    }
}