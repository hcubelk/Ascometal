using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPCoeffdilatation
    {
        public int Temperature { get; set; }
        public double Coefficient { get; set; }
        public DateTime? DateMaj { get; set; }
    }
}
