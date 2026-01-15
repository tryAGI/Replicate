
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public enum PredictionsListSource
    {
        /// <summary>
        /// 
        /// </summary>
        Web,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionsListSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionsListSource value)
        {
            return value switch
            {
                PredictionsListSource.Web => "web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionsListSource? ToEnum(string value)
        {
            return value switch
            {
                "web" => PredictionsListSource.Web,
                _ => null,
            };
        }
    }
}