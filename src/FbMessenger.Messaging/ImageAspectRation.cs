using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging
{
    /// <summary>
    /// The aspect ratio used to render images.
    /// For more details check <see href="https://developers.facebook.com/docs/messenger-platform/reference/template/generic#payload">Generic Template</see>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImageAspectRation
    {
        /// <summary>
        /// (1.91:1)
        /// </summary>
        [EnumMember(Value = "horizontal")]
        Horizontal,

        /// <summary>
        /// (1:1)
        /// </summary>
        [EnumMember(Value = "square")]
        Square,
    }
}
