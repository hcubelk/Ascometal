using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_COEFFDILATATION")]
    public partial class LPCoeffdilatation
    {
        [Key]
        public int Temperature { get; set; }
        public double Coefficient { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
    }
}