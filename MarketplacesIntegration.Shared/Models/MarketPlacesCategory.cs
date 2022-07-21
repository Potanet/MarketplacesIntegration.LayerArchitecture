using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class MarketPlacesCategory
    {
        public int Id { get; set; }
        public int? CategoriId { get; set; }
        public int? MarketPalceId { get; set; }
        public int? UserId { get; set; }
        public string? MarketPlacesCategoryId { get; set; }
        public string? Name { get; set; }
        public int? ParentId { get; set; }
        public string? Json { get; set; }

        public virtual Category? Categori { get; set; }
        public virtual MarketPlace? MarketPalce { get; set; }
    }
}
