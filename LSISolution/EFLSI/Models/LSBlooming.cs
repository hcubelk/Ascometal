using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_S_BLOOMING")]
    public partial class LSBlooming
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("OF")]
        public string Of { get; set; }
        [Required]
        public string NumLingot { get; set; }
        [Required]
        public string Profil { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? Section { get; set; }
        [Required]
        public string Montage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TopDebutLaminage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TopFinLaminage { get; set; }
        public int? CadenceT { get; set; }
        [Column(TypeName = "decimal(10, 3)")]
        public decimal? Poids { get; set; }
        [StringLength(1)]
        public string Scarfing { get; set; }
        [StringLength(3)]
        public string LaminageControle { get; set; }
        [Required]
        [Column("IsOFEssai")]
        public bool? IsOfessai { get; set; }
        [Required]
        public bool? IsCouleeChaude { get; set; }
    }
}