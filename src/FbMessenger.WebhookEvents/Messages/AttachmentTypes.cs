using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.WebhookEvents.Messages
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttachmentTypes
    {
        [EnumMember(Value = "audio")]
        Audio,

        [EnumMember(Value = "fallback")]
        Fallback,

        [EnumMember(Value = "file")]
        File,

        [EnumMember(Value = "image")]
        Image,

        [EnumMember(Value = "location")]
        Location,

        [EnumMember(Value = "video")]
        Video
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
