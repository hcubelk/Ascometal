using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_WATCHDOG")]
    public partial class LDWatchdog
    {
        [Key]
        [StringLength(15)]
        public string Niveau { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
        public bool? Etat { get; set; }
    }
}