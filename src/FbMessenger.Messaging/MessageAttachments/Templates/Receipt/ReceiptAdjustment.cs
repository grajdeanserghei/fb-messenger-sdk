namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    /// <summary>
    /// Objects that describe payment adjustments, 
    /// such as discounts
    /// </summary>
    public class ReceiptAdjustment
    {
        /// <summary>
        /// Required if the adjustments array is set. 
        /// Name of the adjustment.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Required if the adjustments array is set. 
        /// The amount of the adjustment.
        /// </summary>
        public decimal Amount { get; set; }
    }
}
