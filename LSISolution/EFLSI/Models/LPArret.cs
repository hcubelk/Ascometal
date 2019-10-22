using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_ARRET")]
    public partial class LPArret
    {
        [Key]
        public int IdArret { get; set; }
        [Required]
        [StringLength(3)]
        public string Code { get; set; }
        [Required]
        [StringLength(100)]
        public string Libelle { get; set; }
        [Required]
        [StringLength(50)]
        public string Affectation { get; set; }
        [Required]
        [StringLength(25)]
        public string Type { get; set; }
        [Required]
        [StringLength(4)]
        public string Categorie { get; set; }
        public int Priorite { get; set; }
        [Column("DateMAJ", TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
    }
}