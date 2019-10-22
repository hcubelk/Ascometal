using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_CODEOUTIL_DECOUPE")]
    public partial class LPCodeoutilDecoupe
    {
        [Key]
        [StringLength(1)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Libelle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
    }
}