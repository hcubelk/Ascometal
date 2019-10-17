using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPConsignesMarquage
    {
        public string Section { get; set; }
        public int Consignes { get; set; }
        public string CodeConsigne { get; set; }
        public DateTime DateMaj { get; set; }
        public string Type { get; set; }
        public string LibelleSection { get; set; }
        public string LibelleTete { get; set; }
        public string LibellePied { get; set; }

        public virtual LPTypeConsigne ConsignesNavigation { get; set; }
    }
}
