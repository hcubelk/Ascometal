using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDPanne
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public string Commentaire { get; set; }
        public string CodeArretReference { get; set; }
        public int Poste { get; set; }
        public string OtCode { get; set; }
        public string OtObservation { get; set; }
        public string Of { get; set; }
    }
}
