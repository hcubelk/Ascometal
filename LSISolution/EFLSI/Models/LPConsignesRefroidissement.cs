using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_CONSIGNES_REFROIDISSEMENT")]
    public partial class LPConsignesRefroidissement
    {
        [Key]
        [StringLength(2)]
        public string Code { get; set; }
        [Required]
        [StringLength(100)]
        public string Libelle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
    }
}