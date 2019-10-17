using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDRouleaux
    {
        public int Id { get; set; }
        public string NomTable { get; set; }
        public int? Etat { get; set; }
        public DateTime? DateMaj { get; set; }
    }
}
