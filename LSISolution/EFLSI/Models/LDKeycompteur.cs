using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_KEYCOMPTEUR")]
    public partial class LDKeycompteur
    {
        [Column("ID")]
        [StringLength(50)]
        public string Id { get; set; }
        [Column("VALUE")]
        public int Value { get; set; }
    }
}