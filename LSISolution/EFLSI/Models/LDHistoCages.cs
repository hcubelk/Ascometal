using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_HISTO_CAGES")]
    public partial class LDHistoCages
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string NumCage { get; set; }
        public int TypeCage { get; set; }
        [StringLength(15)]
        public string NumCylInferieur { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal DiametreInferieur { get; set; }
        [StringLength(15)]
        public string NumCylSuperieur { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal DiametreSuperieur { get; set; }
        public int Tonnage { get; set; }
        public int TonnageUsinage { get; set; }
        public int TonnageMaximum { get; set; }
        public int? TonnageVie { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMiseEnService { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMiseHorsService { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateUsinage { get; set; }
    }
}