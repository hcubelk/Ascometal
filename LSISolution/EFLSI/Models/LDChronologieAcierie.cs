using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_CHRONOLOGIE_ACIERIE")]
    public partial class LDChronologieAcierie
    {
        [Key]
        [Column("ordre_visualisation")]
        public int OrdreVisualisation { get; set; }
        [Column("atelier")]
        [StringLength(40)]
        public string Atelier { get; set; }
        [Column("etat_phase")]
        [StringLength(40)]
        public string EtatPhase { get; set; }
        [Column("afficher")]
        public bool? Afficher { get; set; }
        [Column("donnees_coulee1")]
        [StringLength(16)]
        public string DonneesCoulee1 { get; set; }
        [Column("donnees_coulee2")]
        [StringLength(16)]
        public string DonneesCoulee2 { get; set; }
        [Column("donnees_coulee3")]
        [StringLength(16)]
        public string DonneesCoulee3 { get; set; }
        [Column("donnees_coulee4")]
        [StringLength(16)]
        public string DonneesCoulee4 { get; set; }
        [Column("donnees_coulee5")]
        [StringLength(16)]
        public string DonneesCoulee5 { get; set; }
        [Column("donnees_coulee6")]
        [StringLength(16)]
        public string DonneesCoulee6 { get; set; }
        [Column("donnees_coulee7")]
        [StringLength(16)]
        public string DonneesCoulee7 { get; set; }
        [Column("donnees_coulee8")]
        [StringLength(16)]
        public string DonneesCoulee8 { get; set; }
        [Column("donnees_coulee9")]
        [StringLength(16)]
        public string DonneesCoulee9 { get; set; }
        [Column("donnees_coulee10")]
        [StringLength(16)]
        public string DonneesCoulee10 { get; set; }
        [Column("donnees_coulee11")]
        [StringLength(16)]
        public string DonneesCoulee11 { get; set; }
        [Column("donnees_coulee12")]
        [StringLength(16)]
        public string DonneesCoulee12 { get; set; }
        [Column("donnees_coulee13")]
        [StringLength(16)]
        public string DonneesCoulee13 { get; set; }
        [Column("donnees_coulee14")]
        [StringLength(16)]
        public string DonneesCoulee14 { get; set; }
        [Column("donnees_coulee15")]
        [StringLength(16)]
        public string DonneesCoulee15 { get; set; }
    }
}