using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_CONSIGNES_DECOUPE")]
    public partial class LPConsignesDecoupe
    {
        [StringLength(4)]
        public string Section { get; set; }
        public int Consignes { get; set; }
        [StringLength(12)]
        public string CodeConsigne { get; set; }
        [Required]
        public string Libelle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }

        [ForeignKey("Consignes")]
        [InverseProperty("LPConsignesDecoupe")]
        public virtual LPTypeConsigne ConsignesNavigation { get; set; }
    }
}