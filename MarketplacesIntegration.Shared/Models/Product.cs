using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class Product
    {
        public Product()
        {
            Attributes = new HashSet<Attribute>();
            Images = new HashSet<Image>();
            MarketPlaceProducts = new HashSet<MarketPlaceProduct>();
            Prices = new HashSet<Price>();
        }

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? StockCode { get; set; }
        public double? ListPrice { get; set; }
        public double? SalePrice { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<MarketPlaceProduct> MarketPlaceProducts { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
    }
}
