
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
    public static class SchemasPredictionRequestWebhookEventsFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemasPredictionRequestWebhookEventsFilterItem value)
        {
            return value switch
            {
                SchemasPredictionRequestWebhookEventsFilterItem.Completed => "completed",
                SchemasPredictionRequestWebhookEventsFilterItem.Logs => "logs",
                SchemasPredictionRequestWebhookEventsFilterItem.Output => "output",
                SchemasPredictionRequestWebhookEventsFilterItem.Start => "start",
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
                "completed" => SchemasPredictionRequestWebhookEventsFilterItem.Completed,
                "logs" => SchemasPredictionRequestWebhookEventsFilterItem.Logs,
                "output" => SchemasPredictionRequestWebhookEventsFilterItem.Output,
                "start" => SchemasPredictionRequestWebhookEventsFilterItem.Start,
                _ => null,
            };
        }
    }
}