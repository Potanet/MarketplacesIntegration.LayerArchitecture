using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class MarketPlaceLog
    {
        public int Id { get; set; }
        public int? MarketPlaceId { get; set; }
        public int? UserId { get; set; }
        public int? OperationTypeId { get; set; }
        public string? Title { get; set; }
        public string? Request { get; set; }
        public string? Response { get; set; }
        public DateTime? DateTime { get; set; }
        public string? Ip { get; set; }

        public virtual OperationType? OperationType { get; set; }
        public virtual User? User { get; set; }
    }
}
