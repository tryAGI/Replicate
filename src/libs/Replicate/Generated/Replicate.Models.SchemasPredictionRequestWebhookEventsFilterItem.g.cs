
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public enum SchemasPredictionRequestWebhookEventsFilterItem
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
    public static class SchemasPredictionRequestWebhookEventsFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemasPredictionRequestWebhookEventsFilterItem value)
        {
            return value switch
            {
                SchemasPredictionRequestWebhookEventsFilterItem.Start => "start",
                SchemasPredictionRequestWebhookEventsFilterItem.Output => "output",
                SchemasPredictionRequestWebhookEventsFilterItem.Logs => "logs",
                SchemasPredictionRequestWebhookEventsFilterItem.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemasPredictionRequestWebhookEventsFilterItem? ToEnum(string value)
        {
            return value switch
            {
                "start" => SchemasPredictionRequestWebhookEventsFilterItem.Start,
                "output" => SchemasPredictionRequestWebhookEventsFilterItem.Output,
                "logs" => SchemasPredictionRequestWebhookEventsFilterItem.Logs,
                "completed" => SchemasPredictionRequestWebhookEventsFilterItem.Completed,
                _ => null,
            };
        }
    }
}