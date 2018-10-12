using System;
using System.IO;
using FbMessenger.WebhookEvents.Messages;
using Newtonsoft.Json;
using Xunit;

namespace FbMessenger.WebhookEvents.Tests
{
    public class EventRequestSerializationTests
    {
        [Fact]
        public void ValidJson_CanDeserializeObject()
        {
            var json = GetMessageJson();

            var request = JsonConvert.DeserializeObject<EventRequest>(json);

            Assert.NotNull(request);
            Assert.NotNull(request.Entry);
        }

        [Fact]
        public void TextMessage_EntryDeserializedAsMessagingMessage()
        {
            var json = GetMessageJson();

            var request = JsonConvert.DeserializeObject<EventRequest>(json);

            Assert.Single(request.Entry);
            Assert.NotNull(request.Entry[0]);            
            Assert.Single(request.Entry[0].Messaging);
            Assert.IsAssignableFrom<MessagingMessage>(request.Entry[0].Messaging[0]);
        }

        [Fact]
        public void TextMessage_DeserializesSender()
        {
            var json = GetMessageJson();

            var request = JsonConvert.DeserializeObject<EventRequest>(json);
            var message = request.Entry[0].Messaging[0];

            Assert.NotNull(message.Sender);
            Assert.Equal("2213152575367777", message.Sender.Id);
        }

        [Fact]
        public void TextMessage_DeserializesRecipient()
        {
            var json = GetMessageJson();

            var request = JsonConvert.DeserializeObject<EventRequest>(json);
            var message = request.Entry[0].Messaging[0];

            Assert.NotNull(message.Recipient);
            Assert.Equal("585430178588888", message.Recipient.Id);
        }

        [Fact]
        public void TextMessage_DeserializesMessage()
        {
            var json = GetMessageJson();

            var request = JsonConvert.DeserializeObject<EventRequest>(json);
            var message = (MessagingMessage)request.Entry[0].Messaging[0];

            Assert.NotNull(message.Message);
            Assert.Equal("2g2jixZ61E-EQX5jMgw_CZMcElgjuzhE0PYTWGqwWfe3UFpiRvk_1TkYKrMk9tk3IN78nyEjyV5U8RAjCGpbDQ", message.Message.Mid);
            Assert.Equal("Hi", message.Message.Text);
        }

        private string GetMessageJson()
        {
            using (var reader = File.OpenText("JsonSamples/text-message.json"))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
