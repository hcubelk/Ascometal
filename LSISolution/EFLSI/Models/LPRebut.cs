using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_REBUT")]
    public partial class LPRebut
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string Code { get; set; }
        [Required]
        public string Libelle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
    }
}