using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDSectionchargeDecoupe
    {
        public string Of { get; set; }
        public string CodeOperation { get; set; }
        public string RangOperation { get; set; }
        public decimal? LongueurMoyenne { get; set; }
        public string OutilDeDecoupe { get; set; }

        public virtual LPTextOperations CodeOperationNavigation { get; set; }
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}
