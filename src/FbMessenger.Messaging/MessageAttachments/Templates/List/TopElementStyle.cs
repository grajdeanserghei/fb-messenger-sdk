using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging.MessageAttachments.Templates.List
{
    /// <summary>
    /// Defines the format of the first elemnt.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TopElementStyle
    {
        /// <summary>
        /// Renders a plain list item
        /// </summary>
        [EnumMember(Value = "compact")]
        Compact,

        /// <summary>
        /// Renders the first list item as a cover item
        /// </summary>
        [EnumMember(Value = "large")]
        Large,
    }
}