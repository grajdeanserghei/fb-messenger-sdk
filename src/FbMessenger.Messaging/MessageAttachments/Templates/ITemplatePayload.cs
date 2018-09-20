namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    public interface ITemplatePayload : IPayload
    {
        TemplateType TemplateType { get; }
    }
}
