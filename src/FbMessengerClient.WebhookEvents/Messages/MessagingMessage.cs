namespace FbMessengerClient.WebhookEvents.Messages
{
    /// <summary>
    /// Text messages sent by user
    /// </summary>
    public class MessagingMessage : MessagingBase
    {
        /// <summary>
        /// 
        /// </summary>
        public long Timestam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Message Message { get; set; }
    }
}
