
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
        Web,
        /// <summary>
        /// 
        /// </summary>
        Api,
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
                SchemasTrainingResponseSource.Web => "web",
                SchemasTrainingResponseSource.Api => "api",
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
                "web" => SchemasTrainingResponseSource.Web,
                "api" => SchemasTrainingResponseSource.Api,
                _ => null,
            };
        }
    }
}