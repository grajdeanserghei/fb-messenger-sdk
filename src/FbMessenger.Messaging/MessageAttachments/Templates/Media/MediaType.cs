using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    /// <summary>
    /// Supported Media template types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MediaType
    {
        /// <summary>
        /// Image media
        /// </summary>
        [EnumMember(Value = "image")]
        Image,

        /// <summary>
        /// Video media
        /// </summary>
        [EnumMember(Value = "video")]
        Video,
    }
}