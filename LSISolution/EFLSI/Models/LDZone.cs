using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_ZONE")]
    public partial class LDZone
    {
        [Key]
        [StringLength(10)]
        public string Zone { get; set; }
        [Required]
        [StringLength(50)]
        public string Libelle { get; set; }
        public int Id { get; set; }
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        public int? Destination { get; set; }
        [Column("PDF")]
        [StringLength(10)]
        public string Pdf { get; set; }
        [Column("NombrePDF")]
        public int? NombrePdf { get; set; }
        [Column("PF")]
        [StringLength(8)]
        public string Pf { get; set; }
        [Column("NombrePF")]
        public int? NombrePf { get; set; }
        [Column("VOR_R")]
        public bool VorR { get; set; }
        [Column("VOR_O")]
        public bool VorO { get; set; }
        [Column("VOR_V")]
        public bool VorV { get; set; }
        [StringLength(2)]
        public string NumLingotAcierie { get; set; }
        [StringLength(2)]
        public string RangLaminage { get; set; }
        public bool? Sens { get; set; }
        [StringLength(4)]
        public string RepereLingot { get; set; }
        public long? LongueurBarre { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
    }
}