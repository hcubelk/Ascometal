using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_CELLULES_MESURE_LONGUEUR")]
    public partial class LPCellulesMesureLongueur
    {
        [Key]
        [StringLength(5)]
        public string Cellule { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Longueur { get; set; }
        public int NbImpulsions { get; set; }
        public int ToleranceMax { get; set; }
        public int ToleranceMin { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
    }
}