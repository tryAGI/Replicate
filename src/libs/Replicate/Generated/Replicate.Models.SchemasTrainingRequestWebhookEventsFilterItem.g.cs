
#nullable enable

namespace Replicate
{
    /// <summary>
    /// 
    /// </summary>
    public enum SchemasTrainingRequestWebhookEventsFilterItem
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
    public static class SchemasTrainingRequestWebhookEventsFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemasTrainingRequestWebhookEventsFilterItem value)
        {
            return value switch
            {
                SchemasTrainingRequestWebhookEventsFilterItem.Start => "start",
                SchemasTrainingRequestWebhookEventsFilterItem.Output => "output",
                SchemasTrainingRequestWebhookEventsFilterItem.Logs => "logs",
                SchemasTrainingRequestWebhookEventsFilterItem.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemasTrainingRequestWebhookEventsFilterItem? ToEnum(string value)
        {
            return value switch
            {
                "start" => SchemasTrainingRequestWebhookEventsFilterItem.Start,
                "output" => SchemasTrainingRequestWebhookEventsFilterItem.Output,
                "logs" => SchemasTrainingRequestWebhookEventsFilterItem.Logs,
                "completed" => SchemasTrainingRequestWebhookEventsFilterItem.Completed,
                _ => null,
            };
        }
    }
}