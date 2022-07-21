using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class XfaturaAccount
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? Tenant { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool Status { get; set; }

        public virtual User? User { get; set; }
    }
}
