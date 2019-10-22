using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_FOUR_ACIER")]
    public partial class LDFourAcier
    {
        [Key]
        [Column("coulee")]
        [StringLength(6)]
        public string Coulee { get; set; }
        [Column("nuance")]
        [StringLength(7)]
        public string Nuance { get; set; }
        [Column("phase")]
        [StringLength(25)]
        public string Phase { get; set; }
        [Column("energie")]
        [StringLength(6)]
        public string Energie { get; set; }
        [Column("etat")]
        [StringLength(6)]
        public string Etat { get; set; }
        [Column("date_arret")]
        [StringLength(16)]
        public string DateArret { get; set; }
        [Column("duree_arret")]
        [StringLength(4)]
        public string DureeArret { get; set; }
        [Column("date_maj")]
        [StringLength(16)]
        public string DateMaj { get; set; }
    }
}