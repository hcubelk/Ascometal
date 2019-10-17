using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDSectionchargeRefroidissoirs
    {
        public string Of { get; set; }
        public string CodeOperation { get; set; }
        public string RangOperation { get; set; }
        public int? MatriculeClient { get; set; }
        public string RefroidissementBloom { get; set; }
        public int? NombreLingotsFour1 { get; set; }
        public int? NombreLingotsFour2 { get; set; }
        public string Oforigin { get; set; }
        public string Ofdestination { get; set; }
        public string Ofinterne { get; set; }
        public string NuanceMarquage { get; set; }
        public string GazScarfing { get; set; }
        public string OxygeneSuperieur { get; set; }
        public string OxygeneInferieur { get; set; }
        public string OxygeneLatent { get; set; }
        public string VitesseV1 { get; set; }
        public string VitesseV2 { get; set; }
        public string VitesseV3 { get; set; }
        public string LongueurScarfingPied { get; set; }
        public string LongueurScarfingTete { get; set; }
        public string MiseAuMille { get; set; }

        public virtual LPTextOperations CodeOperationNavigation { get; set; }
        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}
