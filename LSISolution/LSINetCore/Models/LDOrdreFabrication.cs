using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSINetCore.Models
{
    public partial class LDOrdreFabrication
    {
        public LDOrdreFabrication()
        {
            LDPlansFours = new HashSet<LDPlansFours>();
            LDPso = new HashSet<LDPso>();
            LDRebut = new HashSet<LDRebut>();
            LDSectionchargeChutage = new HashSet<LDSectionchargeChutage>();
            LDSectionchargeDecoupe = new HashSet<LDSectionchargeDecoupe>();
            LDSectionchargeLingot = new HashSet<LDSectionchargeLingot>();
            LDSectionchargePits = new HashSet<LDSectionchargePits>();
            LDSectionchargePoidsmetrique = new HashSet<LDSectionchargePoidsmetrique>();
            LDSectionchargeRefroidissoirs = new HashSet<LDSectionchargeRefroidissoirs>();
            LDSectionchargeSvt = new HashSet<LDSectionchargeSvt>();
        }
        [Key]
        public string Of { get; set; }
        public int Indice { get; set; }
        public int Etat { get; set; }
        public string Type { get; set; }
        public string Coulee { get; set; }
        public string ProfilProduit { get; set; }
        public decimal DiametreProduit { get; set; }
        public decimal ToleranceMaxSection { get; set; }
        public decimal ToleranceMinSection { get; set; }
        public decimal Epaisseur { get; set; }
        public decimal ToleranceMaxEpaisseur { get; set; }
        public decimal ToleranceMinEpaisseur { get; set; }
        public string ClasseDeChute { get; set; }
        public decimal LongueurCd { get; set; }
        public decimal ToleranceMaxLongueur { get; set; }
        public decimal ToleranceMinLongueur { get; set; }
        public string MarqueCommerciale { get; set; }
        public string NumeroMontage { get; set; }
        public string CodeDemiProduit { get; set; }
        public decimal? PoidsDemiProduitUnitaire { get; set; }
        public int NombreDemiProduit { get; set; }
        public string AcompteSolde { get; set; }
        public decimal? PoidsPrevuDemiProduit { get; set; }
        public string SuiviDeZoneZone { get; set; }
        public string Nuance { get; set; }
        public string Client { get; set; }
        public string NumeroFichier { get; set; }
        public string TemperatureScarfing { get; set; }
        public int? TemperatureT07 { get; set; }
        public string SensLaminage { get; set; }
        public string SensLaminageGpao { get; set; }
        public int? TemperatureT03 { get; set; }
        public DateTime DateReception { get; set; }
        public DateTime? DateDebutLaminage { get; set; }
        public DateTime? DateFinLaminage { get; set; }
        public DateTime? DateEvc { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public int? NombreLingotsWagon1Four1 { get; set; }
        public int? NombreLingotsWagon1Four2 { get; set; }
        public int? NombreLingotsWagon2Four1 { get; set; }
        public int? NombreLingotsWagon2Four2 { get; set; }
        public string Oforigine { get; set; }
        public DateTime DateMaj { get; set; }
        public int PoidsPesee { get; set; }

        public virtual LDCoulee CouleeNavigation { get; set; }
        public virtual LPProfilProduit ProfilProduitNavigation { get; set; }
        public virtual LDOfSuivi LDOfSuivi { get; set; }
        public virtual ICollection<LDPlansFours> LDPlansFours { get; set; }
        public virtual ICollection<LDPso> LDPso { get; set; }
        public virtual ICollection<LDRebut> LDRebut { get; set; }
        public virtual ICollection<LDSectionchargeChutage> LDSectionchargeChutage { get; set; }
        public virtual ICollection<LDSectionchargeDecoupe> LDSectionchargeDecoupe { get; set; }
        public virtual ICollection<LDSectionchargeLingot> LDSectionchargeLingot { get; set; }
        public virtual ICollection<LDSectionchargePits> LDSectionchargePits { get; set; }
        public virtual ICollection<LDSectionchargePoidsmetrique> LDSectionchargePoidsmetrique { get; set; }
        public virtual ICollection<LDSectionchargeRefroidissoirs> LDSectionchargeRefroidissoirs { get; set; }
        public virtual ICollection<LDSectionchargeSvt> LDSectionchargeSvt { get; set; }
        
    }
}
