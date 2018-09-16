using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImageAspectRation
    {
        [EnumMember(Value = "horizontal")]
        Horizontal,

        [EnumMember(Value = "square")]
        Square,
    }
}
