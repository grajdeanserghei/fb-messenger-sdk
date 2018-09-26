using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging.Buttons
{
    /// <summary>
    /// Height of the Webview.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebviewHeightRatioType
    {
        /// <summary>
        /// Bottom compact
        /// </summary>
        [EnumMember(Value = "compact")]
        Compact,

        /// <summary>
        /// Half size
        /// </summary>
        [EnumMember(Value = "tall")]
        Tall,

        /// <summary>
        /// Full screen
        /// </summary>
        [EnumMember(Value = "full")]
        Full
    }
}
