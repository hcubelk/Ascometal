using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDWatchdog
    {
        public string Niveau { get; set; }
        public DateTime? DateMaj { get; set; }
        public bool? Etat { get; set; }
    }
}
