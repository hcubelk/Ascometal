using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDFours
    {
        public LDFours()
        {
            LDPlansFours = new HashSet<LDPlansFours>();
        }

        public string Id { get; set; }
        public string Libelle { get; set; }
        public int NombreLingot { get; set; }
        public decimal PoidsEnfourne { get; set; }
        public DateTime? DebutDefournement { get; set; }
        public DateTime? FinEnfournement { get; set; }
        public int Seuil { get; set; }
        public int NombrePositions { get; set; }
        public bool EnfournementStandard { get; set; }
        public string OfenCours { get; set; }

        public virtual ICollection<LDPlansFours> LDPlansFours { get; set; }
    }
}
