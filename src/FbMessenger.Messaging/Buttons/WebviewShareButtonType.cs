using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging.Buttons
{
    /// <summary>
    /// Enables or disables share button
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebviewShareButtonType
    {
        /// <summary>
        /// Hides share button in web view
        /// </summary>
        [EnumMember(Value = "hide")]
        Hide
    }
}
