using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LSINetCore.Models
{
    public partial class LDSectionchargePoidsmetrique
    {
        [Key]
        public string Of { get; set; }
        [Key]
        public string CodeOperation { get; set; }
        public string RangOperation { get; set; }

        public virtual LPTextOperations CodeOperationNavigation { get; set; }
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}
