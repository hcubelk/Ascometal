using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LSBilanPitsCoulee
    {
        public DateTime Jour { get; set; }
        public string Poste { get; set; }
        public string Coulee { get; set; }
        public int? LgtChaud { get; set; }
        public int? LgtFroid { get; set; }
        public int? PoidsUnitaire { get; set; }
        public string RetardLivraison { get; set; }
        public string AvecCop { get; set; }
        public string GrosFour { get; set; }
        public string TypeLingot { get; set; }
    }
}
