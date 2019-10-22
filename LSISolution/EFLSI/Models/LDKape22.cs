using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_KAPE22")]
    public partial class LDKape22
    {
        public int Id { get; set; }
        [Required]
        public string NumeroFichier { get; set; }
        [Required]
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        public int Indice { get; set; }
        [Required]
        [StringLength(1)]
        public string Type { get; set; }
        [Required]
        [StringLength(6)]
        public string Coulee { get; set; }
        [StringLength(3)]
        public string ProfilProduit { get; set; }
        public int? DiametreProduit { get; set; }
        public int? ToleranceMaxSection { get; set; }
        public int? ToleranceMinSection { get; set; }
        public int? Epaisseur { get; set; }
        public int? ToleranceMaxEpaisseur { get; set; }
        public int? ToleranceMinEpaisseur { get; set; }
        [StringLength(4)]
        public string ClasseDeChute { get; set; }
        [Column("LongueurCD")]
        public int? LongueurCd { get; set; }
        public int? ToleranceMaxLongueur { get; set; }
        public int? ToleranceMinLongueur { get; set; }
        [StringLength(9)]
        public string MarqueCommerciale { get; set; }
        [StringLength(3)]
        public string NumeroMontage { get; set; }
        [StringLength(4)]
        public string CodeDemiProduit { get; set; }
        public int? PoidsDemiProduitUnitaire { get; set; }
        public int? NombreDemiProduit { get; set; }
        [StringLength(1)]
        public string AcompteSolde { get; set; }
        public int? PoidsPrevuDemiProduit { get; set; }
        [StringLength(3)]
        public string RangOpePits { get; set; }
        [StringLength(3)]
        public string CodeOpePits { get; set; }
        [StringLength(18)]
        public string LibelleConsignePits { get; set; }
        [StringLength(12)]
        public string CodeConsignePits { get; set; }
        [Column("H2Coulee")]
        public int? H2coulee { get; set; }
        public int? NumeroFour1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEnfournementFour1 { get; set; }
        public int? NumeroFour2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateEnfournementFour2 { get; set; }
        [StringLength(3)]
        public string RangOpeLingot { get; set; }
        [StringLength(3)]
        public string CodeOpeLingot { get; set; }
        [StringLength(12)]
        public string CodeConsigneLingot { get; set; }
        [StringLength(18)]
        public string LibelleConsigneLingot { get; set; }
        [StringLength(1)]
        public string ProfileLamine { get; set; }
        public int? SectionLaminage { get; set; }
        public int? ToleranceMaxSection1 { get; set; }
        public int? ToleranceMinSection1 { get; set; }
        public int? EpaisseurEnLaminage { get; set; }
        public int? ToleranceMaxEpaisseur1 { get; set; }
        public int? ToleranceMinEpaisseur1 { get; set; }
        public int? PriseDeFer { get; set; }
        [StringLength(3)]
        public string CodeOpeChutage { get; set; }
        [StringLength(3)]
        public string RangOpeChutage { get; set; }
        [StringLength(12)]
        public string CodeConsigneChutage { get; set; }
        [StringLength(18)]
        public string LibelleConsigneChutage { get; set; }
        [StringLength(1)]
        public string Destination { get; set; }
        public int? ChutageTete { get; set; }
        public int? ChutagePied { get; set; }
        [StringLength(3)]
        public string CodeOpeDecoupe { get; set; }
        [StringLength(3)]
        public string RangOpeDecoupe { get; set; }
        [StringLength(12)]
        public string CodeConsigneDecoupe { get; set; }
        [StringLength(18)]
        public string LibelleConsigneDecoupe { get; set; }
        [StringLength(1)]
        public string OutilDecoupe { get; set; }
        public int? LongueurMoyenne { get; set; }
        [StringLength(3)]
        public string CodeOpePoidMetrique { get; set; }
        [StringLength(3)]
        public string RangOpePoidMetrique { get; set; }
        [StringLength(12)]
        public string CodeConsignePoidMetrique { get; set; }
        [StringLength(18)]
        public string LibelleConsignePoidMetrique { get; set; }
        [StringLength(3)]
        public string CodeOpeRefroidissoir { get; set; }
        [StringLength(3)]
        public string RangOpeRefroidissoir { get; set; }
        [StringLength(12)]
        public string CodeConsigneRefroidissoir { get; set; }
        [StringLength(18)]
        public string LibelleConsigneRefroidissoir { get; set; }
        public int? MatriculeClient { get; set; }
        [StringLength(8)]
        public string RefroidissementBloom { get; set; }
        public int? NombreLingotsFour1 { get; set; }
        public int? NombreLingotsFour2 { get; set; }
        [Column("OFOrigin")]
        [StringLength(12)]
        public string Oforigin { get; set; }
        [Column("OFDestination")]
        [StringLength(12)]
        public string Ofdestination { get; set; }
        [Column("OForiginInterne")]
        [StringLength(12)]
        public string OforiginInterne { get; set; }
        [Column("OFDestinationInterne")]
        [StringLength(12)]
        public string OfdestinationInterne { get; set; }
        [StringLength(6)]
        public string NuanceMarquage { get; set; }
        [StringLength(3)]
        public string GazScarfing { get; set; }
        [StringLength(3)]
        public string OxygeneSuperieur { get; set; }
        [StringLength(3)]
        public string OxygeneInferieur { get; set; }
        [StringLength(3)]
        public string OxygeneLatent { get; set; }
        [StringLength(2)]
        public string VitesseV1 { get; set; }
        [StringLength(2)]
        public string VitesseV2 { get; set; }
        [StringLength(2)]
        public string VitesseV3 { get; set; }
        [StringLength(2)]
        public string LongueurScarfingPied { get; set; }
        [StringLength(2)]
        public string LongueurScarfingTete { get; set; }
        [StringLength(4)]
        public string MiseAuMille { get; set; }
        [Column("CodeOpeSVT")]
        [StringLength(3)]
        public string CodeOpeSvt { get; set; }
        [Column("RangOpeSVT")]
        [StringLength(3)]
        public string RangOpeSvt { get; set; }
        [Column("CodeConsigneSVT")]
        [StringLength(12)]
        public string CodeConsigneSvt { get; set; }
        [Column("LibelleConsigneSVT")]
        [StringLength(18)]
        public string LibelleConsigneSvt { get; set; }
        [Required]
        [StringLength(7)]
        public string Nuance { get; set; }
        [Required]
        [StringLength(13)]
        public string Client { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateReception { get; set; }
    }
}