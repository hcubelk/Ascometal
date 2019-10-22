using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_CONSIGNES_DEGAZAGE_GLOBAL")]
    public partial class LPConsignesDegazageGlobal
    {
        [Key]
        public int Code { get; set; }
        [Required]
        [StringLength(10)]
        public string Tableau { get; set; }
        [Required]
        public string StandardM { get; set; }
    }
}