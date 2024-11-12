#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// List available hardware for models<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/hardware<br/>
        /// ```<br/>
        /// The response will be a JSON array of hardware objects:<br/>
        /// ```json<br/>
        /// [<br/>
        ///     {"name": "CPU", "sku": "cpu"},<br/>
        ///     {"name": "Nvidia T4 GPU", "sku": "gpu-t4"},<br/>
        ///     {"name": "Nvidia A40 GPU", "sku": "gpu-a40-small"},<br/>
        ///     {"name": "Nvidia A40 (Large) GPU", "sku": "gpu-a40-large"},<br/>
        /// ]<br/>
        /// ```
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Replicate.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Replicate.HardwareListResponseItem>> HardwareListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}