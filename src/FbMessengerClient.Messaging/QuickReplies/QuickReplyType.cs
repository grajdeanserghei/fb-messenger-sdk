using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging.QuickReplies
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QuickReplyType
    {
        [EnumMember(Value = "text")]
        Text,
        
        [EnumMember(Value = "location")]
        Location,
        
        [EnumMember(Value = "user_phone_number")]
        UserPhoneNumber,

        [EnumMember(Value = "user_email")]
        UserEmail,
    }
}