using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPParametresGeneraux
    {
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string TypeData { get; set; }
        public string Valeur { get; set; }
        public DateTime? DateMaj { get; set; }
        public string Display { get; set; }
    }
}
