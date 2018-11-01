using FbMessenger.WebhookEvents.Infrastructure.Converters;
using Newtonsoft.Json;

namespace FbMessenger.WebhookEvents.Messages
{
    /// <summary>
    /// Message attachment sent by user
    /// </summary>
    public class Attachment
    {
        /// <summary>
        /// Attachment type
        /// </summary>
        public AttachmentTypes Type { get; set; }

        /// <summary>
        /// URL of the file if attachment type is 
        /// image, audio, video or file
        /// </summary>
        [JsonConverter(typeof(PayloadConverter))]
        public IPayload Payload { get; set; }
    }
}
