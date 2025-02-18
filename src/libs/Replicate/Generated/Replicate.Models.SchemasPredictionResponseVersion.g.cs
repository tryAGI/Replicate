
#nullable enable

namespace Replicate
{
    /// <summary>
    /// The model does not support versions, used by official models.
    /// </summary>
    public enum SchemasPredictionResponseVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Hidden,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemasPredictionResponseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemasPredictionResponseVersion value)
        {
            return value switch
            {
                SchemasPredictionResponseVersion.Hidden => "hidden",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemasPredictionResponseVersion? ToEnum(string value)
        {
            return value switch
            {
                "hidden" => SchemasPredictionResponseVersion.Hidden,
                _ => null,
            };
        }
    }
}