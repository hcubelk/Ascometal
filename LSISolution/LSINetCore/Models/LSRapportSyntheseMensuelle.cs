using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LSRapportSyntheseMensuelle
    {
        public int Id { get; set; }
        public string LabelNom { get; set; }
        public string NomCol { get; set; }
        public bool? Rapport { get; set; }
        public string LabelDate { get; set; }
        public string ValeurMois1 { get; set; }
        public string ValeurMois2 { get; set; }
        public string ValeurMois3 { get; set; }
        public string ValeurMois4 { get; set; }
        public string ValeurMois5 { get; set; }
        public string ValeurMois6 { get; set; }
        public string ValeurMois7 { get; set; }
        public string ValeurMois8 { get; set; }
        public string ValeurMois9 { get; set; }
        public string ValeurMois10 { get; set; }
        public string ValeurMois11 { get; set; }
        public string ValeurMois12 { get; set; }
        public string Cumul { get; set; }
    }
}
