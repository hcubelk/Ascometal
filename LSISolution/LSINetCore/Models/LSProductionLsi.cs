using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LSProductionLsi
    {
        public string Of { get; set; }
        public DateTime? DateDebutLaminage { get; set; }
        public DateTime? DateFinLaminage { get; set; }
        public string DureeLaminage { get; set; }
        public DateTime? DateDebutOf { get; set; }
        public DateTime? DateFinOf { get; set; }
        public DateTime? DateEvc { get; set; }
        public string DureeOf { get; set; }
        public string DureeChauffe { get; set; }
        public string Client { get; set; }
        public string Nuance { get; set; }
        public string Coulee { get; set; }
        public string NumeroMontage { get; set; }
        public string Dimension { get; set; }
        public string Destination { get; set; }
        public string CouleeFroide { get; set; }
        public string As { get; set; }
        public decimal? PoidsChauffe { get; set; }
        public int? NombreChauffe { get; set; }
        public decimal? PoidsLamine { get; set; }
        public int? NombreLamine { get; set; }
        public decimal? PoidsRebute { get; set; }
        public int? NombreRebute { get; set; }
        public string Equipe { get; set; }
        public decimal? PoidsEvc { get; set; }
        public int? NombreEvc { get; set; }
        public int? NumeroF1 { get; set; }
        public int? NombreF1 { get; set; }
        public int? NumeroF2 { get; set; }
        public int? NombreF2 { get; set; }
        public string CodeOpePits { get; set; }
        public string CodeConsPits { get; set; }
        public string ProfilProduit { get; set; }
        public decimal? DiametreProduit { get; set; }
        public decimal? PoidsDemiProduitUnitaire { get; set; }
        public int? NombreDemiProduit { get; set; }
        public decimal? PoidsPrevuDemiProduit { get; set; }
        public DateTime? DateEnfournement { get; set; }
        public DateTime? DateDefournement { get; set; }
        public int? Poids { get; set; }
        public int? Etat { get; set; }
        public int? RangPasssageAuLaminoir { get; set; }
        public string CodeScarf { get; set; }
        public decimal? Thlamine { get; set; }
    }
}
