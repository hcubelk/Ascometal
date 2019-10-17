using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LSProductionLsiTotal
    {
        public string Poste { get; set; }
        public decimal? PdsTotalChauffe { get; set; }
        public decimal? PdsTotalLamine { get; set; }
        public decimal? PdsTotalRebute { get; set; }
        public decimal? PdsTotalEvc { get; set; }
        public int? NbTotalChauffe { get; set; }
        public int? NbTotalLamine { get; set; }
        public int? NbTotalRebute { get; set; }
        public int? NbTotalEvc { get; set; }
        public decimal? PdsTotalFroid { get; set; }
    }
}
