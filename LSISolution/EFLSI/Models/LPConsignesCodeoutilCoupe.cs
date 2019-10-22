using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_CONSIGNES_CODEOUTIL_COUPE")]
    public partial class LPConsignesCodeoutilCoupe
    {
        [StringLength(4)]
        public string Section { get; set; }
        public int Consignes { get; set; }
        [StringLength(12)]
        public string CodeConsigne { get; set; }
        [Required]
        public string Libelle { get; set; }
        public int Longeur { get; set; }
        public int Tete { get; set; }
        public int Pied { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }

        [ForeignKey("Consignes")]
        [InverseProperty("LPConsignesCodeoutilCoupe")]
        public virtual LPTypeConsigne ConsignesNavigation { get; set; }
    }
}