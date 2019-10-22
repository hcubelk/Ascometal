using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_SECTIONCHARGE_REFROIDISSOIRS")]
    public partial class LDSectionchargeRefroidissoirs
    {
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [StringLength(3)]
        public string CodeOperation { get; set; }
        [Required]
        [StringLength(3)]
        public string RangOperation { get; set; }
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
        [Column("OFInterne")]
        [StringLength(12)]
        public string Ofinterne { get; set; }
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
        [StringLength(4)]
        public string VitesseV1 { get; set; }
        [StringLength(4)]
        public string VitesseV2 { get; set; }
        [StringLength(4)]
        public string VitesseV3 { get; set; }
        [StringLength(2)]
        public string LongueurScarfingPied { get; set; }
        [StringLength(2)]
        public string LongueurScarfingTete { get; set; }
        [StringLength(4)]
        public string MiseAuMille { get; set; }

        [ForeignKey("CodeOperation")]
        [InverseProperty("LDSectionchargeRefroidissoirs")]
        public virtual LPTextOperations CodeOperationNavigation { get; set; }
        [ForeignKey("Of")]
        [InverseProperty("LDSectionchargeRefroidissoirs")]
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}