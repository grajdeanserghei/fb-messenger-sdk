using Newtonsoft.Json;

namespace FbMessenger.Messaging.MessageAttachments.Templates.Media
{
    /// <summary>
    /// To send an image, send a POST request to the Send API, 
    /// with the following payload property in the request body, 
    /// where attachment_id is an ID generated from the 
    /// attachment upload API. 
    /// For requests using the attachment_id property, images and videos are supported.
    /// </summary>
    public class MediaAttachmentIdElement : MediaTemplateElementBase
    {
        /// <summary>
        /// The attachment ID of the image or video. Cannot be used if url is set.
        /// </summary>
        /// <value></value>
        [JsonProperty("attachment_id")]
        public string AttachmentId { get; set; }
    }
}