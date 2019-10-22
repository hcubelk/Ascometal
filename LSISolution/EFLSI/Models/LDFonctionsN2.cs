using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_FONCTIONS_N2")]
    public partial class LDFonctionsN2
    {
        public int Id { get; set; }
        [Required]
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [Required]
        [StringLength(5)]
        public string Fonction { get; set; }
        public int? Destination { get; set; }
        public int? NombreLingot { get; set; }
        [StringLength(2)]
        public string RangLaminage { get; set; }
        [StringLength(2)]
        public string RangAcierie { get; set; }
        [Column("PDF")]
        [StringLength(8)]
        public string Pdf { get; set; }
        [Column("NombrePDF")]
        public int? NombrePdf { get; set; }
        [Column("PF")]
        [StringLength(8)]
        public string Pf { get; set; }
        [StringLength(4)]
        public string RepereLingot { get; set; }
        [Column("NombrePF")]
        public int? NombrePf { get; set; }
        [StringLength(10)]
        public string CelluleRecalage { get; set; }
        [Column("Date_Envoi", TypeName = "datetime")]
        public DateTime DateEnvoi { get; set; }
    }
}