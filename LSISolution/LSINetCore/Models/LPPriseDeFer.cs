using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPPriseDeFer
    {
        public int Id { get; set; }
        public string Montage { get; set; }
        public string TypeProfil { get; set; }
        public int Section { get; set; }
        public int PriseDeFerHauteur { get; set; }
        public int Programme { get; set; }
        public DateTime DateMaj { get; set; }
        public int PriseDeFerEpaisseur { get; set; }
    }
}
