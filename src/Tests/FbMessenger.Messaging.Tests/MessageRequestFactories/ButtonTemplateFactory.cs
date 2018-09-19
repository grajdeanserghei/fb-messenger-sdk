using FbMessenger.Messaging.Buttons;
using FbMessenger.Messaging.MessageAttachments.Templates;
using FbMessenger.Messaging.MessageAttachments.Templates.Button;

namespace FbMessenger.Messaging.Tests.MessageRequestFactories
{
    public class ButtonTemplateFactory : IMessageRequestFactory
    {
        public string TestFileName => "button-template";

        public MessageRequest CreateRequest()
        {
            var request = new MessageRequest
                {
                    Recipient = new Recipient { Id = "12345-button" },
                    Message = new Message
                    {
                        Attachment = new TemplateAttachment
                        {
                            Payload = new ButtonTemplatePayload
                            {
                                Text = "What do you want to do next?",
                                Buttons = new IButton[]
                                {
                                    new UrlButton
                                    {
                                        Title = "Visit Messenger",
                                        Url = "https://www.messenger.com"
                                    },
                                    new PostbackButton
                                    {
                                        Title = "View More",
                                        Payload = "payload"
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