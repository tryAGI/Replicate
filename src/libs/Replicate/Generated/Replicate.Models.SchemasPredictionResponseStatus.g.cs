
#nullable enable

namespace Replicate
{
    /// <summary>
    /// The prediction status. `canceled` means the prediction was canceled (either by the user or because it reached its deadline while running). `aborted` means the prediction was terminated before it started running (for example, when a deadline is reached before the prediction starts).
    /// </summary>
    public enum SchemasPredictionResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Aborted,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Starting,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
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
                SchemasPredictionResponseStatus.Aborted => "aborted",
                SchemasPredictionResponseStatus.Canceled => "canceled",
                SchemasPredictionResponseStatus.Failed => "failed",
                SchemasPredictionResponseStatus.Processing => "processing",
                SchemasPredictionResponseStatus.Starting => "starting",
                SchemasPredictionResponseStatus.Succeeded => "succeeded",
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
                "aborted" => SchemasPredictionResponseStatus.Aborted,
                "canceled" => SchemasPredictionResponseStatus.Canceled,
                "failed" => SchemasPredictionResponseStatus.Failed,
                "processing" => SchemasPredictionResponseStatus.Processing,
                "starting" => SchemasPredictionResponseStatus.Starting,
                "succeeded" => SchemasPredictionResponseStatus.Succeeded,
                _ => null,
            };
        }
    }
}