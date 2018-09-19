namespace FbMessenger.Messaging.MessageAttachments.Templates.Media
{
    /// <summary>
    /// The media template allows you to send a structured message 
    /// that includes an image or video, and an optional button. 
    /// For complete implementation details, see <see href="https://developers.facebook.com/docs/messenger-platform/send-messages/template/media">Media Template</see>
    /// </summary>
    public class MediaTemplatePayload : ITemplatePayload
    {
        /// <summary>
        /// Value must be media
        /// </summary>
        public TemplateType TemplateType => TemplateType.Media;

        /// <summary>
        /// An array containing 1 element object that describe the media in the message. 
        /// A maximum of 1 element is supported.
        /// </summary>
        /// <value></value>
        public MediaTemplateElementBase[] Elements { get; set; }

        /// <summary>
        /// Optional. Set to true to enable the native 
        /// share button in Messenger for the template message. 
        /// Defaults to false.
        /// </summary>
        /// <value></value>
        public bool? Sharable { get; set; }


    }
}