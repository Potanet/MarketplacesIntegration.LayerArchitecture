using System;
using System.Collections.Generic;

namespace MarketplacesIntegration.Shared.Models
{
    public partial class Log
    {
        public int Id { get; set; }
        public int? Code { get; set; }
        public string? ShortMessage { get; set; }
        public string? RequestTallMessage { get; set; }
        public string? ResponseTallMessage { get; set; }
        public bool IsSuccesed { get; set; }
        public DateTime DateTime { get; set; }
        public string? Ip { get; set; }
    }
}
