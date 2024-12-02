
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public enum SchemasVersionPredictionRequestWebhookEventsFilterItem
    {
        /// <summary>
        /// 
        /// </summary>
        Start,
        /// <summary>
        /// 
        /// </summary>
        Output,
        /// <summary>
        /// 
        /// </summary>
        Logs,
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemasVersionPredictionRequestWebhookEventsFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemasVersionPredictionRequestWebhookEventsFilterItem value)
        {
            return value switch
            {
                SchemasVersionPredictionRequestWebhookEventsFilterItem.Start => "start",
                SchemasVersionPredictionRequestWebhookEventsFilterItem.Output => "output",
                SchemasVersionPredictionRequestWebhookEventsFilterItem.Logs => "logs",
                SchemasVersionPredictionRequestWebhookEventsFilterItem.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemasVersionPredictionRequestWebhookEventsFilterItem? ToEnum(string value)
        {
            return value switch
            {
                "start" => SchemasVersionPredictionRequestWebhookEventsFilterItem.Start,
                "output" => SchemasVersionPredictionRequestWebhookEventsFilterItem.Output,
                "logs" => SchemasVersionPredictionRequestWebhookEventsFilterItem.Logs,
                "completed" => SchemasVersionPredictionRequestWebhookEventsFilterItem.Completed,
                _ => null,
            };
        }
    }
}