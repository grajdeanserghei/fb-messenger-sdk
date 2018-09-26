namespace FbMessenger.Messaging.QuickReplies
{
    /// <summary>
    /// Sends a text button
    /// </summary>
    public class QuickReplyText : QuickReplyBase
    {
        /// <summary>
        /// Must be 'text'.
        /// </summary>
        public override QuickReplyType ContentType => QuickReplyType.Text;
    }
}