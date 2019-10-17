using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class AscoEtatStockTrace
    {
        public int NumEnreg { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public DateTime DateTrace { get; set; }
    }
}
