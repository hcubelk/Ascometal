using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_LIEUX_STOCK_PAQUETS_PESEE")]
    public partial class LPLieuxStockPaquetsPesee
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string Lieu { get; set; }
        [Required]
        [StringLength(25)]
        public string Libelle { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
    }
}