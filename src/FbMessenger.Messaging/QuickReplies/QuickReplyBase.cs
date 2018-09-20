using Newtonsoft.Json;

namespace FbMessenger.Messaging.QuickReplies
{
    public abstract class QuickReplyBase
    {
        public abstract QuickReplyType ContentType { get; }
    }
}