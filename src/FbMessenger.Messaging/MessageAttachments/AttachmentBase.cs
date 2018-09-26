namespace FbMessenger.Messaging.MessageAttachments
{
    /// <summary>
    /// Base class for all type of attachments
    /// </summary>
    /// <typeparam name="TPayload"></typeparam>
    public interface IAttachmentBase<out TPayload> where TPayload : IPayload
    {
        /// <summary>
        /// Type of attachment.
        /// </summary>
        AttachmentType Type { get; }

        /// <summary>
        /// Attachment payload
        /// </summary>
        TPayload Payload { get; }
    }
}
