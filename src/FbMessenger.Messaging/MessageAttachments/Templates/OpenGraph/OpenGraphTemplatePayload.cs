namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    /// <summary>
    /// The Open Graph template allows you to send a structured message
    /// with an open graph URL, plus an optional button. 
    /// Currently, only sharing songs is supported. 
    /// The song will appear in a bubble that allows the message 
    /// recipient to see album art, and preview the song.
    /// For implementation details, see <see href="https://developers.facebook.com/docs/messenger-platform/send-messages/template/open-graph">Open Graph Template</see>.
    /// </summary>
    public class OpenGraphTemplatePayload : ITemplatePayload
    {
        /// <summary>
        /// Value must be open_graph
        /// </summary>
        public TemplateType TemplateType => TemplateType.OpenGraph;

        /// <summary>
        /// Array of maximum 1 object that describes the open graph object to display.
        /// </summary>
        /// <value></value>
        public OpenGraphTemplateElement[] Elements { get; set; }
    }
}