
#nullable enable

namespace Replicate
{
    public sealed partial class ReplicateApi
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _authorization = new global::Replicate.EndPointAuthorization
            {
                Name = "Bearer",
                Value = apiKey,
            };
        }
    }
}