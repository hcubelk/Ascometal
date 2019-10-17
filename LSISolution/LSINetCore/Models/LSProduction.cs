using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LSProduction
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public int JalLamT { get; set; }
        public int JalLamR { get; set; }
        public int NbTotalLgtPrevu { get; set; }
        public int NbTotalLgtLam { get; set; }
        public int DureeTotalLamPrevu { get; set; }
        public int DureeTotalLamReel { get; set; }
        public int TonChauf { get; set; }
        public int TonChaud { get; set; }
        public int TonFroid { get; set; }
        public int TonLam { get; set; }
        public int TonReb { get; set; }
        public int TonEss { get; set; }
        public int? CadenceT { get; set; }
    }
}
