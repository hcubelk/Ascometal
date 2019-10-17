using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPConsignesCodeoutilCoupe
    {
        public string Section { get; set; }
        public int Consignes { get; set; }
        public string CodeConsigne { get; set; }
        public string Libelle { get; set; }
        public int Longeur { get; set; }
        public int Tete { get; set; }
        public int Pied { get; set; }
        public DateTime DateMaj { get; set; }

        public virtual LPTypeConsigne ConsignesNavigation { get; set; }
    }
}
