using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_CAGES")]
    public partial class LDCages
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string NumCage { get; set; }
        [Column(TypeName = "decimal(5, 3)")]
        public decimal Longueur { get; set; }
        [Column(TypeName = "decimal(5, 3)")]
        public decimal Profondeur { get; set; }
        [Required]
        [StringLength(250)]
        public string Commentaire { get; set; }
        public int Tonnage { get; set; }
        public int TonnageMaximum { get; set; }
        public int TypeCage { get; set; }
        [Required]
        [StringLength(50)]
        public string Zone { get; set; }
        [StringLength(15)]
        public string NumCylInferieur { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal DiametreInferieur { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateChangement { get; set; }
        [StringLength(100)]
        public string Fournisseur { get; set; }
        public bool EnService { get; set; }
        [StringLength(15)]
        public string NumCylSuperieur { get; set; }
        public int? TonnageVie { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal DiametreSuperieur { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateUsinage { get; set; }
        [Column("DateMiseADisposition", TypeName = "datetime")]
        public DateTime? DateMiseAdisposition { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatePremiereMiseEnService { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMiseEnService { get; set; }
        [StringLength(50)]
        public string Observations { get; set; }
        [StringLength(4)]
        public string Cannelure1 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure1 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure1 { get; set; }
        [StringLength(4)]
        public string Cannelure2 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure2 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure2 { get; set; }
        [StringLength(4)]
        public string Cannelure3 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure3 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure3 { get; set; }
        [StringLength(4)]
        public string Cannelure4 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure4 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure4 { get; set; }
        [StringLength(4)]
        public string Cannelure5 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure5 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure5 { get; set; }
        [StringLength(4)]
        public string Cannelure6 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure6 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure6 { get; set; }
        [StringLength(4)]
        public string Cannelure7 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure7 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure7 { get; set; }
        [StringLength(4)]
        public string Cannelure8 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure8 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure8 { get; set; }
        [StringLength(4)]
        public string Cannelure9 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure9 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure9 { get; set; }
        [StringLength(4)]
        public string Cannelure10 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure10 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure10 { get; set; }
        [StringLength(4)]
        public string Cannelure11 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure11 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure11 { get; set; }
        [StringLength(4)]
        public string Cannelure12 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure12 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure12 { get; set; }
        [StringLength(4)]
        public string Cannelure13 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure13 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure13 { get; set; }
        [StringLength(4)]
        public string Cannelure14 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure14 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure14 { get; set; }
        [StringLength(4)]
        public string Cannelure15 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? LargeurCannelure15 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfondeurCannelure15 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure1 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure1 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure2 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure2 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure3 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure3 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure4 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure4 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure5 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure5 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure6 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure6 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure7 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure7 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure8 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure8 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure9 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure9 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure10 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure10 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure11 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure11 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure12 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure12 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure13 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure13 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure14 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure14 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Largeur2Cannelure15 { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Profondeur2Cannelure15 { get; set; }
        public int? TonnageUsinage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMiseHorsService { get; set; }
    }
}