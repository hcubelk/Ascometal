using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDSectionchargePits
    {
        public string Of { get; set; }
        public string CodeOperation { get; set; }
        public string RangOperation { get; set; }
        public decimal? H2coulee { get; set; }
        public int? NumeroFour1 { get; set; }
        public DateTime? DateEnfournementFour1 { get; set; }
        public DateTime? DateDefournementFour1 { get; set; }
        public int? NumeroFour2 { get; set; }
        public DateTime? DateEnfournementFour2 { get; set; }
        public DateTime? DateDefournementFour2 { get; set; }

        public virtual LPTextOperations CodeOperationNavigation { get; set; }
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}
