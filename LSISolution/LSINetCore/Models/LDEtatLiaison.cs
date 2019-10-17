using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDEtatLiaison
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string TypeLiaison { get; set; }
        public string AdresseIp { get; set; }
        public bool Etat { get; set; }
        public DateTime DateMaj { get; set; }
    }
}
