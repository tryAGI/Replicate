
#nullable enable

namespace Replicate
{
    /// <summary>
    /// The account type of the creator. Can be a user or an organization.
    /// </summary>
    public enum SchemasDeploymentResponseCurrentReleaseCreatedByType
    {
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemasDeploymentResponseCurrentReleaseCreatedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemasDeploymentResponseCurrentReleaseCreatedByType value)
        {
            return value switch
            {
                SchemasDeploymentResponseCurrentReleaseCreatedByType.Organization => "organization",
                SchemasDeploymentResponseCurrentReleaseCreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemasDeploymentResponseCurrentReleaseCreatedByType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => SchemasDeploymentResponseCurrentReleaseCreatedByType.Organization,
                "user" => SchemasDeploymentResponseCurrentReleaseCreatedByType.User,
                _ => null,
            };
        }
    }
}