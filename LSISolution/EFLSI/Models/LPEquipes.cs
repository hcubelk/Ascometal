using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_EQUIPES")]
    public partial class LPEquipes
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Contremaitre { get; set; }
        [StringLength(25)]
        public string IdEquipe { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
    }
}