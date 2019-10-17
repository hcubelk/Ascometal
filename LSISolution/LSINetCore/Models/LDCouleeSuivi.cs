using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDCouleeSuivi
    {
        public string IdCoulee { get; set; }
        public string Nuance { get; set; }
        public int? NombreLingotBacVerniculite { get; set; }
        public int? NombreLingotPitsSec { get; set; }
        public int? NombreLingotAir { get; set; }
        public string Observations { get; set; }
        public DateTime? HeureDepartWagon1 { get; set; }
        public DateTime? HeureDepartWagon2 { get; set; }
        public DateTime? HeureArriveeWagon1 { get; set; }
        public DateTime? HeureArriveeWagon2 { get; set; }
        public bool? SaturationPits { get; set; }
        public bool? EstEnfournementStandard { get; set; }
        public bool? Degazee { get; set; }
        public bool? EstConformiteCoulee { get; set; }
        public bool? EstTroisQuartsConforme { get; set; }
        public int? ModeElaboration { get; set; }
        public string TypeLingot1 { get; set; }
        public int? PoidsUnitaireLingot1 { get; set; }
        public int? NombreTypelingot1 { get; set; }
        public string TypeLingot2 { get; set; }
        public int? PoidsUnitaireLingot2 { get; set; }
        public int? NombreTypelingot2 { get; set; }
        public string NumerosLingotRebutes { get; set; }
        public int NbLingotRestantArefroidir { get; set; }
        public string Piscinage { get; set; }
        public bool? AnomaliesCoulee { get; set; }
        public bool? AnomaliesDemoulage { get; set; }
        public bool? AnomaliesDegazeur { get; set; }
        public int? PoidsMoyenLingotMere1 { get; set; }
        public int? PoidsMoyenLingotMere2 { get; set; }
        public int? PoidsMoyenLingotMere3 { get; set; }
        public int? PoidsMoyenLingotMere4 { get; set; }
        public decimal? DensiteCoulee { get; set; }
        public string ProgrammeSmq { get; set; }
        public decimal? Hydrogene { get; set; }
        public bool? EstHomogene { get; set; }
        public string OperateurDegazeur { get; set; }
        public string OperateurCoulee { get; set; }
        public string OperateurDemoulage { get; set; }
        public DateTime? DebutCoulee { get; set; }
        public DateTime? DebutDemoulage { get; set; }
        public DateTime? FinCoulee { get; set; }
        public DateTime? FinDemDernierLgtWagon1 { get; set; }
        public DateTime? FinDemDernierLgtWagon2 { get; set; }
        public DateTime? DelaisLivraisonWagon1 { get; set; }
        public DateTime? DelaisLivraisonWagon2 { get; set; }
        public DateTime? EcartWagon1 { get; set; }
        public DateTime? EcartWagon2 { get; set; }
        public bool? PiscinageWagon1 { get; set; }
        public bool? PiscinageWagon2 { get; set; }
        public bool? SauvetageWagon1 { get; set; }
        public bool? SauvetageWagon2 { get; set; }
        public DateTime? ArriveeEnfournementWagon1 { get; set; }
        public DateTime? ArriveeEnfournementWagon2 { get; set; }
        public bool? LingotPiscine { get; set; }
        public bool? CouleeFroide { get; set; }
        public bool? MarqueFroide { get; set; }
        public int? NombreLingotsWagon1 { get; set; }
        public int? NombreLingotsWagon2 { get; set; }
        public DateTime DateReception { get; set; }
        public int EtatReception { get; set; }
        public string CodeLivraison { get; set; }
        public DateTime DerniereModif { get; set; }
        public string RetardLivraisonWagon1 { get; set; }
        public string RetardLivraisonWagon2 { get; set; }
        public bool? RetardDemoulage { get; set; }
        public DateTime? DateCopdemoulage { get; set; }
        public DateTime? DateCopcoulee { get; set; }
        public DateTime? HeurePrevuDemoulage { get; set; }
        public string ResponsableTraitement { get; set; }
        public bool? AnomalieApcrh { get; set; }
        public bool? AnomalieApc { get; set; }
        public bool? AnomalieRh { get; set; }
        public DateTime? DateCopapc { get; set; }
        public string Observation2 { get; set; }
        public string Enregistrement { get; set; }
        public DateTime? DateCoprh { get; set; }
        public bool Externe { get; set; }
    }
}
