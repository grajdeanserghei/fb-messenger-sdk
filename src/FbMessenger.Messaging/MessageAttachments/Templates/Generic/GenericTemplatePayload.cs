using Newtonsoft.Json;

namespace FbMessenger.Messaging.MessageAttachments.Templates.Generic
{
    /// <summary>
    /// Generic Template payload
    /// </summary>
    public class GenericTemplatePayload : ITemplatePayload
    {
        /// <summary>
        /// Value must be generic
        /// </summary>
        public TemplateType TemplateType => TemplateType.Generic;

        /// <summary>
        /// <strong>Optional.</strong> Set to true 
        /// to enable the native share button in 
        /// Messenger for the template message. 
        /// Defaults to false.
        /// </summary>
        public bool? Sharable { get; set; }

        /// <summary>
        /// <strong>Optional.</strong> The aspect ratio used to 
        /// render images specified by element.image_url. 
        /// Must be horizontal (1.91:1) or square (1:1). 
        /// Defaults to horizontal.
        /// </summary>
        public ImageAspectRation? ImageAspectRation { get; set; }

        /// <summary>
        /// An array of element objects that 
        /// describe instances of the generic 
        /// template to be sent. Specifying multiple 
        /// elements will send a horizontally scrollable 
        /// carousel of templates. A maximum 
        /// of 10 elements is supported.
        /// </summary>
        public GenericTemplateElement[] Elements { get; set; }
    }
}
