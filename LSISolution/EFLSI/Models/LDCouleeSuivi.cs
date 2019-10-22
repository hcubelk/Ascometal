using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_COULEE_SUIVI")]
    public partial class LDCouleeSuivi
    {
        [Key]
        [StringLength(6)]
        public string IdCoulee { get; set; }
        [Required]
        [StringLength(7)]
        public string Nuance { get; set; }
        public int? NombreLingotBacVerniculite { get; set; }
        public int? NombreLingotPitsSec { get; set; }
        public int? NombreLingotAir { get; set; }
        public string Observations { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HeureDepartWagon1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HeureDepartWagon2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HeureArriveeWagon1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HeureArriveeWagon2 { get; set; }
        public bool? SaturationPits { get; set; }
        public bool? EstEnfournementStandard { get; set; }
        public bool? Degazee { get; set; }
        public bool? EstConformiteCoulee { get; set; }
        public bool? EstTroisQuartsConforme { get; set; }
        public int? ModeElaboration { get; set; }
        [StringLength(4)]
        public string TypeLingot1 { get; set; }
        public int? PoidsUnitaireLingot1 { get; set; }
        public int? NombreTypelingot1 { get; set; }
        [StringLength(4)]
        public string TypeLingot2 { get; set; }
        public int? PoidsUnitaireLingot2 { get; set; }
        public int? NombreTypelingot2 { get; set; }
        public string NumerosLingotRebutes { get; set; }
        [Column("NbLingotRestantARefroidir")]
        public int NbLingotRestantArefroidir { get; set; }
        public string Piscinage { get; set; }
        public bool? AnomaliesCoulee { get; set; }
        public bool? AnomaliesDemoulage { get; set; }
        public bool? AnomaliesDegazeur { get; set; }
        public int? PoidsMoyenLingotMere1 { get; set; }
        public int? PoidsMoyenLingotMere2 { get; set; }
        public int? PoidsMoyenLingotMere3 { get; set; }
        public int? PoidsMoyenLingotMere4 { get; set; }
        [Column(TypeName = "decimal(5, 3)")]
        public decimal? DensiteCoulee { get; set; }
        [Column("ProgrammeSMQ")]
        [StringLength(3)]
        public string ProgrammeSmq { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? Hydrogene { get; set; }
        public bool? EstHomogene { get; set; }
        [StringLength(10)]
        public string OperateurDegazeur { get; set; }
        [StringLength(10)]
        public string OperateurCoulee { get; set; }
        [StringLength(10)]
        public string OperateurDemoulage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DebutCoulee { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DebutDemoulage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinCoulee { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinDemDernierLgtWagon1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinDemDernierLgtWagon2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DelaisLivraisonWagon1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DelaisLivraisonWagon2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EcartWagon1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EcartWagon2 { get; set; }
        public bool? PiscinageWagon1 { get; set; }
        public bool? PiscinageWagon2 { get; set; }
        public bool? SauvetageWagon1 { get; set; }
        public bool? SauvetageWagon2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ArriveeEnfournementWagon1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ArriveeEnfournementWagon2 { get; set; }
        public bool? LingotPiscine { get; set; }
        public bool? CouleeFroide { get; set; }
        public bool? MarqueFroide { get; set; }
        public int? NombreLingotsWagon1 { get; set; }
        public int? NombreLingotsWagon2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateReception { get; set; }
        public int EtatReception { get; set; }
        [StringLength(10)]
        public string CodeLivraison { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DerniereModif { get; set; }
        public string RetardLivraisonWagon1 { get; set; }
        public string RetardLivraisonWagon2 { get; set; }
        public bool? RetardDemoulage { get; set; }
        [Column("DateCOPDemoulage", TypeName = "datetime")]
        public DateTime? DateCopdemoulage { get; set; }
        [Column("DateCOPCoulee", TypeName = "datetime")]
        public DateTime? DateCopcoulee { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HeurePrevuDemoulage { get; set; }
        [StringLength(30)]
        public string ResponsableTraitement { get; set; }
        [Column("AnomalieAPCRH")]
        public bool? AnomalieApcrh { get; set; }
        [Column("AnomalieAPC")]
        public bool? AnomalieApc { get; set; }
        [Column("AnomalieRH")]
        public bool? AnomalieRh { get; set; }
        [Column("DateCOPAPC", TypeName = "datetime")]
        public DateTime? DateCopapc { get; set; }
        [StringLength(100)]
        public string Observation2 { get; set; }
        [StringLength(3)]
        public string Enregistrement { get; set; }
        [Column("DateCOPRH", TypeName = "datetime")]
        public DateTime? DateCoprh { get; set; }
        public bool Externe { get; set; }
    }
}