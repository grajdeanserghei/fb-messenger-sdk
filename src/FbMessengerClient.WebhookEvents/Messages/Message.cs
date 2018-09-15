using Newtonsoft.Json;

namespace FbMessengerClient.WebhookEvents.Messages
{
    public class Message
    {
        /// <summary>
        /// Message ID
        /// </summary>
        public string Mid { get; set; }

        /// <summary>
        /// Text of message
        /// </summary>
        public string Text { get; set; }

        [JsonProperty("quick_reply")]
        public QuickReply QuickReply { get; set; }
    }
}
