
#nullable enable

namespace Replicate
{
    /// <summary>
    /// How the training was created
    /// </summary>
    public enum SchemasTrainingResponseSource
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
    public static class SchemasTrainingResponseSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemasTrainingResponseSource value)
        {
            return value switch
            {
                SchemasTrainingResponseSource.Api => "api",
                SchemasTrainingResponseSource.Web => "web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemasTrainingResponseSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => SchemasTrainingResponseSource.Api,
                "web" => SchemasTrainingResponseSource.Web,
                _ => null,
            };
        }
    }
}