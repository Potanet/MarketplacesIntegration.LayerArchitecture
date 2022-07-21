using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class OperationType
    {
        public OperationType()
        {
            MarketPlaceLogs = new HashSet<MarketPlaceLog>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<MarketPlaceLog> MarketPlaceLogs { get; set; }
    }
}
