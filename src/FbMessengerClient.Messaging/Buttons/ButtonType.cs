using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessengerClient.Messaging.Buttons
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ButtonType
    {
        [EnumMember(Value = "web_url")]
        WebUrl,

    }
}
