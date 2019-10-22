using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSINetCore.Models
{
    public partial class LDFourAcier
    {
        [Key]
        public string Coulee { get; set; }
        public string Nuance { get; set; }
        public string Phase { get; set; }
        public string Energie { get; set; }
        public string Etat { get; set; }
        public string DateArret { get; set; }
        public string DureeArret { get; set; }
        public string DateMaj { get; set; }
    }
}
