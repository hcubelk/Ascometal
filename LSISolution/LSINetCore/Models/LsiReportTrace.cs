using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LsiReportTrace
    {
        public DateTime? Date { get; set; }
        public string Procedure { get; set; }
        public string Message { get; set; }
    }
}
