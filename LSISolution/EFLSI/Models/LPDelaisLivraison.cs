using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_DELAIS_LIVRAISON")]
    public partial class LPDelaisLivraison
    {
        public int Code { get; set; }
        [Column(TypeName = "decimal(2, 1)")]
        public decimal Lingot { get; set; }
        [Required]
        [StringLength(4)]
        public string Valeur { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
    }
}