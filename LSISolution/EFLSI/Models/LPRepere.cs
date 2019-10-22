using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_REPERE")]
    public partial class LPRepere
    {
        [Key]
        [StringLength(8)]
        public string Code { get; set; }
        [Required]
        [StringLength(50)]
        public string Libelle { get; set; }
        [Column("SMQ")]
        [StringLength(50)]
        public string Smq { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
        [Required]
        [StringLength(1)]
        public string Type { get; set; }
    }
}