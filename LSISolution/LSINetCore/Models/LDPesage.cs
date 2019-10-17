using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDPesage
    {
        public int Id { get; set; }
        public DateTime? DateMaj { get; set; }
        public string Of { get; set; }
        public int NumPaquet { get; set; }
        public int? Status { get; set; }
        public int? Poids { get; set; }
        public int? PoidsDeclare { get; set; }
        public int? Etat { get; set; }
        public string Lieu { get; set; }
        public int? NbreProduit { get; set; }
        public int? TypePesee { get; set; }
    }
}
