namespace FbMessenger.Messaging.Tests.MessageRequestFactories
{
    public interface IMessageRequestFactory
    {
        MessageRequest CreateRequest();

        string TestFileName { get; }
    }
}