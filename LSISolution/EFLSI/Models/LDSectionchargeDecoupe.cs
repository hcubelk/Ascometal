using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_SECTIONCHARGE_DECOUPE")]
    public partial class LDSectionchargeDecoupe
    {
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [StringLength(3)]
        public string CodeOperation { get; set; }
        [Required]
        [StringLength(3)]
        public string RangOperation { get; set; }
        [Column(TypeName = "decimal(5, 3)")]
        public decimal? LongueurMoyenne { get; set; }
        [StringLength(1)]
        public string OutilDeDecoupe { get; set; }

        [ForeignKey("CodeOperation")]
        [InverseProperty("LDSectionchargeDecoupe")]
        public virtual LPTextOperations CodeOperationNavigation { get; set; }
        [ForeignKey("Of")]
        [InverseProperty("LDSectionchargeDecoupe")]
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}