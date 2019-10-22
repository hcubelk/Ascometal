using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSINetCore.Models
{
    public partial class LPCellulesMesureLongueur
    {
        [Key]
        public string Cellule { get; set; }
        public decimal Longueur { get; set; }
        public int NbImpulsions { get; set; }
        public int ToleranceMax { get; set; }
        public int ToleranceMin { get; set; }
        public DateTime? DateMaj { get; set; }
    }
}
