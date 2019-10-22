using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_ETAT_STOCK")]
    public partial class LDEtatStock
    {
        [Key]
        [StringLength(25)]
        public string Lieu { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatePremiereEntree { get; set; }
        [Required]
        [StringLength(6)]
        public string Coulee { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDerniereSortie { get; set; }
        public int? NbStock { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
        [Required]
        [Column("PSO")]
        [StringLength(4)]
        public string Pso { get; set; }
        public int? PoidsTotal { get; set; }
        public int PoidsUnitaire { get; set; }
    }
}