using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_CONSIGNES_MARQUAGE")]
    public partial class LPConsignesMarquage
    {
        [StringLength(4)]
        public string Section { get; set; }
        public int Consignes { get; set; }
        [StringLength(12)]
        public string CodeConsigne { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        [Column("Libelle_Section")]
        public string LibelleSection { get; set; }
        [Required]
        [Column("Libelle_Tete")]
        public string LibelleTete { get; set; }
        [Required]
        [Column("Libelle_Pied")]
        public string LibellePied { get; set; }

        [ForeignKey("Consignes")]
        [InverseProperty("LPConsignesMarquage")]
        public virtual LPTypeConsigne ConsignesNavigation { get; set; }
    }
}