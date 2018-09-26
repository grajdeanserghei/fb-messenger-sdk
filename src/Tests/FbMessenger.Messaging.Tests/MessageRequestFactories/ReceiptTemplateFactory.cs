using FbMessenger.Messaging.MessageAttachments.Templates;

namespace FbMessenger.Messaging.Tests.MessageRequestFactories
{
    public class ReceiptTemplateFactory : IMessageRequestFactory
    {
        public string TestFileName => "receipt-template";

        public MessageRequest CreateRequest()
        {
            var request = new MessageRequest
            {
                Recipient = new Recipient { Id = "1234-rec" },
                Message = new Message
                {
                    Attachment = new TemplateAttachment
                    {
                        Payload = new ReceiptTemplatePayload
                        {
                            RecipientName = "Stephane Crozatier",
                            OrderNumber = "12345678902",
                            Currency = "USD",
                            PaymentMethod = "Visa 2345",
                            Timestamp = 1428444852,
                            Elements = new[]
                            {
                                new ReceiptElement
                                {
                                    Title = "Classic White T-Shirt",
                                    Subtitle = "100% Soft and Luxurious Cotton",
                                    Quantity = 2,
                                    Price = 50,
                                    Currency = "USD",
                                    ImageUrl = "http://petersapparel.parseapp.com/img/whiteshirt.png",
                                },
                                new ReceiptElement
                                {
                                    Title = "Classic Gray T-Shirt",
                                    Subtitle = "100% Soft and Luxurious Cotton",
                                    Quantity =1,
                                    Price = 25,
                                    Currency = "USD",
                                    ImageUrl = "http://petersapparel.parseapp.com/img/grayshirt.png",
                                }
                            },
                            Address = new ReceiptAddress
                            {
                                Street1 = "1 Hacker Way",
                                Street2 = "",
                                City = "Menlo Park",
                                PostalCode = "94025",
                                State = "CA",
                                Country = "US"
                            },
                            Summary = new ReceiptSummary
                            {
                                Subtotal = 75.00m,
                                ShippingCost = 4.95m,
                                TotalTax = 6.19m,
                                TotalCost = 56.14m
                            },
                            Adjustments = new []
                            {
                                new ReceiptAdjustment
                                {
                                    Name = "New Customer Discount",
                                    Amount = 20,
                                },
                                new ReceiptAdjustment
                                {
                                    Name = "$10 Off Coupon",
                                    Amount = 10,
                                }
                            },
                        }
                    }
                }
            };

            return request;
        }
    }
}
