using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSINetCore.Models
{
    public partial class LDOfSuivi
    {
        [Key]
        public string Of { get; set; }
        public int Rang { get; set; }

        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}
