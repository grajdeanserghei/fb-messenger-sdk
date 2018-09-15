namespace FbMessengerClient.Messaging.Buttons
{
    /// <summary>
    /// 
    /// </summary>
    public class UrlButtonDefault : IButton
    {
        /// <summary>
        /// 
        /// </summary>
        public ButtonType Type => ButtonType.WebUrl;

        /// <summary>
        /// 
        /// </summary>
        public string Url { get; set; }
    }
}
