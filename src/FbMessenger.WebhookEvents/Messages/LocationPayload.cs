namespace FbMessenger.WebhookEvents.Messages
{
    /// <summary>
    /// Location payload
    /// </summary>
    public class LocationPayload : IPayload
    {
        public Coordinates Coordinates { get; set; }
    }
}
