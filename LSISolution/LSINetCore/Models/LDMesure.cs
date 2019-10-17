using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDMesure
    {
        public int Id { get; set; }
        public string Of { get; set; }
        public string Pdf { get; set; }
        public long? LongueurBarre { get; set; }
        public long? CompteurDd8 { get; set; }
        public long? CompteurDd9 { get; set; }
        public long? CompteurDd9b { get; set; }
        public long? CompteurDd10 { get; set; }
        public long? CompteurDd11a { get; set; }
        public long? CompteurDd11b { get; set; }
        public long? CompteurDd12 { get; set; }
        public long? CompteurDd12b { get; set; }
        public long? CompteurDd13 { get; set; }
        public long? CompteurDd14 { get; set; }
        public long? CompteurDe1 { get; set; }
        public long? CompteurDd15 { get; set; }
        public long? CompteurDe2a { get; set; }
        public long? CompteurDe2b { get; set; }
        public long? CompteurTotal { get; set; }
        public DateTime? Date { get; set; }
    }
}
