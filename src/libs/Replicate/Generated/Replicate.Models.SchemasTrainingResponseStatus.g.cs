
#nullable enable

namespace Replicate
{
    /// <summary>
    /// The current status of the training. `canceled` means the training was canceled (either by the user or because it reached its deadline while running). `aborted` means the training was terminated before it started running (for example, when a deadline is reached before the training starts).
    /// </summary>
    public enum SchemasTrainingResponseStatus
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
    public static class SchemasTrainingResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemasTrainingResponseStatus value)
        {
            return value switch
            {
                SchemasTrainingResponseStatus.Aborted => "aborted",
                SchemasTrainingResponseStatus.Canceled => "canceled",
                SchemasTrainingResponseStatus.Failed => "failed",
                SchemasTrainingResponseStatus.Processing => "processing",
                SchemasTrainingResponseStatus.Starting => "starting",
                SchemasTrainingResponseStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemasTrainingResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "aborted" => SchemasTrainingResponseStatus.Aborted,
                "canceled" => SchemasTrainingResponseStatus.Canceled,
                "failed" => SchemasTrainingResponseStatus.Failed,
                "processing" => SchemasTrainingResponseStatus.Processing,
                "starting" => SchemasTrainingResponseStatus.Starting,
                "succeeded" => SchemasTrainingResponseStatus.Succeeded,
                _ => null,
            };
        }
    }
}