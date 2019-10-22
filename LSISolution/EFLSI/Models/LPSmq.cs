using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_SMQ")]
    public partial class LPSmq
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        public string StandardM { get; set; }
        [Required]
        public string Action { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
    }
}