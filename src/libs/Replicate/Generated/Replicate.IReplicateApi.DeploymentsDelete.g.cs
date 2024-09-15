#nullable enable

namespace Replicate
{
    public partial interface IReplicateApi
    {
        /// <summary>
        /// Delete a deployment<br/>
        /// Delete a deployment<br/>
        /// Deployment deletion has some restrictions:<br/>
        /// - You can only delete deployments that have been offline and unused for at least 15 minutes.<br/>
        /// Example cURL request:<br/>
        /// ```command<br/>
        /// curl -s -X DELETE \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/deployments/acme/my-app-image-generator<br/>
        /// ```<br/>
        /// The response will be an empty 204, indicating the deployment has been deleted.
        /// </summary>
        /// <param name="deploymentOwner"></param>
        /// <param name="deploymentName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeploymentsDeleteAsync(
            string deploymentOwner,
            string deploymentName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}