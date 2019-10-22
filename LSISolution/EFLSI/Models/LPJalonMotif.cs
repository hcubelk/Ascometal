using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_JALON_MOTIF")]
    public partial class LPJalonMotif
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string MotifJalon { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
    }
}