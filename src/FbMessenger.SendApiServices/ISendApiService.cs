using System.Threading.Tasks;
using FbMessenger.Messaging;

namespace FbMessenger.SendApiServices
{
    /// <summary>
    /// Allows to send messages in facebook messenger. 
    /// Also it implements <see href="https://developers.facebook.com/docs/messenger-platform/send-messages/sender-actions">Sender Actions</see>.
    /// </summary>
    public interface ISendApiService
    {
        /// <summary>
        /// Mark last message as read
        /// </summary>
        /// <param name="recipient"></param>
        Task<SendApiResponse> MarkSeenAsync(Recipient recipient);

        /// <summary>
        /// Turn typing indicators on
        /// </summary>
        /// <param name="recipient"></param>
        Task<SendApiResponse> TypingOnAsync(Recipient recipient);

        /// <summary>
        ///  Turn typing indicators off
        /// </summary>
        /// <param name="recipient"></param>
        Task<SendApiResponse> TypingOffAsync(Recipient recipient);

        /// <summary>
        /// Sends Message request to Facebook Send API.
        /// For more details check <see href="https://developers.facebook.com/docs/messenger-platform/send-messages">Sending Messages</see> documentation.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<SendApiResponse> SendAsync(MessageRequest request);
    }
}