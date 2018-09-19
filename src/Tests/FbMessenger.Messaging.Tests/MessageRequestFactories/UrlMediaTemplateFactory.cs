using FbMessenger.Messaging.MessageAttachments.Templates;
using FbMessenger.Messaging.MessageAttachments.Templates.Media;

namespace FbMessenger.Messaging.Tests.MessageRequestFactories
{
    public class UrlMediaTemplateFactory : IMessageRequestFactory
    {
        public string TestFileName => "url-media-template";

        public MessageRequest CreateRequest()
        {
            var request = new MessageRequest
                {
                    Recipient = new Recipient { Id = "1234-url" },
                    Message = new Message
                    {
                        Attachment = new TemplateAttachment
                        {
                            Payload = new MediaTemplatePayload
                            {
                                Elements = new []
                                {
                                    new MediaUrlElement
                                    {
                                        MediaType = MediaType.Video,
                                        Url = "https://www.facebook.com/<USERNAME>/videos/<NUMERIC_ID>/",
                                    }
                                }
                            }
                        }
                    }
                };
            
            return request;
        }
    }
}