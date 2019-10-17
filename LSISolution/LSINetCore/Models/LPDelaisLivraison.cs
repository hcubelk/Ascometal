using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPDelaisLivraison
    {
        public int Code { get; set; }
        public decimal Lingot { get; set; }
        public string Valeur { get; set; }
        public DateTime? DateMaj { get; set; }
    }
}
