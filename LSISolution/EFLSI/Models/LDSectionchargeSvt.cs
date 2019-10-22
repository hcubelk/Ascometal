using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_SECTIONCHARGE_SVT")]
    public partial class LDSectionchargeSvt
    {
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [StringLength(3)]
        public string CodeOperation { get; set; }
        [Required]
        [StringLength(3)]
        public string RangOperation { get; set; }

        [ForeignKey("CodeOperation")]
        [InverseProperty("LDSectionchargeSvt")]
        public virtual LPTextOperations CodeOperationNavigation { get; set; }
        [ForeignKey("Of")]
        [InverseProperty("LDSectionchargeSvt")]
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}