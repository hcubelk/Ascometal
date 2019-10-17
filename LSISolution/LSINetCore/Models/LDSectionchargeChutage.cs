using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDSectionchargeChutage
    {
        public string Of { get; set; }
        public string CodeOperation { get; set; }
        public string RangOperation { get; set; }
        public string Destination { get; set; }
        public decimal? ChutageTete { get; set; }
        public decimal? ChutagePied { get; set; }

        public virtual LPTextOperations CodeOperationNavigation { get; set; }
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}
