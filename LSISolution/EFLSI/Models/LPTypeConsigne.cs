using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFLSI.Models
{
    [Table("L_P_TYPE_CONSIGNE")]
    public partial class LPTypeConsigne
    {
        public LPTypeConsigne()
        {
            LPConsignesChutage = new HashSet<LPConsignesChutage>();
            LPConsignesCodeoutilCoupe = new HashSet<LPConsignesCodeoutilCoupe>();
            LPConsignesDecoupe = new HashSet<LPConsignesDecoupe>();
            LPConsignesLingot = new HashSet<LPConsignesLingot>();
            LPConsignesMarquage = new HashSet<LPConsignesMarquage>();
            LPConsignesPits = new HashSet<LPConsignesPits>();
            LPConsignesPoidsmetrique = new HashSet<LPConsignesPoidsmetrique>();
            LPConsignesRefroidissoirs = new HashSet<LPConsignesRefroidissoirs>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Required]
        public string Libelle { get; set; }

        [InverseProperty("ConsignesNavigation")]
        public virtual ICollection<LPConsignesChutage> LPConsignesChutage { get; set; }
        [InverseProperty("ConsignesNavigation")]
        public virtual ICollection<LPConsignesCodeoutilCoupe> LPConsignesCodeoutilCoupe { get; set; }
        [InverseProperty("ConsignesNavigation")]
        public virtual ICollection<LPConsignesDecoupe> LPConsignesDecoupe { get; set; }
        [InverseProperty("ConsignesNavigation")]
        public virtual ICollection<LPConsignesLingot> LPConsignesLingot { get; set; }
        [InverseProperty("ConsignesNavigation")]
        public virtual ICollection<LPConsignesMarquage> LPConsignesMarquage { get; set; }
        [InverseProperty("ConsignesNavigation")]
        public virtual ICollection<LPConsignesPits> LPConsignesPits { get; set; }
        [InverseProperty("ConsignesNavigation")]
        public virtual ICollection<LPConsignesPoidsmetrique> LPConsignesPoidsmetrique { get; set; }
        [InverseProperty("ConsignesNavigation")]
        public virtual ICollection<LPConsignesRefroidissoirs> LPConsignesRefroidissoirs { get; set; }
    }
}