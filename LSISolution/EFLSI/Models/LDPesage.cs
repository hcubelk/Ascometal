using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_PESAGE")]
    public partial class LDPesage
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
        [Required]
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        public int NumPaquet { get; set; }
        public int? Status { get; set; }
        public int? Poids { get; set; }
        public int? PoidsDeclare { get; set; }
        public int? Etat { get; set; }
        [StringLength(15)]
        public string Lieu { get; set; }
        public int? NbreProduit { get; set; }
        public int? TypePesee { get; set; }
    }
}