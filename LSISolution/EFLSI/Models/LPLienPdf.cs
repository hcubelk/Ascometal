using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_LIEN_PDF")]
    public partial class LPLienPdf
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Code { get; set; }
        [StringLength(250)]
        public string Lien { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
    }
}