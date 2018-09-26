namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    /// <summary>
    /// The property values of the summary object should 
    /// be valid, well-formatted decimal numbers, 
    /// using '.' (dot) as the decimal separator. 
    /// Please note that most currencies only accept 
    /// up to 2 decimal places.
    /// </summary>
    public class ReceiptSummary
    {
        /// <summary>
        /// Optional. The sub-total of the order.
        /// </summary>
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// Optional. The shipping cost of the order.
        /// </summary>
        public decimal? ShippingCost { get; set; }

        /// <summary>
        /// Optional. The tax of the order.
        /// </summary>
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// The total cost of the order, 
        /// including sub-total, 
        /// shipping, and tax.
        /// </summary>
        public decimal TotalCost { get; set; }
    }
}
