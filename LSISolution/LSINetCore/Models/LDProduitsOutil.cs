using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDProduitsOutil
    {
        public string Zone { get; set; }
        public string Of { get; set; }
        public string Ligne { get; set; }
        public DateTime? HeureArrivee { get; set; }
        public DateTime? HeureSortie { get; set; }
        public int? Nombre { get; set; }
        public string Commentaire { get; set; }
    }
}
