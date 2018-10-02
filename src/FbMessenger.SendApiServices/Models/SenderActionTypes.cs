using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.SendApiServices
{
    /// <summary>
    /// Mark last message as read
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SenderActionTypes
    {
        /// <summary>
        /// Mark last message as read
        /// </summary> 
        [EnumMember(Value = "mark_seen")]
        MarkSeen,

        /// <summary>
        /// Turn typing indicators on
        /// </summary> 
        [EnumMember(Value = "typing_on")]
        TypingOn,

        /// <summary>
        /// Turn typing indicators off
        /// </summary> 
        [EnumMember(Value = "typing_off")]
        TypingOff,
    }
}