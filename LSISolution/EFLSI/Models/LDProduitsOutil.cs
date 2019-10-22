using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_PRODUITS_OUTIL")]
    public partial class LDProduitsOutil
    {
        [StringLength(10)]
        public string Zone { get; set; }
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [StringLength(3)]
        public string Ligne { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HeureArrivee { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HeureSortie { get; set; }
        public int? Nombre { get; set; }
        [StringLength(250)]
        public string Commentaire { get; set; }
    }
}