using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_CONSIGNES_DEGAZAGE_DETAIL")]
    public partial class LPConsignesDegazageDetail
    {
        public int Id { get; set; }
        public int Code { get; set; }
        [Required]
        [StringLength(3)]
        public string ProfilProduit { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? SectionMax { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? SectionMin { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal Refroidissement { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal H21 { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal H22 { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal H23 { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal H24 { get; set; }
    }
}