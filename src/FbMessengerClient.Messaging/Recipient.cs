namespace FbMessengerClient.Messaging
{
    /// <summary>
    /// All requests must include one of id, phone_number, or user_ref.
    /// </summary>
    public class Recipient
    {
        /// <summary>
        /// Either PSID, phone_number, or user_ref 
        /// of the message recipient.
        /// </summary>
        public string Id { get; set; }
    }
}