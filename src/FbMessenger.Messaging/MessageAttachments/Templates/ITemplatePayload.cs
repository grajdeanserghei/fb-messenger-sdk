namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    /// <summary>
    /// Interface for all template payloads.
    /// </summary>
    public interface ITemplatePayload : IPayload
    {
        /// <summary>
        /// Specifies type of template.
        /// </summary>
        TemplateType TemplateType { get; }
    }
}
