using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_PRISE_DE_FER")]
    public partial class LPPriseDeFer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(3)]
        public string Montage { get; set; }
        [Required]
        [StringLength(10)]
        public string TypeProfil { get; set; }
        public int Section { get; set; }
        public int PriseDeFerHauteur { get; set; }
        public int Programme { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
        public int PriseDeFerEpaisseur { get; set; }
    }
}