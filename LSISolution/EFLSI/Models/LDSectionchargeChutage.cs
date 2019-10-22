using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_SECTIONCHARGE_CHUTAGE")]
    public partial class LDSectionchargeChutage
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
        public string Destination { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? ChutageTete { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? ChutagePied { get; set; }

        [ForeignKey("CodeOperation")]
        [InverseProperty("LDSectionchargeChutage")]
        public virtual LPTextOperations CodeOperationNavigation { get; set; }
        [ForeignKey("Of")]
        [InverseProperty("LDSectionchargeChutage")]
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}