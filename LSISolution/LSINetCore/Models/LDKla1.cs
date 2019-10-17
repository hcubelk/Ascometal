using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDKla1
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public int Delai { get; set; }
        public string Nuance { get; set; }
        public string Client { get; set; }
        public string Of { get; set; }
        public string CodeDemiProduit { get; set; }
        public int Montage { get; set; }
        public int NombreLingotsChaud { get; set; }
        public int NombreLingotsFroid { get; set; }
        public string Pofil { get; set; }
        public int Dimension { get; set; }
        public bool Refroidissement { get; set; }
        public int Pits { get; set; }
        public string Observations { get; set; }
        public string Verif { get; set; }
        public DateTime DateReception { get; set; }
    }
}
