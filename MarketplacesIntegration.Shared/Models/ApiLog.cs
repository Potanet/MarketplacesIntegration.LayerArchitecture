using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class ApiLog
    {
        public string Id { get; set; } = null!;
        public int? ApiLoginId { get; set; }
        public string? OperationType { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string? Json { get; set; }
        public DateTime? SaveDate { get; set; }

        public virtual ApiLogin? ApiLogin { get; set; }
    }
}
