using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_JALONDEPRODUCTION")]
    public partial class LDJalondeproduction
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        public string ProfilActivite { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? Section { get; set; }
        [StringLength(3)]
        public string Montage { get; set; }
        [Column("PSO")]
        [StringLength(4)]
        public string Pso { get; set; }
        [Column(TypeName = "decimal(10, 3)")]
        public decimal? PoidsUnitaire { get; set; }
        public int? NbLgtPrevu { get; set; }
        public int? DureeLaminageTheorique { get; set; }
        public int? CadenceTheorique { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HeureDebut { get; set; }
        public int? DureeLaminageReelle { get; set; }
        [StringLength(1)]
        public string Scarfing { get; set; }
        [StringLength(3)]
        public string LanminageControle { get; set; }
        public string DateDebutAuPlusTot { get; set; }
        public string Motif { get; set; }
        public int? NbLgtReel { get; set; }
    }
}