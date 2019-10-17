using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPRepere
    {
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Smq { get; set; }
        public DateTime DateMaj { get; set; }
        public string Type { get; set; }
    }
}
