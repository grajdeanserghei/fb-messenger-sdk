using Newtonsoft.Json;

namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    public interface ITemplatePayload : IPayload
    {
        [JsonProperty("template_type")]
        TemplateType TemplateType { get; }
    }
}
