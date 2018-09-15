using Newtonsoft.Json;

namespace FbMessengerClient.Messaging.MessageAttachments.Templates
{
    public interface ITemplatePayload : IPayload
    {
        [JsonProperty("template_type")]
        TemplateType TemplateType { get; }
    }
}
