using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_LOG_COMMANDE")]
    public partial class LDLogCommande
    {
        public int Id { get; set; }
        [Required]
        public string Commande { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [Required]
        [StringLength(50)]
        public string User { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        public int NumLingot { get; set; }
        public bool? Trace { get; set; }
    }
}