using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_MAJ_DATE_CHECKER")]
    public partial class LDMajDateChecker
    {
        [Key]
        [StringLength(25)]
        public string Table { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
    }
}