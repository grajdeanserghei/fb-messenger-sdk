namespace FbMessenger.WebhookEvents
{
    public class MessagingBase
    {
        /// <summary>
        /// Sender user ID
        /// </summary>
        public Sender Sender { get; set; }

        /// <summary>
        /// Recipient user ID
        /// </summary>
        public Recipient Recipient { get; set; }
    }
}
