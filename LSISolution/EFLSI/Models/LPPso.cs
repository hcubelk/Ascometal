using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_PSO")]
    public partial class LPPso
    {
        [Key]
        [Column("CodePSO")]
        [StringLength(4)]
        public string CodePso { get; set; }
        public int Poids { get; set; }
        public int Hauteur { get; set; }
        public int Largeur { get; set; }
        public int? PoidsMetrique { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
    }
}