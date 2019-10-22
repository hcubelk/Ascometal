using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_MONTAGE_SECTION_MAM")]
    public partial class LPMontageSectionMam
    {
        [Column("ID")]
        public int Id { get; set; }
        public int Montage { get; set; }
        [Required]
        [StringLength(3)]
        public string Profil { get; set; }
        public int SectionMin { get; set; }
        public int SectionMax { get; set; }
        public int? Rendement1 { get; set; }
        public int? Rendement2 { get; set; }
        public int? Rendement3 { get; set; }
        [StringLength(4)]
        public string Cannelure { get; set; }
        public int? MaM1 { get; set; }
        public int? MaM2 { get; set; }
        public int? Jalon { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMaj { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? RayonChutage { get; set; }
        public int? DureeMontage { get; set; }
        public int? DureeReglage { get; set; }
    }
}