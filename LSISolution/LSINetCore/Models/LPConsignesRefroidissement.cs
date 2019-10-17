using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPConsignesRefroidissement
    {
        public string Code { get; set; }
        public string Libelle { get; set; }
        public DateTime? DateMaj { get; set; }
    }
}
