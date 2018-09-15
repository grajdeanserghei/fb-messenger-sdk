namespace FbMessengerClient.Messaging.Buttons
{
    public class UrlButtonDefault : IButton
    {
        public ButtonType Type => ButtonType.WebUrl;

        public string Url { get; set; }
    }
}
