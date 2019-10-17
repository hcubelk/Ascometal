using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDHistoCages
    {
        public int Id { get; set; }
        public string NumCage { get; set; }
        public int TypeCage { get; set; }
        public string NumCylInferieur { get; set; }
        public decimal DiametreInferieur { get; set; }
        public string NumCylSuperieur { get; set; }
        public decimal DiametreSuperieur { get; set; }
        public int Tonnage { get; set; }
        public int TonnageUsinage { get; set; }
        public int TonnageMaximum { get; set; }
        public int? TonnageVie { get; set; }
        public DateTime? DateMiseEnService { get; set; }
        public DateTime? DateMiseHorsService { get; set; }
        public DateTime? DateUsinage { get; set; }
    }
}
