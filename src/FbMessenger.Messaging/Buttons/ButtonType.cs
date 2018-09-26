using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging.Buttons
{
    /// <summary>
    /// Defines available button types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ButtonType
    {
        /// <summary>
        /// The URL Button opens a web page in the Messenger webview
        /// </summary>
        [EnumMember(Value = "web_url")]
        WebUrl,

        /// <summary>
        /// The postback button sends a messaging_postbacks event 
        /// to your webhook with the string set in the payload property
        /// </summary>
        [EnumMember(Value = "postback")]
        Postback,

        /// <summary>
        /// The share button allows the message recipient to share 
        /// the content of a message you sent with others on Messenger
        /// </summary>
        [EnumMember(Value = "element_share")]
        Share,

        /// <summary>
        /// The buy button begins the in-conversation payments flow
        /// </summary>
        [EnumMember(Value = "payment")]
        Buy,


        /// <summary>
        /// The call button dials a phone number when tapped
        /// </summary>
        [EnumMember(Value = "phone_number")]
        Call,

        /// <summary>
        /// The log in button is used in the account linking flow, which lets you link the message recipient's identity on Messenger with their account on your site by directing them to your web-based login flow for authentication.
        /// </summary>
        [EnumMember(Value = "account_link")]
        Login,

        /// <summary>
        /// The log out button is used in the account linking flow to 
        /// unlink the message recipient's identity on Messenger with their account on your site.
        /// </summary>
        [EnumMember(Value = "account_unlink")]
        Logout,

    }
}
