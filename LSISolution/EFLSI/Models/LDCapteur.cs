using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_CAPTEUR")]
    public partial class LDCapteur
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Capteur { get; set; }
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        public int? Etat { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
        [Required]
        [StringLength(1)]
        public string Type { get; set; }
        public int? NbOk { get; set; }
        public int? NbDef { get; set; }
    }
}