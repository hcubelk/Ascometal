using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDPso
    {
        public LDPso()
        {
            LDDefaut = new HashSet<LDDefaut>();
            LDSousProduits = new HashSet<LDSousProduits>();
            LDStockPso = new HashSet<LDStockPso>();
        }

        public string Coulee { get; set; }
        public int NumeroLingot { get; set; }
        public string Of { get; set; }
        public int NumeroWagon { get; set; }
        public decimal? CoteBloomingHauteur { get; set; }
        public decimal? CoteBloomingLargeur { get; set; }
        public string CoteBloomingCommentaire { get; set; }
        public decimal? CoteCage900Hauteur { get; set; }
        public decimal? CoteCage900Largeur { get; set; }
        public decimal? CoteCage900Epaulement1 { get; set; }
        public decimal? CoteCage900Epaulement2 { get; set; }
        public string CoteCage900Commentaire { get; set; }
        public bool Arefroidir { get; set; }
        public int Etat { get; set; }
        public bool DefautsTete { get; set; }
        public bool DefautsPied { get; set; }
        public DateTime? DateEnfournement { get; set; }
        public DateTime? DateDefournement { get; set; }
        public int? RangPassageAuLaminoir { get; set; }
        public int PoidsTheorique { get; set; }
        public int Poids { get; set; }
        public string Reperage { get; set; }
        public int? TemperatureScarfing { get; set; }
        public int? TemperatureT07 { get; set; }
        public int? TemperatureT03 { get; set; }
        public int Operation { get; set; }
        public string Action { get; set; }
        public int? ChutageTete { get; set; }
        public int? ChutagePied { get; set; }
        public int? EboutageTete { get; set; }
        public int? EboutagePied { get; set; }
        public string ConsigneScarfing { get; set; }
        public decimal? LgDeveloppee { get; set; }
        public decimal? Densite { get; set; }
        public decimal? PoidsChuteTete { get; set; }
        public decimal? PoidsChutePied { get; set; }
        public decimal? PoidsEboutagePied { get; set; }
        public decimal? PoidsEboutageTete { get; set; }
        public bool? Externe { get; set; }
        public DateTime? DateRefroidissement { get; set; }

        public virtual LDCoulee CouleeNavigation { get; set; }
        public virtual LDOrdreFabrication OfNavigation { get; set; }
        public virtual ICollection<LDDefaut> LDDefaut { get; set; }
        public virtual ICollection<LDSousProduits> LDSousProduits { get; set; }
        public virtual ICollection<LDStockPso> LDStockPso { get; set; }
    }
}
