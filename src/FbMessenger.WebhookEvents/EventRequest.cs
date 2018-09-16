namespace FbMessenger.WebhookEvents
{
    /// <summary>
    /// 
    /// </summary>
    public class EventRequest
    {
        /// <summary>
        /// Should be equal to 'page'
        /// </summary>
        public string Object { get; set; }

        /// <summary>
        /// Array containing event data
        /// </summary>
        public Entry[] Entry { get; set; }
    }
}
