using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LSCapteurZoneSuivi
    {
        public string Of { get; set; }
        public string Fonction { get; set; }
        public int? Destination { get; set; }
        public int? NombrePf { get; set; }
        public string RangAcierie { get; set; }
        public string Rang { get; set; }
        public string Zone { get; set; }
        public DateTime? DateMaj { get; set; }
        public string Capteur { get; set; }
        public int? Etat { get; set; }
        public DateTime? DateCapteur { get; set; }
    }
}
