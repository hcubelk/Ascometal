using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LSSyntheseProductionMensuelle
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime? DateCloture { get; set; }
        public int? Hj { get; set; }
        public int? Ho { get; set; }
        public int? Hta { get; set; }
        public int? Htc { get; set; }
        public int? Htp { get; set; }
        public int? Hth { get; set; }
        public int? Hti { get; set; }
        public int? Htr { get; set; }
        public int? Htm { get; set; }
        public int? Htq { get; set; }
        public int? Htd { get; set; }
        public int? Htt { get; set; }
        public int? Htg { get; set; }
        public int? Hmb { get; set; }
        public int? Hmn { get; set; }
        public int? Hmm { get; set; }
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
