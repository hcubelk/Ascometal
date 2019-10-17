using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPConsignesScarfing
    {
        public string Code { get; set; }
        public string TypeGaz { get; set; }
        public decimal Pression1 { get; set; }
        public decimal Pression2 { get; set; }
        public decimal Pression3 { get; set; }
        public int Vitesse1 { get; set; }
        public int Vitesse2 { get; set; }
        public int Vitesse3 { get; set; }
        public string LpLt { get; set; }
        public int MiseauMille { get; set; }
        public DateTime DateMaj { get; set; }
    }
}
