using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPProfilProduit
    {
        public LPProfilProduit()
        {
            LDOrdreFabrication = new HashSet<LDOrdreFabrication>();
        }

        public string Id { get; set; }
        public string Libelle { get; set; }

        public virtual ICollection<LDOrdreFabrication> LDOrdreFabrication { get; set; }
    }
}
