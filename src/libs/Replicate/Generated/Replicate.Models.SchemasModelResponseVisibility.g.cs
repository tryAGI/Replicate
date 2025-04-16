
#nullable enable

namespace Replicate
{
    /// <summary>
    /// Whether the model is public or private
    /// </summary>
    public enum SchemasModelResponseVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemasModelResponseVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemasModelResponseVisibility value)
        {
            return value switch
            {
                SchemasModelResponseVisibility.Public => "public",
                SchemasModelResponseVisibility.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemasModelResponseVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => SchemasModelResponseVisibility.Public,
                "private" => SchemasModelResponseVisibility.Private,
                _ => null,
            };
        }
    }
}