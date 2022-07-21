using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class MarketPlaceProduct
    {
        public int Id { get; set; }
        public int? MarketPlaceId { get; set; }
        public int? ProductId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public double? PriceId { get; set; }
        public double? ListPrice { get; set; }
        public int? Stock { get; set; }
        public string? Json { get; set; }

        public virtual MarketPlace? MarketPlace { get; set; }
        public virtual Product? Product { get; set; }
    }
}
