using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPConsignesDegazageDetail
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string ProfilProduit { get; set; }
        public decimal? SectionMax { get; set; }
        public decimal? SectionMin { get; set; }
        public decimal Refroidissement { get; set; }
        public decimal H21 { get; set; }
        public decimal H22 { get; set; }
        public decimal H23 { get; set; }
        public decimal H24 { get; set; }
    }
}
