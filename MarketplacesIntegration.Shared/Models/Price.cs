using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class Price
    {
        public int Id { get; set; }
        public int? MarketPlaceId { get; set; }
        public int? ProductId { get; set; }
        public double? Price1 { get; set; }
        public int? Tax { get; set; }
        public double? Total { get; set; }
        public bool Status { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Product? Product { get; set; }
    }
}
