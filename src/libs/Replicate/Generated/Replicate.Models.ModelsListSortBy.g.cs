
#nullable enable

namespace Replicate
{
    /// <summary>
    /// Default Value: latest_version_created_at
    /// </summary>
    public enum ModelsListSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        ModelCreatedAt,
        /// <summary>
        /// 
        /// </summary>
        LatestVersionCreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsListSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsListSortBy value)
        {
            return value switch
            {
                ModelsListSortBy.ModelCreatedAt => "model_created_at",
                ModelsListSortBy.LatestVersionCreatedAt => "latest_version_created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsListSortBy? ToEnum(string value)
        {
            return value switch
            {
                "model_created_at" => ModelsListSortBy.ModelCreatedAt,
                "latest_version_created_at" => ModelsListSortBy.LatestVersionCreatedAt,
                _ => null,
            };
        }
    }
}