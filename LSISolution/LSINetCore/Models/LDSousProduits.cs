using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDSousProduits
    {
        public int NumeroLingot { get; set; }
        public string Coulee { get; set; }
        public int Id { get; set; }
        public decimal Longueur { get; set; }
        public int Poids { get; set; }
        public bool Rebute { get; set; }
        public int PoidsTheorique { get; set; }
        public int? EboutageTete { get; set; }
        public int? EboutagePied { get; set; }
        public decimal? LgCage900 { get; set; }
        public decimal? LgDeveloppe { get; set; }
        public bool? ProduitFini { get; set; }
        public string ProfilProduit { get; set; }
        public string NumProduit { get; set; }
        public string Parent { get; set; }
        public decimal PoidsEboutagePied { get; set; }
        public decimal PoidsEboutageTete { get; set; }
        public int? TemperatureT03 { get; set; }

        public virtual LDPso LDPso { get; set; }
    }
}
