using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_D_KLA1")]
    public partial class LDKla1
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public int Delai { get; set; }
        [Required]
        [StringLength(7)]
        public string Nuance { get; set; }
        [Required]
        [StringLength(20)]
        public string Client { get; set; }
        [Required]
        [Column("OF")]
        [StringLength(12)]
        public string Of { get; set; }
        [Required]
        [StringLength(4)]
        public string CodeDemiProduit { get; set; }
        public int Montage { get; set; }
        public int NombreLingotsChaud { get; set; }
        public int NombreLingotsFroid { get; set; }
        [Required]
        [StringLength(3)]
        public string Pofil { get; set; }
        public int Dimension { get; set; }
        public bool Refroidissement { get; set; }
        public int Pits { get; set; }
        [Required]
        [StringLength(250)]
        public string Observations { get; set; }
        [Required]
        [StringLength(3)]
        public string Verif { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateReception { get; set; }
    }
}