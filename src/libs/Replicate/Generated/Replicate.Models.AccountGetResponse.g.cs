
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountGetResponse
    {
        /// <summary>
        /// The avatar URL for the account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// The GitHub URL of the account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_url")]
        public string? GithubUrl { get; set; }

        /// <summary>
        /// The name of the account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The account type. Can be a user or an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Replicate.JsonConverters.AccountGetResponseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Replicate.AccountGetResponseType Type { get; set; }

        /// <summary>
        /// The username of the account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponse" /> class.
        /// </summary>
        /// <param name="avatarUrl">
        /// The avatar URL for the account.
        /// </param>
        /// <param name="githubUrl">
        /// The GitHub URL of the account.
        /// </param>
        /// <param name="name">
        /// The name of the account.
        /// </param>
        /// <param name="type">
        /// The account type. Can be a user or an organization.
        /// </param>
        /// <param name="username">
        /// The username of the account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountGetResponse(
            global::Replicate.AccountGetResponseType type,
            string username,
            string? avatarUrl,
            string? githubUrl,
            string? name)
        {
            this.Type = type;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.AvatarUrl = avatarUrl;
            this.GithubUrl = githubUrl;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponse" /> class.
        /// </summary>
        public AccountGetResponse()
        {
        }
    }
}