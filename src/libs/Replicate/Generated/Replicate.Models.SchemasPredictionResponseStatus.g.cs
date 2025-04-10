
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public enum SchemasPredictionResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Starting,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemasPredictionResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemasPredictionResponseStatus value)
        {
            return value switch
            {
                SchemasPredictionResponseStatus.Starting => "starting",
                SchemasPredictionResponseStatus.Processing => "processing",
                SchemasPredictionResponseStatus.Succeeded => "succeeded",
                SchemasPredictionResponseStatus.Failed => "failed",
                SchemasPredictionResponseStatus.Canceled => "canceled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemasPredictionResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "starting" => SchemasPredictionResponseStatus.Starting,
                "processing" => SchemasPredictionResponseStatus.Processing,
                "succeeded" => SchemasPredictionResponseStatus.Succeeded,
                "failed" => SchemasPredictionResponseStatus.Failed,
                "canceled" => SchemasPredictionResponseStatus.Canceled,
                _ => null,
            };
        }
    }
}