
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
        Api,
        /// <summary>
        /// 
        /// </summary>
        Web,
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
                SchemasPredictionResponseSource.Api => "api",
                SchemasPredictionResponseSource.Web => "web",
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
                "api" => SchemasPredictionResponseSource.Api,
                "web" => SchemasPredictionResponseSource.Web,
                _ => null,
            };
        }
    }
}