using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_DEFAUT")]
    public partial class LPDefaut
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Libelle { get; set; }
        [Required]
        public bool? Externe { get; set; }
    }
}