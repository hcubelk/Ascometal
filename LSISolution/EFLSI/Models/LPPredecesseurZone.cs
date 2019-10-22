using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_PREDECESSEUR_ZONE")]
    public partial class LPPredecesseurZone
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Zone { get; set; }
        [Required]
        [StringLength(50)]
        public string Libelle { get; set; }
        [StringLength(5)]
        public string Destination1 { get; set; }
        [StringLength(5)]
        public string Destination2 { get; set; }
        [StringLength(5)]
        public string Destination3 { get; set; }
    }
}