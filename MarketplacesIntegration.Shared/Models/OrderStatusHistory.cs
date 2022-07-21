using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class OrderStatusHistory
    {
        public int Id { get; set; }
        public int? OrderLinesId { get; set; }
        public int? MarketPlaceOrderStatusId { get; set; }
        public DateTime? SaveDate { get; set; }
        public string? Json { get; set; }

        public virtual MarketPlaceOrderStatus? MarketPlaceOrderStatus { get; set; }
        public virtual OrderLine? OrderLines { get; set; }
    }
}
