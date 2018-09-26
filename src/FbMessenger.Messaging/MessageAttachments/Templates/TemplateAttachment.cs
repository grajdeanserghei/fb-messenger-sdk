namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    /// <summary>
    /// Attachment implementation for Template attachments
    /// </summary>
    public class TemplateAttachment : IAttachmentBase<ITemplatePayload>
    {
        /// <summary>
        /// Value must be template
        /// </summary>
        public AttachmentType Type => AttachmentType.Template;

        /// <summary>
        /// payload of the template.
        /// </summary>
        public ITemplatePayload Payload { get; set; }
    }
}
