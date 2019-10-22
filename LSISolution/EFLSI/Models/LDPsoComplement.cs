using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_PSO_COMPLEMENT")]
    public partial class LDPsoComplement
    {
        [StringLength(6)]
        public string Coulee { get; set; }
        public int NumeroLingot { get; set; }
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [Column("TypePSO")]
        [StringLength(4)]
        public string TypePso { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LgTheorique1500T { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LgTheoriqueCage900 { get; set; }
        [Column("DateMajPSO", TypeName = "datetime")]
        public DateTime? DateMajPso { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLg1500T { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLgCage900 { get; set; }
    }
}