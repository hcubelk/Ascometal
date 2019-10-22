using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_PROG_BILLETTE")]
    public partial class LPProgBillette
    {
        public int Id { get; set; }
        public int Programme { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal Section { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? Largeur { get; set; }
        [Required]
        [StringLength(3)]
        public string Profile { get; set; }
        [Required]
        [StringLength(3)]
        public string Monture { get; set; }
        [Required]
        [StringLength(250)]
        public string Observations { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? CoteBouchon { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? CalibrageOvale { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? CalibrageRond { get; set; }
        [Column("OuverturePOV")]
        [StringLength(3)]
        public string OuverturePov { get; set; }
        [Column("OuvertureOV")]
        [StringLength(3)]
        public string OuvertureOv { get; set; }
        [StringLength(3)]
        public string OuvertureRond { get; set; }
        public int NombrePasse { get; set; }
        [StringLength(5)]
        public string CanelurePasse1 { get; set; }
        [StringLength(4)]
        public string ElevationPasse1 { get; set; }
        public bool QuartierPasse1 { get; set; }
        [StringLength(5)]
        public string CanelurePasse2 { get; set; }
        [StringLength(4)]
        public string ElevationPasse2 { get; set; }
        public bool QuartierPasse2 { get; set; }
        [StringLength(5)]
        public string CanelurePasse3 { get; set; }
        [StringLength(4)]
        public string ElevationPasse3 { get; set; }
        public bool QuartierPasse3 { get; set; }
        [StringLength(5)]
        public string CanelurePasse4 { get; set; }
        [StringLength(4)]
        public string ElevationPasse4 { get; set; }
        public bool QuartierPasse4 { get; set; }
        [StringLength(5)]
        public string CanelurePasse5 { get; set; }
        [StringLength(4)]
        public string ElevationPasse5 { get; set; }
        public bool QuartierPasse5 { get; set; }
        [StringLength(5)]
        public string CanelurePasse6 { get; set; }
        [StringLength(4)]
        public string ElevationPasse6 { get; set; }
        public bool QuartierPasse6 { get; set; }
        [StringLength(5)]
        public string CanelurePasse7 { get; set; }
        [StringLength(4)]
        public string ElevationPasse7 { get; set; }
        public bool QuartierPasse7 { get; set; }
        [StringLength(5)]
        public string CanelurePasse8 { get; set; }
        [StringLength(4)]
        public string ElevationPasse8 { get; set; }
        public bool QuartierPasse8 { get; set; }
        [StringLength(5)]
        public string CanelurePasse9 { get; set; }
        [StringLength(4)]
        public string ElevationPasse9 { get; set; }
        public bool QuartierPasse9 { get; set; }
        [StringLength(5)]
        public string CanelurePasse10 { get; set; }
        [StringLength(4)]
        public string ElevationPasse10 { get; set; }
        public bool QuartierPasse10 { get; set; }
        [StringLength(5)]
        public string CanelurePasse11 { get; set; }
        [StringLength(4)]
        public string ElevationPasse11 { get; set; }
        public bool QuartierPasse11 { get; set; }
        [StringLength(5)]
        public string CanelurePasse12 { get; set; }
        [StringLength(4)]
        public string ElevationPasse12 { get; set; }
        public bool QuartierPasse12 { get; set; }
        [StringLength(5)]
        public string CanelurePasse13 { get; set; }
        [StringLength(4)]
        public string ElevationPasse13 { get; set; }
        public bool QuartierPasse13 { get; set; }
        [StringLength(5)]
        public string CanelurePasse14 { get; set; }
        [StringLength(4)]
        public string ElevationPasse14 { get; set; }
        public bool QuartierPasse14 { get; set; }
        [StringLength(5)]
        public string CanelurePasse15 { get; set; }
        [StringLength(4)]
        public string ElevationPasse15 { get; set; }
        public bool QuartierPasse15 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateMaj { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreation { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? SectionMin { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? SectionMax { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? PriseDeFerHauteur { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? PriseDeFerLargeur { get; set; }
    }
}