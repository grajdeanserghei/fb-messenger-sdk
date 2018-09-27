using System;

namespace FbMessenger.SendApiServices
{
    public static class SendApiServiceOptionsExtensions
    {
        public static string GetUrl(this SendApiServiceOptions options)
        {
            var uriBuilder = new UriBuilder(options.SendApiUrl);
            uriBuilder.Query = $"access_token={options.AccessToken}";
            return uriBuilder.ToString();
        }
    }
}