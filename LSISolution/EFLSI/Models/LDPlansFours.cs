using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_PLANS_FOURS")]
    public partial class LDPlansFours
    {
        [StringLength(3)]
        public string FourId { get; set; }
        public short Position { get; set; }
        [StringLength(6)]
        public string IdCoulee { get; set; }
        public int NumeroLingot { get; set; }
        public int TypePlan { get; set; }
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }

        [ForeignKey("FourId")]
        [InverseProperty("LDPlansFours")]
        public virtual LDFours Four { get; set; }
        [ForeignKey("IdCoulee")]
        [InverseProperty("LDPlansFours")]
        public virtual LDCoulee IdCouleeNavigation { get; set; }
        [ForeignKey("Of")]
        [InverseProperty("LDPlansFours")]
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}