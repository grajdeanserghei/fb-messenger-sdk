using Newtonsoft.Json;

namespace FbMessenger.Messaging
{
    /// <summary>
    /// Root object sent to facebook
    /// </summary>
    public class MessageRequest
    {
        /// <summary>
        /// The messaging type of the message 
        /// being sent.
        /// </summary>
        public MessagingType? MessagingType {get;set;}

        /// <summary>
        /// recipient object
        /// </summary>
        public Recipient Recipient { get; set; }

        /// <summary>
        /// message object. Cannot be sent with sender_action.
        /// </summary>
        public IMessage Message { get; set; }
    }
}