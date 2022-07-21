using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            AbleToInvoices = new HashSet<AbleToInvoice>();
            MarketPlaceOrderStatuses = new HashSet<MarketPlaceOrderStatus>();
        }

        public int Id { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<AbleToInvoice> AbleToInvoices { get; set; }
        public virtual ICollection<MarketPlaceOrderStatus> MarketPlaceOrderStatuses { get; set; }
    }
}
