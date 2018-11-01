using System;
using System.Collections.Generic;
using System.Text;

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
        public string Payload { get; set; }
    }
}
