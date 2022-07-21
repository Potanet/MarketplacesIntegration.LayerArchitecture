using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }

        public virtual Product? Product { get; set; }
    }
}
