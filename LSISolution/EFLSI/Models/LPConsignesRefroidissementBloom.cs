using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_CONSIGNES_REFROIDISSEMENT_BLOOM")]
    public partial class LPConsignesRefroidissementBloom
    {
        [Key]
        [StringLength(12)]
        public string CodeConsigne { get; set; }
        [Required]
        public string Libelle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
    }
}