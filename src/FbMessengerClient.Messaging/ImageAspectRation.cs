using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessengerClient.Messaging
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
