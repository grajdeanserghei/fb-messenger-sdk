using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessagingType
    {
        [EnumMember(Value = "RESPONSE")]
        Response,
        
        [EnumMember(Value = "UPDATE")]
        Update,
        
        [EnumMember(Value = "MESSAGE_TAG")]
        MessageTag,
    }
}