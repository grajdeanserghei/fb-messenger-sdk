using FbMessenger.Messaging.Buttons;

namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    /// <summary>
    /// Open graph template elements
    /// </summary>
    public class OpenGraphTemplateElement
    {
        /// <summary>
        /// String to display as the title of the list item. 
        /// 80 character limit. 
        /// May be truncated if the title spans too many lines.
        /// </summary>
        /// <value></value>
        public string Url { get; set; }

        /// <summary>
        /// An array of buttons to append to the template. 
        /// Open graph templates sent via beginShareFlow() 
        /// support a maximum of 1 button with `"type": "web_url".
        /// Open graph templates sent via the Send API 
        /// support a maximum of 3 buttons of any type.
        /// </summary>
        /// <value></value>
        public IButton[] Buttons { get; set; }
    }
}