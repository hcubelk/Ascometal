using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_ORDRE_FABRICATION")]
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
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        public int Indice { get; set; }
        public int Etat { get; set; }
        [Required]
        [StringLength(1)]
        public string Type { get; set; }
        [StringLength(6)]
        public string Coulee { get; set; }
        [Required]
        [StringLength(3)]
        public string ProfilProduit { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal DiametreProduit { get; set; }
        [Column(TypeName = "decimal(2, 1)")]
        public decimal ToleranceMaxSection { get; set; }
        [Column(TypeName = "decimal(2, 1)")]
        public decimal ToleranceMinSection { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal Epaisseur { get; set; }
        [Column(TypeName = "decimal(2, 1)")]
        public decimal ToleranceMaxEpaisseur { get; set; }
        [Column(TypeName = "decimal(2, 1)")]
        public decimal ToleranceMinEpaisseur { get; set; }
        [Required]
        [StringLength(4)]
        public string ClasseDeChute { get; set; }
        [Column("LongueurCD", TypeName = "decimal(5, 3)")]
        public decimal LongueurCd { get; set; }
        [Column(TypeName = "decimal(4, 0)")]
        public decimal ToleranceMaxLongueur { get; set; }
        [Column(TypeName = "decimal(4, 0)")]
        public decimal ToleranceMinLongueur { get; set; }
        [Required]
        [StringLength(9)]
        public string MarqueCommerciale { get; set; }
        [Required]
        [StringLength(3)]
        public string NumeroMontage { get; set; }
        [Required]
        [StringLength(4)]
        public string CodeDemiProduit { get; set; }
        [Column(TypeName = "decimal(7, 3)")]
        public decimal? PoidsDemiProduitUnitaire { get; set; }
        public int NombreDemiProduit { get; set; }
        [Required]
        [StringLength(1)]
        public string AcompteSolde { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? PoidsPrevuDemiProduit { get; set; }
        [StringLength(50)]
        public string SuiviDeZoneZone { get; set; }
        [Required]
        [StringLength(7)]
        public string Nuance { get; set; }
        [Required]
        [StringLength(13)]
        public string Client { get; set; }
        [Required]
        [StringLength(8)]
        public string NumeroFichier { get; set; }
        public string TemperatureScarfing { get; set; }
        public int? TemperatureT07 { get; set; }
        [StringLength(1)]
        public string SensLaminage { get; set; }
        [Column("SensLaminageGPAO")]
        [StringLength(1)]
        public string SensLaminageGpao { get; set; }
        public int? TemperatureT03 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateReception { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDebutLaminage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateFinLaminage { get; set; }
        [Column("DateEVC", TypeName = "datetime")]
        public DateTime? DateEvc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDebut { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateFin { get; set; }
        public int? NombreLingotsWagon1Four1 { get; set; }
        public int? NombreLingotsWagon1Four2 { get; set; }
        public int? NombreLingotsWagon2Four1 { get; set; }
        public int? NombreLingotsWagon2Four2 { get; set; }
        [Column("OFOrigine")]
        [StringLength(12)]
        public string Oforigine { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
        public int PoidsPesee { get; set; }

        [ForeignKey("Coulee")]
        [InverseProperty("LDOrdreFabrication")]
        public virtual LDCoulee CouleeNavigation { get; set; }
        [ForeignKey("ProfilProduit")]
        [InverseProperty("LDOrdreFabrication")]
        public virtual LPProfilProduit ProfilProduitNavigation { get; set; }
        [InverseProperty("OfNavigation")]
        public virtual LDOfSuivi LDOfSuivi { get; set; }
        [InverseProperty("OfNavigation")]
        public virtual ICollection<LDPlansFours> LDPlansFours { get; set; }
        [InverseProperty("OfNavigation")]
        public virtual ICollection<LDPso> LDPso { get; set; }
        [InverseProperty("OfNavigation")]
        public virtual ICollection<LDRebut> LDRebut { get; set; }
        [InverseProperty("OfNavigation")]
        public virtual ICollection<LDSectionchargeChutage> LDSectionchargeChutage { get; set; }
        [InverseProperty("OfNavigation")]
        public virtual ICollection<LDSectionchargeDecoupe> LDSectionchargeDecoupe { get; set; }
        [InverseProperty("OfNavigation")]
        public virtual ICollection<LDSectionchargeLingot> LDSectionchargeLingot { get; set; }
        [InverseProperty("OfNavigation")]
        public virtual ICollection<LDSectionchargePits> LDSectionchargePits { get; set; }
        [InverseProperty("OfNavigation")]
        public virtual ICollection<LDSectionchargePoidsmetrique> LDSectionchargePoidsmetrique { get; set; }
        [InverseProperty("OfNavigation")]
        public virtual ICollection<LDSectionchargeRefroidissoirs> LDSectionchargeRefroidissoirs { get; set; }
        [InverseProperty("OfNavigation")]
        public virtual ICollection<LDSectionchargeSvt> LDSectionchargeSvt { get; set; }
    }
}