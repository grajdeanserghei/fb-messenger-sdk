using FbMessenger.Messaging.QuickReplies;
using Newtonsoft.Json;

namespace FbMessenger.Messaging
{
    public class TextMessage : IMessage
    {
        /// <summary>
        /// Required field
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Optional property for quick replies
        /// </summary>
        [JsonProperty("quick_replies")]
        public QuickReplyBase[] QuickReplies { get; set; }
    }
}