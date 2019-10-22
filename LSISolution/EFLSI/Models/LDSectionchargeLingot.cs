using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_SECTIONCHARGE_LINGOT")]
    public partial class LDSectionchargeLingot
    {
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [StringLength(3)]
        public string CodeOperation { get; set; }
        [Required]
        [StringLength(3)]
        public string RangOperation { get; set; }
        [StringLength(1)]
        public string ProfileLamine { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? SectionLaminage { get; set; }
        [Column(TypeName = "decimal(2, 1)")]
        public decimal? ToleranceMaxSection { get; set; }
        [Column(TypeName = "decimal(2, 1)")]
        public decimal? ToleranceMinSection { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? EpaisseurEnLaminage { get; set; }
        [Column(TypeName = "decimal(2, 1)")]
        public decimal? ToleranceMaxEpaisseur { get; set; }
        [Column(TypeName = "decimal(2, 1)")]
        public decimal? ToleranceMinEpaisseur { get; set; }
        public int? PriseDeFer { get; set; }
        public int? Programme { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? PriseDeFerHauteur { get; set; }
        public int? PriseDeFerSection { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? PriseDeFerEpaisseur { get; set; }
        [Column("ProgrammeGPAO")]
        public int? ProgrammeGpao { get; set; }
        [Column("PriseDeFerHauteurGPAO", TypeName = "decimal(4, 1)")]
        public decimal? PriseDeFerHauteurGpao { get; set; }
        [Column("PriseDeFerSectionGPAO")]
        public int? PriseDeFerSectionGpao { get; set; }
        [Column("PriseDeFerEpaisseurGPAO", TypeName = "decimal(4, 1)")]
        public decimal? PriseDeFerEpaisseurGpao { get; set; }

        [ForeignKey("CodeOperation")]
        [InverseProperty("LDSectionchargeLingot")]
        public virtual LPTextOperations CodeOperationNavigation { get; set; }
        [ForeignKey("Of")]
        [InverseProperty("LDSectionchargeLingot")]
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}