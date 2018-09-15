using Newtonsoft.Json;

namespace FbMessengerClient.Messaging
{
    public class MessageRequest
    {
        [JsonProperty("messaging_type")]
        public MessagingType MessagingType {get;set;}

        public Recipient Recipient { get; set; }

        public IMessage Message { get; set; }
    }
}