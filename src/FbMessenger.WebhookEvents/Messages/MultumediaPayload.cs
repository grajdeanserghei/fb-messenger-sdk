namespace FbMessenger.WebhookEvents.Messages
{
    /// <summary>
    /// Multimedia attachment payload.
    /// Contains URL to payload
    /// </summary>
    public class MultumediaPayload : IPayload
    {
        /// <summary>
        /// URL of the file
        /// </summary>
        public string Url { get; set; }
    }
}
