using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDFonctions
    {
        public int Id { get; set; }
        public string Of { get; set; }
        public string Fonction { get; set; }
        public int? Destination { get; set; }
        public int? NombreLingot { get; set; }
        public string RangLaminage { get; set; }
        public string RangAcierie { get; set; }
        public string Pdf { get; set; }
        public int? NombrePdf { get; set; }
        public string Pf { get; set; }
        public int? NombrePf { get; set; }
        public string CelluleRecalage { get; set; }
        public DateTime DateEnvoi { get; set; }
        public string RepereLingot { get; set; }
    }
}
