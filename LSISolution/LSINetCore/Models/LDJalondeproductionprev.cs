using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDJalondeproductionprev
    {
        public int Id { get; set; }
        public string ProfilActivite { get; set; }
        public decimal? Section { get; set; }
        public string Montage { get; set; }
        public string Pso { get; set; }
        public decimal? PoidsUnitaire { get; set; }
        public int? NbLgtPrevu { get; set; }
        public int? DureeLaminageTheorique { get; set; }
        public int? CadenceTheorique { get; set; }
        public DateTime? DateMaj { get; set; }
        public string Scarfing { get; set; }
        public string LanminageControle { get; set; }
        public string DateDebutAuPlusTot { get; set; }
        public string Motif { get; set; }
        public int Poste { get; set; }
    }
}
