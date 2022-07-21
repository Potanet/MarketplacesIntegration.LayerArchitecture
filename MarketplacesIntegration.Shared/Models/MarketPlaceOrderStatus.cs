using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class MarketPlaceOrderStatus
    {
        public MarketPlaceOrderStatus()
        {
            OrderLines = new HashSet<OrderLine>();
            OrderStatusHistories = new HashSet<OrderStatusHistory>();
        }

        public int Id { get; set; }
        public int? OrderStatusId { get; set; }
        public int? MarketPlaceId { get; set; }
        public string? Status { get; set; }
        public string? StatusCode { get; set; }

        public virtual MarketPlace? MarketPlace { get; set; }
        public virtual OrderStatus? OrderStatus { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ICollection<OrderStatusHistory> OrderStatusHistories { get; set; }
    }
}
