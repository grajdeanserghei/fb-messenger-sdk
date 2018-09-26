using FbMessenger.Messaging.Infrastructure;
using Newtonsoft.Json;

namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    /// <summary>
    /// The receipt template allows to send an order confirmation 
    /// as a structured message. 
    /// The template may include an order summary, 
    /// payment details, and shipping information.
    /// </summary>
    public class ReceiptTemplatePayload : ITemplatePayload
    {
        /// <summary>
        /// Value must be receipt.
        /// </summary>
        public TemplateType TemplateType => TemplateType.Receipt;

        /// <summary>
        /// Optional. Set to true to enable the 
        /// native share button in Messenger for the 
        /// template message. Defaults to false.
        /// </summary>
        public bool? Sharable { get; set; }

        /// <summary>
        /// The recipient's name.
        /// </summary>
        public string RecipientName { get; set; }

        /// <summary>
        /// Optional. The merchant's name. 
        /// If present this is shown as logo text.
        /// </summary>
        public string MerchantName { get; set; }

        /// <summary>
        /// The order number. Must be unique.
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// The currency of the payment.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Optional. Timestamp of the order in seconds.
        /// </summary>
        [JsonConverter(typeof(ToStringConverter))]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Optional. Array of a maximum of 100 element objects 
        /// that describe items in the order. 
        /// Sort order of the elements is not guaranteed.
        /// </summary>
        public ReceiptElement[] Elements { get; set; }

        /// <summary>
        /// Optional. The shipping address of the order.
        /// </summary>
        public ReceiptAddress Address { get; set; }

        /// <summary>
        /// The payment summary, <see cref="ReceiptSummary"/>.
        /// </summary>
        public ReceiptSummary Summary { get; set; }

        /// <summary>
        /// Optional. An array of payment objects that describe 
        /// payment adjustments, such as discounts.
        /// </summary>
        public ReceiptAdjustment[] Adjustments { get; set; }
    }
}
