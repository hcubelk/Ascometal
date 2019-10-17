using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LSLpb
    {
        public DateTime? DateDebutLaminage { get; set; }
        public string Of { get; set; }
        public string Client { get; set; }
        public string Nuance { get; set; }
        public string Coulee { get; set; }
        public string Dim { get; set; }
        public string NumeroMontage { get; set; }
        public string AcompteSolde { get; set; }
        public string Mnt { get; set; }
        public string Inc { get; set; }
        public string Pan { get; set; }
        public string Mrc { get; set; }
        public string Arr { get; set; }
        public string CCli { get; set; }
        public string Lc { get; set; }
        public int? NbProd { get; set; }
        public decimal? PdsTotal { get; set; }
        public decimal? PdsProd { get; set; }
        public string CEnf { get; set; }
        public string CScf { get; set; }
        public DateTime? DateEnfournement { get; set; }
        public DateTime? PreDefournement { get; set; }
        public DateTime? DerDefournement { get; set; }
        public string CsgChf { get; set; }
        public int? F1 { get; set; }
        public int? NbF1 { get; set; }
        public int? F2 { get; set; }
        public int? NbF2 { get; set; }
    }
}
