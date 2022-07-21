using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class InvoiceHistory
    {
        public int Id { get; set; }
        public string? OrderId { get; set; }
        public int? HttpStatusCode { get; set; }
        public string? Message { get; set; }
        public string? Value { get; set; }
        public string? Json { get; set; }
        public DateTime SaveDate { get; set; }

        public virtual Order? Order { get; set; }
    }
}
