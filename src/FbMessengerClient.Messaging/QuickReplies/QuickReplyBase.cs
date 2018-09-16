using Newtonsoft.Json;

namespace FbMessenger.Messaging.QuickReplies
{
    public abstract class QuickReplyBase
    {
        [JsonProperty("content_type")]
        public abstract QuickReplyType ContentType { get; }
    }
}