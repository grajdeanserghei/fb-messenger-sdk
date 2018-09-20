using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging.MessageAttachments
{
    /// <summary>
    /// Defines possible attachment types.
    /// The Messenger Platform allows you to attach assets 
    /// to messages, including audio, video, images, 
    /// and files. Max attachment size is 25MB
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttachmentType
    {
        /// <summary>
        /// Audio attachment
        /// </summary>
        [EnumMember(Value = "audio")]
        Audio,

        /// <summary>
        /// Video attachment uploaded or sent as attachment id.
        /// </summary>
        [EnumMember(Value = "video")]
        Video,

        /// <summary>
        /// Image attachment uploaded or sent as attachment id.
        /// </summary>
        [EnumMember(Value = "image")]
        Image,

        /// <summary>
        /// Attachment from file, submited through 
        /// POST request to the Send API 
        /// with the message details as form data.
        /// </summary>
        [EnumMember(Value = "file")]
        File,

        /// <summary>
        /// Attachment with rich control elements.
        /// For more details check <see href="https://developers.facebook.com/docs/messenger-platform/send-messages/templates">Message Templates</see>
        /// </summary>
        [EnumMember(Value = "template")]
        Template,
    }
}
