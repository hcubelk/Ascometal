using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LPJalonActiviteProfil
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Commentaires { get; set; }
        public string AffichageIhm { get; set; }
        public DateTime? DateMaj { get; set; }
    }
}
