namespace FbMessenger.Messaging.Buttons
{
    /// <summary>
    /// The URL Button opens a web page in the Messenger webview. 
    /// This allows you to enrich the conversation with a 
    /// web-based experience, where you have the full development
    ///  flexibility of the web. 
    /// For example, you might display a product summary in-conversation, 
    /// then use the URL button to open the full product page on your website.
    /// </summary>
    public class UrlButton : UrlButtonDefault
    {
        /// <summary>
        /// Button title. 20 character limit.
        /// </summary>
        /// <value></value>
        public string Title { get; set; }
    }
}
