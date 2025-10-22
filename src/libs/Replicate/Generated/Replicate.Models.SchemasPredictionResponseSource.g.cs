
#nullable enable

namespace Replicate
{
    /// <summary>
    /// Indicates how the prediction was created
    /// </summary>
    public enum SchemasPredictionResponseSource
    {
        /// <summary>
        /// 
        /// </summary>
        Web,
        /// <summary>
        /// 
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemasPredictionResponseSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemasPredictionResponseSource value)
        {
            return value switch
            {
                SchemasPredictionResponseSource.Web => "web",
                SchemasPredictionResponseSource.Api => "api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemasPredictionResponseSource? ToEnum(string value)
        {
            return value switch
            {
                "web" => SchemasPredictionResponseSource.Web,
                "api" => SchemasPredictionResponseSource.Api,
                _ => null,
            };
        }
    }
}