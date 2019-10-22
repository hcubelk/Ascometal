using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_DEFAUT")]
    public partial class LDDefaut
    {
        [Column("ID")]
        public int Id { get; set; }
        public int NumeroLingot { get; set; }
        [Required]
        [StringLength(6)]
        public string Coulee { get; set; }
        [Column("ParamDefautID")]
        public int ParamDefautId { get; set; }

        [ForeignKey("NumeroLingot,Coulee")]
        [InverseProperty("LDDefaut")]
        public virtual LDPso LDPso { get; set; }
    }
}