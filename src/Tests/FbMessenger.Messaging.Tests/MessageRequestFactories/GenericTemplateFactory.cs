using FbMessenger.Messaging.Buttons;
using FbMessenger.Messaging.MessageAttachments.Templates;

namespace FbMessenger.Messaging.Tests.MessageRequestFactories
{
    public class GenericTemplateFactory : IMessageRequestFactory
    {
        public string TestFileName => "generic-template";

        public MessageRequest CreateRequest()
        {
            var request = new MessageRequest
                {
                    Recipient = new Recipient { Id = "12345" },
                    Message = new Message
                    {
                        Attachment = new TemplateAttachment
                        {
                            Payload = new GenericTemplatePayload
                            {
                                Elements = new []{new GenericTemplateElement
                                {
                                    Title = "Welcome!",
                                    ImageUrl = "https://petersfancybrownhats.com/company_image.png",
                                    Subtitle = "We have the right hat for everyone.",
                                    DefaultAction = new UrlButtonDefault
                                    {
                                        Url="https://petersfancybrownhats.com/view?item=103",
                                        WebviewHeightRatio = WebviewHeightRatioType.Tall
                                    },
                                    Buttons = new IButton[]
                                    {
                                        new UrlButton
                                        {
                                            Url="https://petersfancybrownhats.com",
                                            Title = "View Website"
                                        }
                                    }
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