using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPConsignesChutage
    {
        public string Section { get; set; }
        public int Consignes { get; set; }
        public string CodeConsigne { get; set; }
        public string Libelle { get; set; }
        public DateTime DateMaj { get; set; }

        public virtual LPTypeConsigne ConsignesNavigation { get; set; }
    }
}
