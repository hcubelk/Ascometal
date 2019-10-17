using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDAnomalies
    {
        public int Id { get; set; }
        public string IdCoulee { get; set; }
        public string Reperage { get; set; }
        public string Lingots { get; set; }
        public string Action { get; set; }
        public string Detail { get; set; }
        public bool? Anomalie { get; set; }
        public bool? PriseEnCompte { get; set; }
        public bool? Visualiser { get; set; }
        public string Enregistrement { get; set; }
        public DateTime? DerniereModif { get; set; }

        public virtual LDCoulee IdCouleeNavigation { get; set; }
        public virtual LPAnomalies IdNavigation { get; set; }
    }
}
