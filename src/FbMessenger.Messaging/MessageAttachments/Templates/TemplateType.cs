using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    /// <summary>
    /// Defines Template types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TemplateType
    {
        /// <summary>
        /// Generic template
        /// </summary>
        [EnumMember(Value = "generic")]
        Generic,

        /// <summary>
        /// List template
        /// </summary>
        [EnumMember(Value = "list")]
        List,

        /// <summary>
        /// Button template
        /// </summary>
        [EnumMember(Value = "button")]
        Button,

        /// <summary>
        /// Open Graph template
        /// </summary>
        [EnumMember(Value = "open_graph")]
        OpenGraph,

        /// <summary>
        /// Media template
        /// </summary>
        [EnumMember(Value = "media")]
        Media,

        /// <summary>
        /// Receipt template
        /// </summary>
        [EnumMember(Value = "receipt")]
        Receipt,
    }
}
