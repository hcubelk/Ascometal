using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_S_RAPPORT_SYNTHESE_MENSUELLE")]
    public partial class LSRapportSyntheseMensuelle
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(35)]
        public string LabelNom { get; set; }
        [StringLength(20)]
        public string NomCol { get; set; }
        public bool? Rapport { get; set; }
        [StringLength(25)]
        public string LabelDate { get; set; }
        [StringLength(12)]
        public string ValeurMois1 { get; set; }
        [StringLength(12)]
        public string ValeurMois2 { get; set; }
        [StringLength(12)]
        public string ValeurMois3 { get; set; }
        [StringLength(12)]
        public string ValeurMois4 { get; set; }
        [StringLength(12)]
        public string ValeurMois5 { get; set; }
        [StringLength(12)]
        public string ValeurMois6 { get; set; }
        [StringLength(12)]
        public string ValeurMois7 { get; set; }
        [StringLength(12)]
        public string ValeurMois8 { get; set; }
        [StringLength(12)]
        public string ValeurMois9 { get; set; }
        [StringLength(12)]
        public string ValeurMois10 { get; set; }
        [StringLength(12)]
        public string ValeurMois11 { get; set; }
        [StringLength(12)]
        public string ValeurMois12 { get; set; }
        [StringLength(12)]
        public string Cumul { get; set; }
    }
}