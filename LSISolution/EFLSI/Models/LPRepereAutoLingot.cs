using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_REPERE_AUTO_LINGOT")]
    public partial class LPRepereAutoLingot
    {
        [Column("AnomalieCOP")]
        public int AnomalieCop { get; set; }
        [StringLength(2)]
        public string Lingot { get; set; }
        [Required]
        [StringLength(2)]
        public string Reperage { get; set; }
    }
}