using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging.QuickReplies
{
    /// <summary>
    /// Quick reply types.
    /// For more details check <see href="https://developers.facebook.com/docs/messenger-platform/reference/send-api/quick-replies">Quick Repies</see>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QuickReplyType
    {
        /// <summary>
        /// Sends a text button
        /// </summary>
        [EnumMember(Value = "text")]
        Text,

        /// <summary>
        /// Sends a button to collect the recipient's location
        /// </summary>
        [EnumMember(Value = "location")]
        Location,

        /// <summary>
        /// Sends a button allowing recipient to send the phone number associated with their account
        /// </summary>
        [EnumMember(Value = "user_phone_number")]
        UserPhoneNumber,

        /// <summary>
        /// Sends a button allowing recipient to send the email associated with their account.
        /// </summary>
        [EnumMember(Value = "user_email")]
        UserEmail,
    }
}