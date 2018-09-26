namespace FbMessenger.Messaging
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

        /// <summary>
        /// Optional. Phone number of the recipient with the format +1(212)555-2368.
        /// Your bot must be approved for <see href="https://developers.facebook.com/docs/messenger-platform/identity/customer-matching">Customer Matching</see>
        /// to send messages this way.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Optional. user_ref from the checkbox plugin.
        /// </summary>
        public string UserRef { get; set; }

        /// <summary>
        /// Optional. Used only if phone_number is set. Specifies the person's name in the format:
        /// {"first_name":"John", "last_name":"Doe"}
        /// Providing a name increases the odds 
        /// of a successful match.
        /// </summary>
        public RecipientName Name { get; set; }
    }
}