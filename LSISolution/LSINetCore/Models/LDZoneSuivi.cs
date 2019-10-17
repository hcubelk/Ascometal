using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDZoneSuivi
    {
        public int Id { get; set; }
        public string Zone { get; set; }
        public string Of { get; set; }
        public int? Destination { get; set; }
        public string Pdf { get; set; }
        public int? NombrePdf { get; set; }
        public string Pf { get; set; }
        public int? NombrePf { get; set; }
        public bool VorR { get; set; }
        public bool VorO { get; set; }
        public bool VorV { get; set; }
        public string NumLingotAcierie { get; set; }
        public string RangLaminage { get; set; }
        public bool? Sens { get; set; }
        public string RepereLingot { get; set; }
        public long? LongueurBarre { get; set; }
        public DateTime DateMaj { get; set; }
    }
}
