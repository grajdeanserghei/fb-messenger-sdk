using System.Threading.Tasks;
using FbMessenger.Messaging;

namespace FbMessenger.SendApiServices
{
    public interface ISendApiService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="recipient"></param>
        void MarkSeen(Recipient recipient);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recipient"></param>
        Task MarkSeenAsync(Recipient recipient);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recipient"></param>
        void TypingOn(Recipient recipient);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recipient"></param>
        Task TypingOnAsync(Recipient recipient);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recipient"></param>
        void TypingOff(Recipient recipient);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recipient"></param>
        Task TypingOffAsync(Recipient recipient);
    }
}