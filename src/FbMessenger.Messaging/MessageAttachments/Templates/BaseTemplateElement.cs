using FbMessenger.Messaging.Buttons;

namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    /// <summary>
    /// Base class for Template elemnts
    /// </summary>
    public abstract class BaseTemplateElement
    {
        /// <summary>
        /// The title to display in the template. 
        /// 80 character limit.
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// <strong>Optional.</strong> The subtitle to display in 
        /// the template. 80 character limit.
        /// </summary>
        public virtual string Subtitle { get; set; }

        /// <summary>
        /// <strong>Optional.</strong> The URL of the image to 
        /// display in the template.
        /// </summary>
        public virtual string ImageUrl { get; set; }        

        /// <summary>
        /// <strong>Optional.</strong> The default action executed when 
        /// the template is tapped. Accepts the same 
        /// properties as URL button, except title.
        /// </summary>
        public virtual UrlButtonDefault DefaultAction { get; set; }

        /// <summary>
        /// <strong>Optional.</strong> An array of buttons to append 
        /// to the template. A maximum of 3 
        /// buttons per element is supported.
        /// </summary>
        public virtual IButton[] Buttons { get; set; }
    }
}