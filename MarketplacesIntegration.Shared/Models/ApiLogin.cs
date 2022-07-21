using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class ApiLogin
    {
        public ApiLogin()
        {
            AbleToInvoices = new HashSet<AbleToInvoice>();
            ApiLogs = new HashSet<ApiLog>();
        }

        public int Id { get; set; }
        public int MaeketPlaceId { get; set; }
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? MerchantId { get; set; }
        public string? SupplierId { get; set; }
        public string? AppName { get; set; }
        public string? AppKey { get; set; }
        public string? AppSecretKey { get; set; }
        public bool Status { get; set; }

        public virtual MarketPlace MaeketPlace { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<AbleToInvoice> AbleToInvoices { get; set; }
        public virtual ICollection<ApiLog> ApiLogs { get; set; }
    }
}
