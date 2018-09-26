using Newtonsoft.Json;

namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    /// <summary>
    /// Optional. The shipping address of the order.
    /// </summary>
    public class ReceiptAddress
    {
        /// <summary>
        /// The street address, line 1.
        /// </summary>
        [JsonProperty("street_1")]
        public string Street1 { get; set; }

        /// <summary>
        /// Optional. The street address, line 2.
        /// </summary>
        [JsonProperty("street_2")]
        public string Street2 { get; set; }

        /// <summary>
        /// The city name of the address.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The postal code of the address.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// The state abbreviation for U.S. addresses, 
        /// or the region/province for non-U.S. addresses.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The two-letter country abbreviation of the address.
        /// </summary>
        public string Country { get; set; }
    }
}
