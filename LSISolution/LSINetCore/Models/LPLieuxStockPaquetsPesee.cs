using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPLieuxStockPaquetsPesee
    {
        public int Id { get; set; }
        public string Lieu { get; set; }
        public string Libelle { get; set; }
        public DateTime? DateMaj { get; set; }
    }
}
