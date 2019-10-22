using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_SECTIONCHARGE_PITS")]
    public partial class LDSectionchargePits
    {
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [StringLength(3)]
        public string CodeOperation { get; set; }
        [Required]
        [StringLength(3)]
        public string RangOperation { get; set; }
        [Column("H2Coulee", TypeName = "decimal(2, 1)")]
        public decimal? H2coulee { get; set; }
        public int? NumeroFour1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEnfournementFour1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDefournementFour1 { get; set; }
        public int? NumeroFour2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEnfournementFour2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDefournementFour2 { get; set; }

        [ForeignKey("CodeOperation")]
        [InverseProperty("LDSectionchargePits")]
        public virtual LPTextOperations CodeOperationNavigation { get; set; }
        [ForeignKey("Of")]
        [InverseProperty("LDSectionchargePits")]
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}