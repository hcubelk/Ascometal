using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_CONSIGNES_SCARFING")]
    public partial class LPConsignesScarfing
    {
        [Key]
        [StringLength(2)]
        public string Code { get; set; }
        [Required]
        [StringLength(3)]
        public string TypeGaz { get; set; }
        [Column(TypeName = "decimal(2, 1)")]
        public decimal Pression1 { get; set; }
        [Column(TypeName = "decimal(2, 1)")]
        public decimal Pression2 { get; set; }
        [Column(TypeName = "decimal(2, 1)")]
        public decimal Pression3 { get; set; }
        public int Vitesse1 { get; set; }
        public int Vitesse2 { get; set; }
        public int Vitesse3 { get; set; }
        [Required]
        [StringLength(5)]
        public string LpLt { get; set; }
        public int MiseauMille { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
    }
}