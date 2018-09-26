namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    /// <summary>
    /// Objects that describe items in the order
    /// </summary>
    public class ReceiptElement
    {
        /// <summary>
        /// The name to display for the item.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Optional. The subtitle for the item, 
        /// usually a brief item description.
        /// </summary>
        public string Subtitle { get; set; }

        /// <summary>
        /// Optional. The quantity of the item purchased.
        /// </summary>
        public double Quantity { get; set; }

        /// <summary>
        /// The price of the item. For free items, '0' is allowed.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Optional. The currency of the item price.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Optional. The URL of an image to be 
        /// displayed with the item.
        /// </summary>
        public string ImageUrl { get; set; }
    }
}
