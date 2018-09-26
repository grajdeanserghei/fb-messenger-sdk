using FbMessenger.Messaging.MessageAttachments;
using FbMessenger.Messaging.QuickReplies;

namespace FbMessenger.Messaging
{
    /// <summary>
    /// Message object from Send API.
    /// </summary>
    public class Message : IMessage
    {
        /// <summary>
        /// Message text. Previews will not be shown 
        /// for the URLs in this field. 
        /// Use attachment instead. 
        /// Must be UTF-8 and has a 2000 character limit. 
        /// text or attachment must be set.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// attachment object. 
        /// Previews the URL. 
        /// Used to send messages with media 
        /// or Structured Messages. 
        /// text or attachment must be set.
        /// </summary>
        public IAttachmentBase<IPayload> Attachment { get; set; }

        /// <summary>
        /// Optional. Array of quick_reply to be sent with messages
        /// </summary>
        public QuickReplyBase[] QuickReplies { get; set; }

        /// <summary>
        /// Optional. Custom string that is delivered as a 
        /// message echo. 1000 character limit.
        /// </summary>
        public string Metadata { get; set; }
    }
}