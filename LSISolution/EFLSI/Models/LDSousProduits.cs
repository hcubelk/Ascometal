using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_SOUS_PRODUITS")]
    public partial class LDSousProduits
    {
        public int NumeroLingot { get; set; }
        [StringLength(6)]
        public string Coulee { get; set; }
        public int Id { get; set; }
        [Column(TypeName = "decimal(5, 3)")]
        public decimal Longueur { get; set; }
        public int Poids { get; set; }
        public bool Rebute { get; set; }
        public int PoidsTheorique { get; set; }
        public int? EboutageTete { get; set; }
        public int? EboutagePied { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? LgCage900 { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? LgDeveloppe { get; set; }
        [Required]
        public bool? ProduitFini { get; set; }
        [Required]
        [StringLength(3)]
        public string ProfilProduit { get; set; }
        [StringLength(8)]
        public string NumProduit { get; set; }
        [StringLength(8)]
        public string Parent { get; set; }
        [Column(TypeName = "decimal(7, 3)")]
        public decimal PoidsEboutagePied { get; set; }
        [Column(TypeName = "decimal(7, 3)")]
        public decimal PoidsEboutageTete { get; set; }
        public int? TemperatureT03 { get; set; }

        [ForeignKey("NumeroLingot,Coulee")]
        [InverseProperty("LDSousProduits")]
        public virtual LDPso LDPso { get; set; }
    }
}