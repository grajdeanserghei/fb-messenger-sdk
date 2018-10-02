using FbMessenger.Messaging;

namespace FbMessenger.SendApiServices
{
    /// <summary>
    /// Encapsulates properties required for Sender Actions request.
    /// </summary>
    public class SenderActionRequest
    {
        /// <summary>
        /// Recipient of the acion
        /// </summary>
        /// <value></value>
        public Recipient Recipient { get; set; }

        /// <summary>
        /// Sender action to be displayed
        /// </summary>
        /// <value></value>
        public SenderActionTypes SenderAction { get; set; }
    }
}