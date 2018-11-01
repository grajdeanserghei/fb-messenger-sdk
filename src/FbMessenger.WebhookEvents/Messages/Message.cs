using Newtonsoft.Json;

namespace FbMessenger.WebhookEvents.Messages
{
    /// <summary>
    /// Message sent by user
    /// </summary>
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

        /// <summary>
        /// A quick_reply payload is only provided with 
        /// a text message when the user tap on 
        /// a Quick Replies button.
        /// </summary>
        [JsonProperty("quick_reply")]
        public QuickReply QuickReply { get; set; }

        /// <summary>
        /// Array containing attachment data
        /// </summary>
        public Attachment[] Attachments { get; set; }
    }
}
