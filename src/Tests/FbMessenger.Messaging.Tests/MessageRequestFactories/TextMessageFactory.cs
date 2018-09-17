namespace FbMessenger.Messaging.Tests.MessageRequestFactories
{
    internal class TextMessageFactory : IMessageRequestFactory
    {
        public string TestFileName => "text-message";

        public MessageRequest CreateRequest()
        {
            var request = new MessageRequest
                {
                    Recipient = new Recipient { Id = "12345" },
                    Message = new Message
                    {
                        Text = "hello, world!"
                    }
                };
            
            return request;
        }
    }
}