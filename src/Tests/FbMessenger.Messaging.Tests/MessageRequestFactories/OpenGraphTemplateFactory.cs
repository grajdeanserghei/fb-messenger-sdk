using FbMessenger.Messaging.Buttons;
using FbMessenger.Messaging.MessageAttachments.Templates;
using FbMessenger.Messaging.MessageAttachments.Templates.OpenGraph;

namespace FbMessenger.Messaging.Tests.MessageRequestFactories
{
    public class OpenGraphTemplateFactory : IMessageRequestFactory
    {
        public string TestFileName => "opengraph-template";

        public MessageRequest CreateRequest()
        {
            var request = new MessageRequest
                {
                    Recipient = new Recipient { Id = "12345-og" },
                    Message = new Message
                    {
                        Attachment = new TemplateAttachment
                        {
                            Payload = new OpenGraphTemplatePayload
                            {
                                Elements = new OpenGraphTemplateElement[]
                                {
                                    new OpenGraphTemplateElement
                                    {
                                        Url = "https://open.spotify.com/track/7GhIk7Il098yCjg4BQjzvb",
                                        Buttons = new IButton[]
                                        {
                                            new UrlButton
                                            {
                                                Title = "View More",
                                                Url = "https://en.wikipedia.org/wiki/Rickrolling"
                                            },
                                        },
                                    },
                                    
                                }
                            }
                        }
                    }
                };
            
            return request;
        }
    }
}