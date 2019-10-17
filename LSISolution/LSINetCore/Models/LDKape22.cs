﻿using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDKape22
    {
        public int Id { get; set; }
        public string NumeroFichier { get; set; }
        public string Of { get; set; }
        public int Indice { get; set; }
        public string Type { get; set; }
        public string Coulee { get; set; }
        public string ProfilProduit { get; set; }
        public int? DiametreProduit { get; set; }
        public int? ToleranceMaxSection { get; set; }
        public int? ToleranceMinSection { get; set; }
        public int? Epaisseur { get; set; }
        public int? ToleranceMaxEpaisseur { get; set; }
        public int? ToleranceMinEpaisseur { get; set; }
        public string ClasseDeChute { get; set; }
        public int? LongueurCd { get; set; }
        public int? ToleranceMaxLongueur { get; set; }
        public int? ToleranceMinLongueur { get; set; }
        public string MarqueCommerciale { get; set; }
        public string NumeroMontage { get; set; }
        public string CodeDemiProduit { get; set; }
        public int? PoidsDemiProduitUnitaire { get; set; }
        public int? NombreDemiProduit { get; set; }
        public string AcompteSolde { get; set; }
        public int? PoidsPrevuDemiProduit { get; set; }
        public string RangOpePits { get; set; }
        public string CodeOpePits { get; set; }
        public string LibelleConsignePits { get; set; }
        public string CodeConsignePits { get; set; }
        public int? H2coulee { get; set; }
        public int? NumeroFour1 { get; set; }
        public DateTime? DateEnfournementFour1 { get; set; }
        public int? NumeroFour2 { get; set; }
        public DateTime? DateEnfournementFour2 { get; set; }
        public string RangOpeLingot { get; set; }
        public string CodeOpeLingot { get; set; }
        public string CodeConsigneLingot { get; set; }
        public string LibelleConsigneLingot { get; set; }
        public string ProfileLamine { get; set; }
        public int? SectionLaminage { get; set; }
        public int? ToleranceMaxSection1 { get; set; }
        public int? ToleranceMinSection1 { get; set; }
        public int? EpaisseurEnLaminage { get; set; }
        public int? ToleranceMaxEpaisseur1 { get; set; }
        public int? ToleranceMinEpaisseur1 { get; set; }
        public int? PriseDeFer { get; set; }
        public string CodeOpeChutage { get; set; }
        public string RangOpeChutage { get; set; }
        public string CodeConsigneChutage { get; set; }
        public string LibelleConsigneChutage { get; set; }
        public string Destination { get; set; }
        public int? ChutageTete { get; set; }
        public int? ChutagePied { get; set; }
        public string CodeOpeDecoupe { get; set; }
        public string RangOpeDecoupe { get; set; }
        public string CodeConsigneDecoupe { get; set; }
        public string LibelleConsigneDecoupe { get; set; }
        public string OutilDecoupe { get; set; }
        public int? LongueurMoyenne { get; set; }
        public string CodeOpePoidMetrique { get; set; }
        public string RangOpePoidMetrique { get; set; }
        public string CodeConsignePoidMetrique { get; set; }
        public string LibelleConsignePoidMetrique { get; set; }
        public string CodeOpeRefroidissoir { get; set; }
        public string RangOpeRefroidissoir { get; set; }
        public string CodeConsigneRefroidissoir { get; set; }
        public string LibelleConsigneRefroidissoir { get; set; }
        public int? MatriculeClient { get; set; }
        public string RefroidissementBloom { get; set; }
        public int? NombreLingotsFour1 { get; set; }
        public int? NombreLingotsFour2 { get; set; }
        public string Oforigin { get; set; }
        public string Ofdestination { get; set; }
        public string OforiginInterne { get; set; }
        public string OfdestinationInterne { get; set; }
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
        public string CodeOpeSvt { get; set; }
        public string RangOpeSvt { get; set; }
        public string CodeConsigneSvt { get; set; }
        public string LibelleConsigneSvt { get; set; }
        public string Nuance { get; set; }
        public string Client { get; set; }
        public DateTime DateReception { get; set; }
    }
}