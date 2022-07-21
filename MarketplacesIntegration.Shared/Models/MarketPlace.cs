using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class MarketPlace
    {
        public MarketPlace()
        {
            AbleToInvoices = new HashSet<AbleToInvoice>();
            ApiLogins = new HashSet<ApiLogin>();
            Attributes = new HashSet<Attribute>();
            MarketPlaceOrderStatuses = new HashSet<MarketPlaceOrderStatus>();
            MarketPlaceProducts = new HashSet<MarketPlaceProduct>();
            MarketPlacesCategories = new HashSet<MarketPlacesCategory>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<AbleToInvoice> AbleToInvoices { get; set; }
        public virtual ICollection<ApiLogin> ApiLogins { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<MarketPlaceOrderStatus> MarketPlaceOrderStatuses { get; set; }
        public virtual ICollection<MarketPlaceProduct> MarketPlaceProducts { get; set; }
        public virtual ICollection<MarketPlacesCategory> MarketPlacesCategories { get; set; }
    }
}
