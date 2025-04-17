
#nullable enable

namespace Replicate
{
    /// <summary>
    /// The current status of the training
    /// </summary>
    public enum SchemasTrainingResponseStatus
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
    public static class SchemasTrainingResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemasTrainingResponseStatus value)
        {
            return value switch
            {
                SchemasTrainingResponseStatus.Starting => "starting",
                SchemasTrainingResponseStatus.Processing => "processing",
                SchemasTrainingResponseStatus.Succeeded => "succeeded",
                SchemasTrainingResponseStatus.Failed => "failed",
                SchemasTrainingResponseStatus.Canceled => "canceled",
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
                "starting" => SchemasTrainingResponseStatus.Starting,
                "processing" => SchemasTrainingResponseStatus.Processing,
                "succeeded" => SchemasTrainingResponseStatus.Succeeded,
                "failed" => SchemasTrainingResponseStatus.Failed,
                "canceled" => SchemasTrainingResponseStatus.Canceled,
                _ => null,
            };
        }
    }
}