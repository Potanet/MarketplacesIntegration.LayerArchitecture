using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class AbleToInvoice
    {
        public int Id { get; set; }
        public int? ApiLoginId { get; set; }
        public int? MarketPlaceId { get; set; }
        public int? OrderStatusId { get; set; }
        public bool IsBilling { get; set; }

        public virtual ApiLogin? ApiLogin { get; set; }
        public virtual MarketPlace? MarketPlace { get; set; }
        public virtual OrderStatus? OrderStatus { get; set; }
    }
}
