using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDMouvementStock
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string LieuParc { get; set; }
        public string LieuPits { get; set; }
        public string Pso { get; set; }
        public string Coulee { get; set; }
        public DateTime? DateMouvement { get; set; }
        public DateTime? DatePrevue { get; set; }
        public DateTime? DateDisponibilite { get; set; }
        public DateTime DateDemande { get; set; }
        public int? PoidsTotal { get; set; }
        public int? NbTotalEntres { get; set; }
        public int? NbEntres { get; set; }
        public int? NbSortis { get; set; }
        public string Observations { get; set; }
        public string Consigne { get; set; }
        public int Etat { get; set; }
    }
}
