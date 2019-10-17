using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class AscoEtatStockTmp
    {
        public int NumEnreg { get; set; }
        public string Coulee { get; set; }
        public string Pso { get; set; }
        public int? NbLignot { get; set; }
        public string Nuance { get; set; }
        public string Parc { get; set; }
        public string Lieu { get; set; }
        public string LsiParc { get; set; }
        public string LsiLieu { get; set; }
    }
}
