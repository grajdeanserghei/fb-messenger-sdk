namespace FbMessenger.Messaging.MessageAttachments
{
    /// <summary>
    /// Base class for all type of attachments
    /// </summary>
    /// <typeparam name="TPayload"></typeparam>
    public interface IAttachmentBase<out TPayload> where TPayload : IPayload
    {
        AttachmentType Type { get; }

        TPayload Payload { get; }
    }
}
