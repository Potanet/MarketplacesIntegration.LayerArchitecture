using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class Category
    {
        public Category()
        {
            MarketPlacesCategories = new HashSet<MarketPlacesCategory>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public int? SubId { get; set; }
        public string? Titile { get; set; }
        public string? Code { get; set; }

        public virtual ICollection<MarketPlacesCategory> MarketPlacesCategories { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
