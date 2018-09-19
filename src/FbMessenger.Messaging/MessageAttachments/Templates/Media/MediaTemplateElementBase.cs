using FbMessenger.Messaging.Buttons;
using Newtonsoft.Json;

namespace FbMessenger.Messaging.MessageAttachments.Templates.Media
{
    /// <summary>
    /// Element item of <see cref="MediaTemplatePayload"/>
    /// </summary>
    public class MediaTemplateElementBase
    {
        /// <summary>
        /// The type of media being sent - image or video is supported.
        /// </summary>
        /// <value></value>
        [JsonProperty("media_type")]
        public MediaType MediaType { get; set; }

        /// <summary>
        /// An array of button objects to be appended to the template. 
        /// A maximum of 1 button is supported.
        /// </summary>
        /// <value></value>
        public IButton[] Buttons { get; set; }
    }
}