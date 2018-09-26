using System.Collections.Generic;
using System.IO;
using FbMessenger.Messaging.Infrastructure;
using FbMessenger.Messaging.Tests.MessageRequestFactories;
using Newtonsoft.Json;
using Xunit;

namespace FbMessenger.Messaging.Tests
{
    public class MessageTests
    {
        MessagingSettingFactory settingsFactory = new MessagingSettingFactory();

        public static List<object[]> Requests = new List<object[]>
        {
            new [] { new TextMessageFactory() },
            new [] { new GenericTemplateFactory() },
            new [] { new ListTemplateFactory() },
            new [] { new ButtonTemplateFactory() },
            new [] { new OpenGraphTemplateFactory() },
            new [] { new AttachmentIdMediaTemplateFactory() },
            new [] { new UrlMediaTemplateFactory() },
            new [] { new ReceiptTemplateFactory() },
        };

        [Theory]
        [MemberData(nameof(Requests))]
        public void TextMessageOnly(IMessageRequestFactory factory)
        {
            // Arrange
            var fullPath = Path.Combine("ExpectedJsons", factory.TestFileName);
            fullPath = Path.ChangeExtension(fullPath, "json");

            var expectedJson = File.ReadAllText(fullPath);

            var options = settingsFactory.GetSettings();
            options.Formatting = Formatting.Indented;

            var request = factory.CreateRequest();

            // Act
            var json = JsonConvert.SerializeObject(request, options);

            // Assert
            Assert.Equal(expectedJson, json);
        }

        [Theory]
        [InlineData(1.00, "1")]
        [InlineData(32.00, "32")]
        [InlineData(1.1234, "1.1234")]
        public void Test(double value, string expectedString)
        {
            var actualString = value.ToString("#.####");
            Assert.Equal(expectedString, actualString);
        }
    }
}
