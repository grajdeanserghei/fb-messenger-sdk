using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FbMessenger.Messaging;
using FbMessenger.Messaging.Infrastructure;
using Newtonsoft.Json;

namespace FbMessenger.SendApiServices
{
    /// <summary>
    /// Sends messages to facebook messenger chat.
    /// </summary>
    public class SendApiService : ISendApiService
    {
        private readonly SendApiServiceOptions options;

        private readonly string url;

        private readonly JsonSerializerSettings serializerSettings;

        public SendApiService(SendApiServiceOptions options)
        {
            if(options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if(string.IsNullOrEmpty(options.AccessToken))
            {
                throw new ArgumentException($"property {nameof(options.AccessToken)} must be set to a valid access token", nameof(options.AccessToken));
            }

            this.options = options;
            this.url = options.GetUrl();

            this.serializerSettings = MessagingSettingFactory.GetDefaultSettings();
        }

        /// <summary>
        /// Mark last message as read
        /// </summary>
        /// <param name="recipient"></param>
        public async Task<SendApiResponse> MarkSeenAsync(Recipient recipient)
        {
            return await SendAsync(SenderActionTypes.MarkSeen, recipient);
        }        

        /// <summary>
        /// Turn typing indicators on
        /// </summary>
        /// <param name="recipient"></param>
        public async Task<SendApiResponse> TypingOnAsync(Recipient recipient)
        {
            return await SendAsync(SenderActionTypes.TypingOn, recipient);
        }

        /// <summary>
        ///  Turn typing indicators off
        /// </summary>
        /// <param name="recipient"></param>
        public async Task<SendApiResponse> TypingOffAsync(Recipient recipient)
        {
            return await SendAsync(SenderActionTypes.TypingOff, recipient);
        }

        /// <summary>
        /// Sends Message request to Facebook Send API.
        /// For more details check <see href="https://developers.facebook.com/docs/messenger-platform/send-messages">Sending Messages</see> documentation.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SendApiResponse> SendAsync(MessageRequest request)
        {
            return await SendAsync((object)request);
        }

        private async Task<SendApiResponse> SendAsync(SenderActionTypes senderAction, Recipient recipient)
        {
            var request = new SenderActionRequest
            {
                Recipient = recipient,
                SenderAction = senderAction,
            };

            return await this.SendAsync(request);
        }

        private async Task<SendApiResponse> SendAsync(object request)
        {
            using(var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(request, this.serializerSettings));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                
                var response = await client.PostAsync(url, content);
                var result = new SendApiResponse
                {
                    IsSuccess = response.IsSuccessStatusCode,
                    RawResponse = await response.Content.ReadAsStringAsync()
                };

                return result;
            }
        }
    }
}