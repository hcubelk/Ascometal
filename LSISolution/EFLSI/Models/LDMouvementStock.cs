using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_MOUVEMENT_STOCK")]
    public partial class LDMouvementStock
    {
        [Column("ID")]
        public int Id { get; set; }
        public int Type { get; set; }
        [StringLength(25)]
        public string LieuParc { get; set; }
        [StringLength(25)]
        public string LieuPits { get; set; }
        [Required]
        [Column("PSO")]
        [StringLength(4)]
        public string Pso { get; set; }
        [Required]
        [StringLength(6)]
        public string Coulee { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMouvement { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatePrevue { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDisponibilite { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateDemande { get; set; }
        public int? PoidsTotal { get; set; }
        public int? NbTotalEntres { get; set; }
        public int? NbEntres { get; set; }
        public int? NbSortis { get; set; }
        [StringLength(250)]
        public string Observations { get; set; }
        [StringLength(12)]
        public string Consigne { get; set; }
        public int Etat { get; set; }
    }
}