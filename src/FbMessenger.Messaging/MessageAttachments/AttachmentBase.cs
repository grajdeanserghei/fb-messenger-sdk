namespace FbMessenger.Messaging.MessageAttachments
{
    public interface IAttachmentBase<TPayload> where TPayload : IPayload
    {
        AttachmentType Type { get; }

        TPayload Payload { get; }
    }
}
