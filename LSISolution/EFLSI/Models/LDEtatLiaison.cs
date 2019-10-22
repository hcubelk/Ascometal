using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_ETAT_LIAISON")]
    public partial class LDEtatLiaison
    {
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string Code { get; set; }
        [Required]
        [StringLength(50)]
        public string Libelle { get; set; }
        [Required]
        [StringLength(50)]
        public string TypeLiaison { get; set; }
        [Required]
        [Column("AdresseIP")]
        [StringLength(15)]
        public string AdresseIp { get; set; }
        public bool Etat { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
    }
}