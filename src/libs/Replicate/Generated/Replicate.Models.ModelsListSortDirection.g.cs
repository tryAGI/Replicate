
#nullable enable

namespace Replicate
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ModelsListSortDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsListSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsListSortDirection value)
        {
            return value switch
            {
                ModelsListSortDirection.Asc => "asc",
                ModelsListSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsListSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ModelsListSortDirection.Asc,
                "desc" => ModelsListSortDirection.Desc,
                _ => null,
            };
        }
    }
}