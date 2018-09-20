using FbMessenger.Messaging.Buttons;
using Newtonsoft.Json;

namespace FbMessenger.Messaging.MessageAttachments.Templates.List
{
    /// <summary>
    /// Element of Generic template
    /// </summary>
    public class ListTemplatePayload : ITemplatePayload
    {
        /// <summary>
        /// Value must be list
        /// </summary>
        public TemplateType TemplateType => TemplateType.List;

        /// <summary>
        /// Optional. Sets the format of the first list items. 
        /// Messenger web client currently only renders compact.
        /// compact: Renders a plain list item. 
        /// large: Renders the first list item as a cover item.
        /// </summary>
        public TopElementStyle? TopElementStyle { get; set; }

        /// <summary>
        /// Array of objects that describe items in the list.
        /// Minimum of 2 elements required. 
        /// Maximum of 4 elements is supported.
        /// </summary>
        public ListTemplateElement[] Elements { get; set; }

        /// <summary>
        /// Optional. Button to display at the bottom of the list. 
        /// Maximum of 1 button is supported.
        /// </summary>
        public IButton[] Buttons { get; set; }
        
        /// <summary>
        /// Optional. Set to true to enable the native 
        /// share button in Messenger for the template message. 
        /// Defaults to false.
        /// </summary>
        public bool? Sharable { get; set; }
    }
}