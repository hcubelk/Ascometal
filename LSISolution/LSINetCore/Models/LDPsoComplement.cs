using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDPsoComplement
    {
        public string Coulee { get; set; }
        public int NumeroLingot { get; set; }
        public string Of { get; set; }
        public string TypePso { get; set; }
        public decimal? LgTheorique1500T { get; set; }
        public decimal? LgTheoriqueCage900 { get; set; }
        public DateTime? DateMajPso { get; set; }
        public DateTime? DateLg1500T { get; set; }
        public DateTime? DateLgCage900 { get; set; }
    }
}
