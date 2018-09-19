namespace FbMessenger.Messaging.MessageAttachments.Templates.Media
{
    /// <summary>
    /// The media template that sends media through Facebook url.
    /// </summary>
    public class MediaUrlElement : MediaTemplateElementBase
    {
        /// <summary>
        /// Media (image/video) url. 
        /// The media template does not allow any external URL, only those on Facebook. 
        /// To send an image or video with an external URL, 
        /// upload it using the Attachment Upload API and get an attachment_id.
        /// </summary>
        /// <value></value>
        public string Url { get; set; }
    }
}