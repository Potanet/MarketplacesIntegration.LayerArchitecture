using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class OrderLine
    {
        public OrderLine()
        {
            OrderStatusHistories = new HashSet<OrderStatusHistory>();
        }

        public int Id { get; set; }
        public string OrderId { get; set; } = null!;
        public int MarketPlaceOrderStatusId { get; set; }
        public string MarketPlaceOrderId { get; set; } = null!;
        public string? ProductName { get; set; }
        public double? Quantity { get; set; }
        public string? Unit { get; set; }
        public double? Price { get; set; }
        public double? DiscountRate { get; set; }
        public double? DiscountAmount { get; set; }
        public double? SubTotal { get; set; }
        public double? TotalWithDiscount { get; set; }
        public double? VatRate { get; set; }
        public double? VatAmount { get; set; }
        public double? TotalWithVat { get; set; }
        public string? UnitCode { get; set; }
        public string? ProductCode { get; set; }
        public string? Status { get; set; }

        public virtual MarketPlaceOrderStatus MarketPlaceOrderStatus { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
        public virtual ICollection<OrderStatusHistory> OrderStatusHistories { get; set; }
    }
}
