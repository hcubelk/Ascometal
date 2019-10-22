using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSINetCore.Models
{
    public partial class LPConsignesSmq
    {
        [Key]
        public string Code { get; set; }
        public string Libelle { get; set; }
        public DateTime? DateMaj { get; set; }
    }
}
