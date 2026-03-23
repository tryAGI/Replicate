
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
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Logs,
        /// <summary>
        /// 
        /// </summary>
        Output,
        /// <summary>
        /// 
        /// </summary>
        Start,
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
                SchemasVersionPredictionRequestWebhookEventsFilterItem.Completed => "completed",
                SchemasVersionPredictionRequestWebhookEventsFilterItem.Logs => "logs",
                SchemasVersionPredictionRequestWebhookEventsFilterItem.Output => "output",
                SchemasVersionPredictionRequestWebhookEventsFilterItem.Start => "start",
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
                "completed" => SchemasVersionPredictionRequestWebhookEventsFilterItem.Completed,
                "logs" => SchemasVersionPredictionRequestWebhookEventsFilterItem.Logs,
                "output" => SchemasVersionPredictionRequestWebhookEventsFilterItem.Output,
                "start" => SchemasVersionPredictionRequestWebhookEventsFilterItem.Start,
                _ => null,
            };
        }
    }
}