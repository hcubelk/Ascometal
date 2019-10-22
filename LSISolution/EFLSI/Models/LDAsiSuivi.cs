using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_ASI_SUIVI")]
    public partial class LDAsiSuivi
    {
        public int Id { get; set; }
        [Required]
        [StringLength(6)]
        public string Coulee { get; set; }
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [StringLength(3)]
        public string NoEnregistrement { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
        [StringLength(15)]
        public string Commande { get; set; }
        [StringLength(250)]
        public string Message { get; set; }
    }
}