namespace FbMessenger.SendApiServices
{
    public class SendApiServiceOptions
    {
        public string SendApiUrl { get; set; } = "https://graph.facebook.com/v2.6/me/messages";

        public string AccessToken { get; set; }
        
    }
}