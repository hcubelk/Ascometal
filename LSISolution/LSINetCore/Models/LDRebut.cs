using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDRebut
    {
        public string Of { get; set; }
        public int RangLingotPassageAuLaminoir { get; set; }
        public DateTime DateRebut { get; set; }
        public int Nombre { get; set; }
        public string CodeRebut { get; set; }
        public string Commentaire { get; set; }
        public int Poids { get; set; }
        public int Poste { get; set; }
        public string Monture { get; set; }
        public int TypeCage { get; set; }
        public string Cage { get; set; }
        public string IdEquipe { get; set; }
        public string Pdf { get; set; }

        public virtual LDOrdreFabrication OfNavigation { get; set; }
    }
}
