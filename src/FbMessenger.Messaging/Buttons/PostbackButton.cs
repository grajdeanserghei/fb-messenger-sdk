namespace FbMessenger.Messaging.Buttons
{
    /// <summary>
    /// The postback button sends a messaging_postbacks event 
    /// to your webhook with the string set in the payload property. 
    /// This allows you to take an arbitrary actions when the
    /// button is tapped. For example, you might display a list of 
    /// products, then send the product ID in the postback to your webhook, 
    /// where it can be used to query your database and return the 
    /// product details as a structured message.
    /// </summary>
    public class PostbackButton : IButton
    {
        /// <summary>
        /// Type of button. Must be postback.
        /// </summary>
        public ButtonType Type => ButtonType.Postback;

        /// <summary>
        /// Button title. 20 character limit.
        /// </summary>
        /// <value></value>
        public string Title { get; set; }

        /// <summary>
        /// This data will be sent back to your webhook. 
        /// 1000 character limit.
        /// </summary>
        /// <value></value>
        public string Payload { get; set; }
    }
}