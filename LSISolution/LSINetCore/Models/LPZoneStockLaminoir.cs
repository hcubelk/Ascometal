using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPZoneStockLaminoir
    {
        public LPZoneStockLaminoir()
        {
            LPLieuxStockLaminoir = new HashSet<LPLieuxStockLaminoir>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }

        public virtual ICollection<LPLieuxStockLaminoir> LPLieuxStockLaminoir { get; set; }
    }
}
