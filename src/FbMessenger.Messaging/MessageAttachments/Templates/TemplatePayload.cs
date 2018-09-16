namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    public class TemplatePayload : IAttachmentBase<ITemplatePayload>
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
