using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDOfSuivi
    {
        public string Of { get; set; }
        public int Rang { get; set; }

        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}
