using FbMessenger.Messaging.MessageAttachments.Templates;

namespace FbMessenger.Messaging.Tests.MessageRequestFactories
{
    public class AttachmentIdMediaTemplateFactory : IMessageRequestFactory
    {
        public string TestFileName => "attachment-id-media-template";

        public MessageRequest CreateRequest()
        {
            var request = new MessageRequest
                {
                    Recipient = new Recipient { Id = "1234-at" },
                    Message = new Message
                    {
                        Attachment = new TemplateAttachment
                        {
                            Payload = new MediaTemplatePayload
                            {
                                Elements = new []
                                {
                                    new MediaAttachmentIdElement
                                    {
                                        MediaType = MediaType.Image,
                                        AttachmentId = "12345id"
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