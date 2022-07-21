using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class Order
    {
        public Order()
        {
            InvoiceHistories = new HashSet<InvoiceHistory>();
            OrderLines = new HashSet<OrderLine>();
        }

        public string Id { get; set; } = null!;
        public int ApiLoginId { get; set; }
        public int MarketPlaceId { get; set; }
        public int? UserId { get; set; }
        public string? ApiId { get; set; }
        public string? InvoiceNo { get; set; }
        public string? InvoiceName { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? TcknVn { get; set; }
        public string? TaxOffice { get; set; }
        public string? City { get; set; }
        public string? Town { get; set; }
        public string? StreetName { get; set; }
        public string? Adress { get; set; }
        public string? Email { get; set; }
        public string? MarketPlaceOrderId { get; set; }
        public string? OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? Note1 { get; set; }
        public double? SubTotal { get; set; }
        public double? DiscountTotal { get; set; }
        public double? DiscountVat { get; set; }
        public double? TotalWithDiscount { get; set; }
        public double? VatAmount { get; set; }
        public double? TotalWithVat { get; set; }
        public int? CurrencyId { get; set; }
        public string? Title { get; set; }
        public double? CurrencyRate { get; set; }
        public int? SourceId { get; set; }
        public int? SourceRefId { get; set; }
        public string? Status { get; set; }
        public string? Json { get; set; }
        public DateTime? CreatDate { get; set; }

        public virtual ICollection<InvoiceHistory> InvoiceHistories { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
