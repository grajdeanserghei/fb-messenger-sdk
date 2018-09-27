using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FbMessenger.Messaging;
using FbMessenger.Messaging.Infrastructure;
using Newtonsoft.Json;

namespace FbMessenger.SendApiServices
{
    public class SendApiService   
    {
        private readonly SendApiServiceOptions options;

        private readonly string url;

        private readonly JsonSerializerSettings serializerSettings;


        public SendApiService(SendApiServiceOptions options)
        {
            this.options = options;
            this.url = options.GetUrl();

            this.serializerSettings = MessagingSettingFactory.GetDefaultSettings();
        }
        
        public void Send(MessageRequest request)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SendApiResponse> SendAsync(MessageRequest request)
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