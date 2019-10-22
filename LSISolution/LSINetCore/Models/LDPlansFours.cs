using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSINetCore.Models
{
    public partial class LDPlansFours
    {
        [Key]
        public string FourId { get; set; }
        [Key]
        public short Position { get; set; }
        public string IdCoulee { get; set; }
        public int NumeroLingot { get; set; }
        public int TypePlan { get; set; }
        public string Of { get; set; }

        public virtual LDFours Four { get; set; }
        public virtual LDCoulee IdCouleeNavigation { get; set; }
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}
