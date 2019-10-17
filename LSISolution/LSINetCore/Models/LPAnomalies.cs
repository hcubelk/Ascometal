using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPAnomalies
    {
        public LPAnomalies()
        {
            LDAnomalies = new HashSet<LDAnomalies>();
        }

        public int Id { get; set; }
        public int Parent { get; set; }
        public string Libelle { get; set; }

        public virtual ICollection<LDAnomalies> LDAnomalies { get; set; }
    }
}
