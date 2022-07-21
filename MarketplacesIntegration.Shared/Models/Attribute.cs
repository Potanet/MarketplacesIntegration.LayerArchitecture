using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class Attribute
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? MarketPlaceId { get; set; }
        public string? AttributeId { get; set; }
        public string? Keys { get; set; }
        public string? Value { get; set; }

        public virtual MarketPlace? MarketPlace { get; set; }
        public virtual Product? Product { get; set; }
    }
}
