using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class User
    {
        public User()
        {
            ApiLogins = new HashSet<ApiLogin>();
            MarketPlaceLogs = new HashSet<MarketPlaceLog>();
            XfaturaAccounts = new HashSet<XfaturaAccount>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? RepresentativeName { get; set; }
        public string? Tel { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? XfaturaUserName { get; set; }
        public string? XfaturaPassword { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<ApiLogin> ApiLogins { get; set; }
        public virtual ICollection<MarketPlaceLog> MarketPlaceLogs { get; set; }
        public virtual ICollection<XfaturaAccount> XfaturaAccounts { get; set; }
    }
}
