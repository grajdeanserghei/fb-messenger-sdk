namespace FbMessenger.WebhookEvents
{
    /// <summary>
    /// 
    /// </summary>
    public class Entry
    {
        /// <summary>
        /// Page ID of page
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Time of update (epoch time in milliseconds)
        /// </summary>
        public long Time { get; set; }

        /// <summary>
        /// Array containing one messaging object. 
        /// Note that even though this is an array, 
        /// it will only contain one messaging object.
        /// </summary>
        public MessagingBase[] Messaging { get; set; }
    }
}
