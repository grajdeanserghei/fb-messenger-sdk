namespace FbMessenger.SendApiServices
{
    /// <summary>
    /// Keeps configuration properties for <see cref="SendApiService"/>
    /// </summary>
    public class SendApiServiceOptions
    {
        /// <summary>
        /// <strong>Optional</strong> The Facebook Send API URL. 
        /// Defaul "https://graph.facebook.com/v2.6/me/messages"
        /// </summary>
        /// <value></value>
        public string SendApiUrl { get; set; } = "https://graph.facebook.com/v2.6/me/messages";

        /// <summary>
        /// Facebook Send API access token. 
        /// </summary>
        /// <value></value>
        public string AccessToken { get; set; }
        
    }
}