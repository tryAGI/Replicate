
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
    public static class SchemasTrainingRequestWebhookEventsFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemasTrainingRequestWebhookEventsFilterItem value)
        {
            return value switch
            {
                SchemasTrainingRequestWebhookEventsFilterItem.Completed => "completed",
                SchemasTrainingRequestWebhookEventsFilterItem.Logs => "logs",
                SchemasTrainingRequestWebhookEventsFilterItem.Output => "output",
                SchemasTrainingRequestWebhookEventsFilterItem.Start => "start",
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
                "completed" => SchemasTrainingRequestWebhookEventsFilterItem.Completed,
                "logs" => SchemasTrainingRequestWebhookEventsFilterItem.Logs,
                "output" => SchemasTrainingRequestWebhookEventsFilterItem.Output,
                "start" => SchemasTrainingRequestWebhookEventsFilterItem.Start,
                _ => null,
            };
        }
    }
}