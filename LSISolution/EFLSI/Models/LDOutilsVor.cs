using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_OUTILS_VOR")]
    public partial class LDOutilsVor
    {
        [StringLength(50)]
        public string Zone { get; set; }
        [Column("Date_Envoi", TypeName = "datetime")]
        public DateTime DateEnvoi { get; set; }
        [Required]
        public string Code { get; set; }
        [Column("VOR")]
        public int Vor { get; set; }
        [Required]
        public string Commentaires { get; set; }
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
    }
}