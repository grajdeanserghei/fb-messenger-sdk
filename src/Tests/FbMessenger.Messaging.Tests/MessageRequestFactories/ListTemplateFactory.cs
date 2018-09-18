using FbMessenger.Messaging.Buttons;
using FbMessenger.Messaging.MessageAttachments.Templates;
using FbMessenger.Messaging.MessageAttachments.Templates.List;

namespace FbMessenger.Messaging.Tests.MessageRequestFactories
{
    public class ListTemplateFactory : IMessageRequestFactory
    {
        public string TestFileName => "list-template";

        public MessageRequest CreateRequest()
        {
            var request = new MessageRequest
                {
                    Recipient = new Recipient { Id = "12345-list" },
                    Message = new Message
                    {
                        Attachment = new TemplateAttachment
                        {
                            Payload = new ListTemplatePayload
                            {
                                TopElementStyle = TopElementStyle.Compact,
                                Elements = new []
                                {
                                    new ListTemplateElement
                                    {
                                        Title = "Classic T-Shirt Collection",
                                        Subtitle = "See all our colors",
                                        ImageUrl = "https://peterssendreceiveapp.ngrok.io/img/collection.png",
                                        Buttons = new []
                                        {
                                            new UrlButton
                                            {
                                                Title = "View",
                                                Url = "https://peterssendreceiveapp.ngrok.io/collection",
                                                MessengerExtensions = true,
                                                WebviewHeightRatio = WebviewHeightRatioType.Tall,
                                                FallbackUrl = "https://peterssendreceiveapp.ngrok.io/"            
                                            }
                                        }
                                    },
                                    new ListTemplateElement
                                    {
                                        Title = "Classic White T-Shirt",
                                        Subtitle = "See all our colors",
                                        DefaultAction = new UrlButtonDefault
                                        {
                                            Url = "https://peterssendreceiveapp.ngrok.io/view?item=100",
                                            MessengerExtensions = false,
                                            WebviewHeightRatio = WebviewHeightRatioType.Tall
                                        }
                                    },
                                    new ListTemplateElement
                                    {
                                        Title = "Classic Blue T-Shirt",
                                        ImageUrl = "https://peterssendreceiveapp.ngrok.io/img/blue-t-shirt.png",
                                        Subtitle = "100% Cotton, 200% Comfortable",
                                        DefaultAction = new UrlButtonDefault
                                        {
                                            Url = "https://peterssendreceiveapp.ngrok.io/view?item=101",
                                            MessengerExtensions = true,
                                            WebviewHeightRatio = WebviewHeightRatioType.Tall,
                                            FallbackUrl = "https://peterssendreceiveapp.ngrok.io/"
                                        },
                                        Buttons = new []
                                        {
                                            new UrlButton
                                            {
                                                Title = "Shop Now",                                              
                                                Url = "https://peterssendreceiveapp.ngrok.io/shop?item=101",
                                                MessengerExtensions = true,
                                                WebviewHeightRatio = WebviewHeightRatioType.Tall,
                                                FallbackUrl = "https://peterssendreceiveapp.ngrok.io/"            
                                            }
                                        }
                                    },
                                },
                                Buttons = new[]
                                {
                                    new PostbackButton
                                    {
                                        Title = "View More",
                                        Payload = "payload",
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