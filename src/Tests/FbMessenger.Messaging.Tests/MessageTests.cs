using System.Collections.Generic;
using System.IO;
using FbMessenger.Messaging.Buttons;
using FbMessenger.Messaging.Infrastructure;
using FbMessenger.Messaging.MessageAttachments.Templates;
using FbMessenger.Messaging.MessageAttachments.Templates.Generic;
using Newtonsoft.Json;
using Xunit;

namespace FbMessenger.Messaging.Tests
{
    public class MessageTests
    {
        MessagingSettingFactory settingsFactory = new MessagingSettingFactory();

        public static List<object[]> Requests = new List<object[]>
        {
            new object[]
            {
                new MessageRequest
                {
                    Recipient = new Recipient { Id = "12345" },
                    Message = new Message
                    {
                        Text = "hello, world!"
                    }
                },
                "text-message.json"
            },
            new object[]
            {
                new MessageRequest
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
                },
                "generic-template.json"
            }
        };

    

        [Theory]
        [MemberData(nameof(Requests))]
        public void TextMessageOnly(MessageRequest request, string expectedJsonFile)
        {
            // Arrange
            var fullPath = Path.Combine("ExpectedJsons", expectedJsonFile);

            var expectedJson = File.ReadAllText(fullPath);

            var options = settingsFactory.GetSettings();
            options.Formatting = Formatting.Indented;

            // Act
            var json = JsonConvert.SerializeObject(request, options);

            // Assert
            Assert.Equal(expectedJson, json);
        }
    }
}
