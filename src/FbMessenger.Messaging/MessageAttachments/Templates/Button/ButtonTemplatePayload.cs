using FbMessenger.Messaging.Buttons;

namespace FbMessenger.Messaging.MessageAttachments.Templates.Button
{
    /// <summary>
    /// The button template allows you to send a structured message that includes text and buttons.
    /// </summary>
    public class ButtonTemplatePayload : ITemplatePayload
    {
        /// <summary>
        /// Value must be button
        /// </summary>
        /// <returns></returns>
        public TemplateType TemplateType => TemplateType.Button;

        /// <summary>
        /// UTF-8-encoded text of up to 640 characters. Text will appear above the buttons.
        /// </summary>
        /// <value></value>
        public string Text { get; set; }

        /// <summary>
        /// Set of 1-3 buttons that appear as call-to-actions.
        /// </summary>
        /// <value></value>
        public IButton[] Buttons { get; set; }

        /// <summary>
        /// Optional. Set to true to enable the native share button in Messenger for the template message. Defaults to false.
        /// </summary>
        /// <value></value>
        public bool? Sharable { get; set; }
    }
}