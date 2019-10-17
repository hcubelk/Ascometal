using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPPso
    {
        public string CodePso { get; set; }
        public int Poids { get; set; }
        public int Hauteur { get; set; }
        public int Largeur { get; set; }
        public int? PoidsMetrique { get; set; }
        public DateTime? DateMaj { get; set; }
    }
}
