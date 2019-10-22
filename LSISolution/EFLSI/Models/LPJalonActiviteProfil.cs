using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_JALON_ACTIVITE_PROFIL")]
    public partial class LPJalonActiviteProfil
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string Libelle { get; set; }
        [Required]
        [StringLength(255)]
        public string Commentaires { get; set; }
        [Required]
        [Column("AffichageIHM")]
        [StringLength(1)]
        public string AffichageIhm { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
    }
}