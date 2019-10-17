using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class AtosTrace2
    {
        public int Id { get; set; }
        public string Capteur { get; set; }
        public string Of { get; set; }
        public int? Etat { get; set; }
        public DateTime DateMaj { get; set; }
        public string Type { get; set; }
        public int? NbOk { get; set; }
        public int? NbDef { get; set; }
    }
}
