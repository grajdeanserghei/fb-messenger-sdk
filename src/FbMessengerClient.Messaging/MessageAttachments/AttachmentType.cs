using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessengerClient.Messaging.MessageAttachments
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttachmentType
    {
        [EnumMember(Value = "audio")]
        Audio,

        [EnumMember(Value = "video")]
        Video,

        [EnumMember(Value = "image")]
        Image,

        [EnumMember(Value = "file")]
        File,

        [EnumMember(Value = "template")]
        Template,
    }
}
