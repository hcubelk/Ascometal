using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_FOURS")]
    public partial class LDFours
    {
        public LDFours()
        {
            LDPlansFours = new HashSet<LDPlansFours>();
        }

        [StringLength(3)]
        public string Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Libelle { get; set; }
        public int NombreLingot { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal PoidsEnfourne { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DebutDefournement { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinEnfournement { get; set; }
        public int Seuil { get; set; }
        public int NombrePositions { get; set; }
        public bool EnfournementStandard { get; set; }
        [Column("OFEnCours")]
        [StringLength(12)]
        public string OfenCours { get; set; }

        [InverseProperty("Four")]
        public virtual ICollection<LDPlansFours> LDPlansFours { get; set; }
    }
}