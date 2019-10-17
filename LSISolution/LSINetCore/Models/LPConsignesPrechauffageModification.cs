using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPConsignesPrechauffageModification
    {
        public int Code { get; set; }
        public string Libelle { get; set; }
        public string Lien { get; set; }
        public string Description { get; set; }
        public DateTime DateMaj { get; set; }
    }
}
