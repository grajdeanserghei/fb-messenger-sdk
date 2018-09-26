namespace FbMessenger.Messaging.QuickReplies
{
    /// <summary>
    /// Base class for quick reply.
    /// </summary>
    public abstract class QuickReplyBase
    {
        /// <summary>
        /// Content type of quick reply.
        /// </summary>
        public abstract QuickReplyType ContentType { get; }
    }
}